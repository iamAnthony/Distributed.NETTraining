using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ControlFlowTests
    {
        [Test]
        public void UseForToConcatenateStringArrayValues()
        {
            var stringConcatenated = string.Empty;
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a for, then refactor (but keep for loop) using StringBuilder (+ avoid "", use string.Empty instead) for memory usage reason
            for (int i = 0; i < stringArray.Length; i++ )
            {
                stringConcatenated += stringArray[i];
            }
                Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseForeachToConcatenateStringArrayValues()
        {
            var stringConcatenated = string.Empty;
            var stringArray = new[] { "plip", "plop", "plup" };
            // concatenate string array values in a single string with the simplest solution using a foreach
            foreach (string s in stringArray)
            {
                stringConcatenated += s;
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseWhileToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            var stringConcatenated = string.Empty;
            // concatenate string array values in a single string with the simplest solution using a while
            var i = 0;
            while (i < stringArray.Length){
                stringConcatenated += stringArray[i];
                i++;
            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseDoWhileToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            var stringConcatenated = string.Empty;
            // concatenate string array values in a single string with the simplest solution using a while
            var i = 0;
            do
            {
                stringConcatenated += stringArray[i];
                i++;
            } while (i < stringArray.Length);
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseIfElseElseIfDuringConcatenationOfStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup", "foo" };
            var stringConcatenated = string.Empty;
            // concatenate a string, with "good, " when item is plip, "not so good, " when item starts with "pl", "bad, " in any other case

            foreach (string s in stringArray)
            {
                if (s == "plip")
                {
                    stringConcatenated += "good, ";
                }
                else if(s.StartsWith("pl")){
                    stringConcatenated += "not so good, ";
                }
                else{
                    stringConcatenated += "bad, ";
                }
            }

            Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        }

        //[Test]
        //public void UseSwitchCaseDuringConcatenationOfStringArrayValues()
        //{
        //    var stringArray = new[] { "plip", "plop", "plup", "foo" };
        //    // concatenate a string, with "good, " when item is plip, "not so good, " when item is "plop", "plip", "bad, " in any other case
        //    Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        //}
    }
}
