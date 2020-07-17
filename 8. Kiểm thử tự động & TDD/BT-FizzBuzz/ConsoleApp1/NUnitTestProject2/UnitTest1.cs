using NUnit.Framework;
using ConsoleApp1.Service;
namespace NUnitTestProject2
{
    public class Tests
    {
        private FizzBuzz _fizzbuzz;
        [SetUp]
        public void Setup()
        {
            _fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void Test1()
        {

            Assert.AreEqual("FizzBuzz", _fizzbuzz.BuzzFizz(45));
        }
    }
}