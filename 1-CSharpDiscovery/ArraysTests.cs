using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ArraysTests
    {
        [Test]
        public void DeclareAOneDimensionArrayNotInitialized()
        {
            // use int[] as type to declare an integer array initialized to null
            int[] integerArray = null;
            Check.That(integerArray).IsNull();
        }

        [Test]
        public void DeclareAOneDimensionArrayInitializedWithTwoElements()
        {
            // use new int[] {}, 1 and 2 as values, and var as type
            var integerArray = new int[] { 1, 2 };
            Check.That(integerArray).HasSize(2);
            Check.That(integerArray).ContainsExactly(1, 2);
        }

        [Test]
        public void AccessAOneDimensionArrayValueAtAGivenExistingIndex()
        {
            // declare an integer array with 2 integers, the second must be 2 (with type inference, i.e no need to specify the type, since provided values type give the type of the array)
            // get the second value of the array in secondValue var
            var integerArray = new int[] { 1, 2 };
            var secondValue = integerArray[1];
            Check.That(secondValue).Equals(2);
        }

        [Test]
        public void AccessAOneDimensionArrayValueOutOfRange()
        {
            // Create a method that takes no args, returns void and access the third value of an array with only two values
            Check.ThatCode(GetValueOutOfRangeOfAnArray).Throws<IndexOutOfRangeException>();
        }

        public void GetValueOutOfRangeOfAnArray()
        {
            var tableau = new int[] {1,2};
            var valeur = tableau[3];
        }

        [Test]
        public void SetAOneDimensionArrayValue()
        {
            // declare a string array, with 2 initial values ("plip", "plop" for example)
            // then set the second value (to "plup")

            var stringArray = new string[] { "plip", "plop" };
            stringArray[1] = "plup";
            Check.That(stringArray).ContainsExactly("plip", "plup");
        }

        [Test]
        public void TwoDimensionsArray()
        {
            // declare a two dimensions array with double[,], with 4.1 as the first value of the second dimension
            // access the first value of the second dimension
            var doubleArray = new double[,] {{1.0, 2.0},{4.1,3.0}};
            var firstValueOfSecondDimension = doubleArray[1,0];
            Check.That(firstValueOfSecondDimension).Equals(4.1);
        }

        [Test]
        public void JaggedArray()
        {
            // declare a jagged array with double[x][], where x is the nb of jagged arrays
            // add a jagged array in second position, with 4.1 as first value
            // access the first value of the second jagged array

            var doubleArray = new double[2][];
            doubleArray[0] = new double[] { 1.0, 2.0 };
            doubleArray[1] = new double[] { 4.1, 1.0 };

            var firstValueOfTheSecondArray = doubleArray[1][0];
            Check.That(firstValueOfTheSecondArray).Equals(4.1);
        }
    }
}
