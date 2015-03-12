namespace CSharpDiscovery
{
    using System;
    using NFluent;
    using NUnit.Framework;

    [TestFixture]
    public class ValueTypesTests
    {
        [Test]
        public void CreateAnEnumForCurrency()
        {
            var euro = Currency.Euro;
            Check.That(euro.ToString()).Equals("Euro");
        }

        [Test]
        public void SpecifyIntegerValueAndCastIntegerValueToCurrencyEnum()
        {
            var euro = (Currency) 10;
            Check.That(euro.ToString()).Equals("Euro");
        }

        [Test]
        public void TryParseStringValueToRetrieveCurrencyEnum()
        {
            // use Currency.TryParse
            Currency parsedCurrency;
            var parseSuccess = Currency.TryParse("Euro", out parsedCurrency);
            Check.That(parseSuccess).IsTrue();
            Check.That(parsedCurrency.ToString()).Equals("Euro");
        }

        [Test]
        public void DefineAStructForMoneyWithValueAndCurrency()
        {
            // Define a struct called Money with one constructor having value (double) and currency (Currency enum) arguments, that initialize struct fields
            var tenEuros = new Money(10.0, Currency.Euro);
            Check.That(tenEuros.Value).Equals(10.0);
            Check.That(tenEuros.Currency).Equals(Currency.Euro);
        }

        [Test]
        public void InstanciateTheMoneyStructTwiceWithSameArgumentsThenTheyAreEqual()
        {
            var tenEuros = new Money(10.0, Currency.Euro);
            var anotherTenEuros = new Money(10.0, Currency.Euro);
            Check.That(tenEuros).Equals(anotherTenEuros);
        }

        [Test]
        public void PassMoneyAsParameterOfAMethodThatModifiesItsMoneyArgumentValue()
        {
            // Create the method that take a Money struct as parameter, it is passed by value, not by reference, then argument given to the method is not modified
            var tenEuros = new Money(10.0, Currency.Euro);
            MakeTenEurosBecomeFifteen(tenEuros);
            Check.That(tenEuros.Value).Equals(10.0);
        }

        private void MakeTenEurosBecomeFifteen(Money money)
        {
            money.Value = 15;
        }

        [Test]
        public void PassMoneyAsParameterOfAMethodThatModifiesItsMoneyArgumentValuePassedByRef()
        {
            // Create the method that take a Money struct as parameter, it is explicitly passed by reference with ref keyword, then argument given to the method is modified
            var tenEuros = new Money(10.0, Currency.Euro);
            MakeTenEurosBecomeFifteenByRef(ref tenEuros);
            Check.That(tenEuros.Value).Equals(15.0);
        }

        private void MakeTenEurosBecomeFifteenByRef(ref Money money)
        {
            money.Value = 15;
        }
    }
}
