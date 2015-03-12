namespace CSharpDiscovery
{
    using System;
    using System.Collections.Generic;
    using NFluent;
    using NFluent.Extensions;
    using NUnit.Framework;

    [TestFixture]
    public class ExceptionsTests
    {
        //[Test]
        //public void TryCatchSpecificExceptions()
        //{
        //    // add a method parsing a string to integer (int.Parse), with try/catch to catch FormatException (Note that compiler does not complains for a try/catch or throws like in Java)
        //    var integer = ConvertStringToIntegerWithDefaultValuesWhenExceptionsOccur("abc");
        //    Check.That(integer).Equals(0);
        //}

        //[Test]
        //public void TryCatchSeveralExceptions()
        //{
        //    // add a catch clause for OverflowException
        //    var integer = ConvertStringToIntegerWithDefaultValuesWhenExceptionsOccur(long.MaxValue.ToString());
        //    Check.That(integer).Equals(int.MaxValue);
        //}

        //[Test]
        //public void TryCatchAnyOtherException()
        //{
        //    // add a catch clause for ArgumentNullException
        //    var integer = ConvertStringToIntegerWithDefaultValuesWhenExceptionsOccur(null);
        //    Check.That(integer).Equals(0);
        //    // then remove "duplicated code" between FormatException and AgumentNullException catches, use a catch without any type
        //}

        //[Test]
        //public void FinallyIsCalledEvenWhenAnExceptionIsThrown()
        //{
        //    // Create the method CheckThatStringCanBeConvertedToInteger that takes a string as parameter, try to parse, and returns list of actions, it should add one action in try/catch/finally
        //    var actions = CheckThatStringCanBeConvertedToInteger("abc");
        //    Check.That(actions).ContainsExactly("Try to parse", "Catch do nothing", "Finally do nothing");
        //    // NB : Finally block is particularly useful to free resources like File or DbConnection, if there is or not an exception
        //}

        //[Test]
        //public void CreateANewExceptionAndThrowIt()
        //{
        //    Check.That(ThrowACustomException).Throws<CustomException>();
        //}

        //[Test]
        //public void WhenParsingAnIntFromStringEncapsulateEveryExceptionInCustomException()
        //{
        //    try
        //    {
        //        ConvertStringToInteger("abc");
        //    }
        //    catch (CustomException e)
        //    {
        //        Check.That(e.InnerException).IsInstanceOf<FormatException>();
        //    }
        //    catch
        //    {
        //        Assert.Fail();
        //    }
        //}
    }
}
