namespace CSharpDiscovery
{
    using System;
    using System.Linq;
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class InheritanceAndPolymorphismTests
    {
        [Test]
        public void SplitCalculatorClassInTwoClasses()
        {
            // Create a StringCalculator class that derives from Calculator, and move Sum with string paremeter, instantiate the two classes
            // Make StringCalculator sealed, try to create a derived class from it => compiler complains
            var stringCalculator = new StringCalculator();
            var calculator = new Calculator();
            Check.That(calculator.Sum(new[] { 1.3, 1.8 })).Equals(stringCalculator.Sum("1,3+1,8"));
        }

        [Test]
        public void DefineAnIntegerCalculatorClassThatReplacesSumMethodOfCalculator()
        {
            // IntegerCalculator must a silly implementation that cast double to int before doing sum, use new to redefine Sum method => its a completely different method, DO NOT USE TOO MUCH new keyword, it breaks polymorphism
            var integerCalculator = new IntegerCalculator();
            double sum = integerCalculator.Sum(new[] { 1.4, 1.7 });
            Check.That(sum).Equals(2.0);
            Calculator calculator = integerCalculator;
            sum = calculator.Sum(new[] { 1.4, 1.7 });
            Check.That(sum).Equals(1.4 + 1.7);
        }

        [Test]
        public void DefineAnotherIntegerCalculatorClassThatOverridesSumMethodOfCalculator()
        {
            // IntegerCalculator must a silly implementation that cast double to int before doing sum, use override to redefine Sum method, base Sum method must be virtual
            var integerCalculator = new AnotherIntegerCalculator();
            double sum = integerCalculator.Sum(new[] { 1.4, 1.7 });
            Check.That(sum).Equals(2.0);
            Calculator calculator = integerCalculator;
            sum = calculator.Sum(new[] { 1.4, 1.7 });
            Check.That(sum).Equals(2.0);
        }

        [Test]
        public void DefineAnAbstractStringCalculatorClassAndImplementItForSumAndProduct()
        {
            AbstractStringCalculator calculator = new SumAbstractStringCalculator();
            var sum = calculator.Calculate("1+2,3");
            Check.That(sum).Equals(1 + 2.3);
            calculator = new ProductStringCalculator();
            var product = calculator.Calculate("2*2,6");
            Check.That(product).Equals(2 * 2.6);
        }

        [Test]
        public void CompositionAndPolymorphismWithInterfaceRatherThanInheritance()
        {
            var calculatorWithStrategies = new ComposedStringCalculator(new IComputeStrategy[] { new SumStrategy(), new ProductStrategy() });
            var sum = calculatorWithStrategies.Calculate("1,0+2,3");
            var product = calculatorWithStrategies.Calculate("2,0*2,3");
            Check.That(sum).Equals(1.0 + 2.3);
            Check.That(product).Equals(2.0 * 2.3);
        }
    }

    public class ProductStrategy : IComputeStrategy
    {
        public double Calculate(string operation)
        {
            return operation.Split('*').Select(double.Parse).Aggregate<Double>((a, b) => a * b);
        }

        public bool CanCalculate(string operation)
        {
            return operation.Contains('*');
        }
    }

    public class SumStrategy : IComputeStrategy
    {
        public double Calculate(string operation)
        {
            return operation.Split('+').Select(double.Parse).Sum();
        }

        public bool CanCalculate(string operation)
        {
            return operation.Contains('+');
        }
    }

    public interface IComputeStrategy
    {
        double Calculate(string operation);
        bool CanCalculate(string operation);
    }

    public class ComposedStringCalculator
    {
        private IComputeStrategy[] cs;
        public ComposedStringCalculator(IComputeStrategy[] computeStrategy)
        {
            this.cs = computeStrategy;
        }

        public double Calculate(string operation)
        {
            foreach (var strategy in this.cs)
            {
                if (strategy.CanCalculate(operation))
                {
                    return strategy.Calculate(operation);
                }
            }
            return 0.0;
        }
    }

    public abstract class AbstractStringCalculator
    {
        public abstract double Calculate(string operation);
    }

    public class SumAbstractStringCalculator : AbstractStringCalculator
    {
        public override double Calculate(string operation)
        {
            var numbers = operation.Split('+');
            return (double.Parse(numbers[0].Trim()) + double.Parse(numbers[1].Trim()));
        }
    }
    public class ProductStringCalculator : AbstractStringCalculator
    {
        public override double Calculate(string operation)
        {
            return operation.Split('*').Select(double.Parse).Aggregate<Double>((a, b) => a * b);
        }
    }

    public class AnotherIntegerCalculator : Calculator
    {
        public override double Sum(double[] array)
        {
            return array.Select(i => (int)i).Sum();
        }
    }

    public class IntegerCalculator : Calculator
    {
        public new double Sum(double[] array)
        {
            return array.Select(i => (int)i).Sum();
        }

    }

    public class StringCalculator : Calculator
    {
        private const double pi = 3.14;

        public StringCalculator()
        {
            
        }
     public double Sum(string operation)
        {
            var numbers = operation.Split('+');
            for (int i = 0; i < numbers.Length; i++ )
            {
                if (numbers[i].Trim().Equals("pi"))
                    numbers[i] = pi.ToString();
            }
            return (double.Parse(numbers[0].Trim()) + double.Parse(numbers[1].Trim()));
        }
    }
}
