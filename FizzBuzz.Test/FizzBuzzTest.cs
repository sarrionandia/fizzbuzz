using NUnit.Framework;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        private static string ConvertToFizzBuzz(int input)
        {
            var fizzBuzz = new FizzBuzz(input);
            var result = fizzBuzz.Execute();
            return result;
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void ShouldReturnStringNumberForThingsThatArentFizzOrBuzzOrFizzBuzz(int input, string numberAsString)
        {
            var result = ConvertToFizzBuzz(input);
            
            Assert.AreEqual(numberAsString, result);
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void ShouldReturnFizzForMultiplesOfThree(int input)
        {
            var result = ConvertToFizzBuzz(input);
            
            Assert.AreEqual("FIZZ", result);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void ShouldReturnBuzzForMultiplesOfFive(int input)
        {
            var result = ConvertToFizzBuzz(input);
            
            Assert.AreEqual("BUZZ", result);
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void ShouldReturnFizzBuzzForFifteen(int input)
        {
            var result = ConvertToFizzBuzz(input);
            
            Assert.AreEqual("FIZZBUZZ", result);
        }
    }
}