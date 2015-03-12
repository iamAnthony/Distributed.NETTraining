namespace CSharpDiscovery
{
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class InheritanceAndPolymorphismTests
    {
        //[Test]
        //public void SplitCalculatorClassInTwoClasses()
        //{
        //    // Create a StringCalculator class that derives from Calculator, and move Sum with string paremeter, instantiate the two classes
        //    // Make StringCalculator sealed, try to create a derived class from it => compiler complains
        //    Check.That(calculator.Sum(new[] {1.3, 1.8})).Equals(stringCalculator.Sum("1,3+1,8"));
        //}

        //[Test]
        //public void DefineAnIntegerCalculatorClassThatReplacesSumMethodOfCalculator()
        //{
        //    // IntegerCalculator must a silly implementation that cast double to int before doing sum, use new to redefine Sum method => its a completely different method, DO NOT USE TOO MUCH new keyword, it breaks polymorphism
        //    var integerCalculator = new IntegerCalculator();
        //    double sum = integerCalculator.Sum(new[] { 1.4, 1.7 });
        //    Check.That(sum).Equals(2.0);
        //    Calculator calculator = integerCalculator;
        //    sum = calculator.Sum(new[] { 1.4, 1.7 });
        //    Check.That(sum).Equals(1.4 + 1.7);
        //}

        //[Test]
        //public void DefineAnotherIntegerCalculatorClassThatOverridesSumMethodOfCalculator()
        //{
        //    // IntegerCalculator must a silly implementation that cast double to int before doing sum, use override to redefine Sum method, base Sum method must be virtual
        //    var integerCalculator = new AnotherIntegerCalculator();
        //    double sum = integerCalculator.Sum(new[] { 1.4, 1.7 });
        //    Check.That(sum).Equals(2.0);
        //    Calculator calculator = integerCalculator;
        //    sum = calculator.Sum(new[] { 1.4, 1.7 });
        //    Check.That(sum).Equals(2.0);
        //}

        //[Test]
        //public void DefineAnAbstractStringCalculatorClassAndImplementItForSumAndProduct()
        //{
        //    AbstractStringCalculator calculator = new SumAbstractStringCalculator();
        //    var sum = calculator.Calculate("1+2,3");
        //    Check.That(sum).Equals(1 + 2.3);
        //    calculator = new ProductStringCalculator();
        //    var product = calculator.Calculate("2*2,6");
        //    Check.That(product).Equals(2 * 2.6);
        //}

        //[Test]
        //public void CompositionAndPolymorphismWithInterfaceRatherThanInheritance()
        //{
        //    var calculatorWithStrategies = new ComposedStringCalculator(new IComputeStrategy[] { new SumStrategy(), new ProductStrategy() });
        //    var sum = calculatorWithStrategies.Calculate("1,0+2,3");
        //    var product = calculatorWithStrategies.Calculate("2,0*2,3");
        //    Check.That(sum).Equals(1.0 + 2.3);
        //    Check.That(product).Equals(2.0 * 2.3);
        //}
    }
}
