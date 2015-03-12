namespace CSharpDiscovery
{
    public struct Money
    {
        public Money(double value, Currency currency) : this()
        {
            Value = value;
            Currency = currency;
        }

        public double Value { get; set; }
        public Currency Currency { get; set; }
    }
}