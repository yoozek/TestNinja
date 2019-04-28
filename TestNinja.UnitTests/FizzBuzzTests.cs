using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        public void GetOutput_InputIsDivisibleBy3Or5_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(15);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        
        public void GetOutput_InputIsDivisibleBy5Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(5);
            
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);
            
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}