namespace CSharpDiscovery
{
    using System;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class Calculator
    {
        private string name;
        private static readonly double Pi = 3.14;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Calculator(string name)
        {
            this.Name = name;
        }

        public Calculator()
        {
        }

        public double Sum(double[] valuesToSum)
        {
            return StaticSum(valuesToSum);
        }

        public double Sum(string sumOfTwoDoubleFromString)
        {
            var valuesToSum = sumOfTwoDoubleFromString.Split('+').Select(
                s =>
                {
                    var value = s.Replace(" ", string.Empty);
                    if (value == "pi")
                    {
                        return Pi;
                    }
                    return double.Parse(value);
                }).ToArray();
            return this.Sum(valuesToSum);
        }

        public static double StaticSum(double[] valuesToSum)
        {
            var result = 0.0;
            foreach (var value in valuesToSum)
            {
                result += value;
            }
            return result;
        }
    }
}