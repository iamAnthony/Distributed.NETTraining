namespace CSharpDiscovery
{
    using System;
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class DelegatesAndEventsTests
    {
        //[Test]
        //public void DefineADelegateAndAssignItFromAMethod()
        //{
        //    OperationDelegate operationDelegate = SumOperation;
        //    Check.That(operationDelegate(1.3, 1.5)).Equals(2.8);
        //}

        //[Test]
        //public void UsePredefinedFuncDelegateAndAssignItFromAMethod()
        //{
        //    // use Func<double, double, double> instead of OperationDelegate and assign the previous SumOperation method
        //    Check.That(operationDelegate(1.3, 1.5)).Equals(2.8);
        //}

        //[Test]
        //public void UsePredefinedFuncDelegateAndAssignItWithLambdaExpression()
        //{
        //    // use a lambda expression instead of a method, syntax mimics the mathematical notation of functions : two argument is represented as (a, b) followed by an arrow =>, then by what the function should do with arguments (here sum a and b)
        //    Check.That(operationDelegate(1.3, 1.5)).Equals(2.8);
        //}

        //[Test]
        //public void PassDelegateAsParameterOfCalculator()
        //{
        //    var calculator = new CalculatorWithDelegate(SumOperation);
        //    var sum = calculator.Calculate(new[] { 1.1, 2.3, 4.6 });
        //    Check.That(sum).Equals(8.0);
        //}

        //[Test]
        //public void ActionDelegateIsUsedForVoidReturnMethods()
        //{
        //    Action<string> checkThatIntegerCannotBeParsedFromString = CheckThatIntegerCannotBeParsedFromString;
        //    Check.ThatCode(() => checkThatIntegerCannotBeParsedFromString("abc")).Throws<FormatException>();
        //    // NB: () => ... notation is a lambda expression of a function that takes no argument (and return nothing/void in this case)
        //}

        //[Test]
        //public void UseEventToBeNotifiedOfSomethingHappened()
        //{
        //    var nbParseError = 0;
        //    Action incrementNbParseError = () => nbParseError++;
        //    var integerFromStringParser = new IntegerStringParser();
        //    integerFromStringParser.ParseError += incrementNbParseError;
        //    integerFromStringParser.Parse("abc");
        //    Check.That(nbParseError).Equals(1);
        //    integerFromStringParser.ParseError -= incrementNbParseError;
        //    integerFromStringParser.Parse("abc");
        //    Check.That(nbParseError).Equals(1);
        //}
    }
}
