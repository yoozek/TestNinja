using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15,"FizzBuzz")]
        [TestCase(3,"Fizz")]
        [TestCase(5,"Buzz")]
        [TestCase(1,"1")]
        public void GetOutput_WhenCalled_ReturnExpectedResult(int number, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(number);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}