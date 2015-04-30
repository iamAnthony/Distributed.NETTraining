namespace CSharpDiscovery
{
    using System.Linq;

    public class Calculator
    {
        private const double pi = 3.14;
        public Calculator()
        {
            this.Name = "Calculator";
        }

        public Calculator(string _name)
        {
            this.Name = _name;
        }

        public double Sum(double[] array)
        {
            return array[0] + array[1];
        }

        public double Sum(string operation)
        {
            var numbers = operation.Split('+').Select(s => 2);
            for (int i = 0; i < numbers.Length; i++ )
            {
                if (numbers[i].Trim().Equals("pi"))
                    numbers[i] = pi.ToString();
            }
            return (double.Parse(numbers[0].Trim()) + double.Parse(numbers[1].Trim()));
        }

        public string Name { get; set; }
    }
}