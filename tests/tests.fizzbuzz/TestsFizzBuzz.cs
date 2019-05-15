using fizzbuzz;
using NUnit.Framework;

namespace Tests
{
    
    public class TestsFizzBuzz
    {
        private Robot robot;
        
        [SetUp]
        public void Setup()
        {
            robot = new Robot();
        }

        [Test]
        public void Multiplos_de_3()
        {
            Assert.AreEqual("fizz", robot.Fizzbuzz(3));
            Assert.AreEqual("fizz", robot.Fizzbuzz(9));
            Assert.AreEqual("fizz", robot.Fizzbuzz(12));
            Assert.AreEqual("fizz", robot.Fizzbuzz(24));
        }

        [Test]
        public void Multiplos_de_5()
        {
            Assert.AreEqual("buzz", robot.Fizzbuzz(5));
            Assert.AreEqual("buzz", robot.Fizzbuzz(10));
            Assert.AreEqual("buzz", robot.Fizzbuzz(25));
        }

         [Test]
        public void Multiplos_de_5_e_3()
        {
            Assert.AreEqual("fizzbuzz", robot.Fizzbuzz(15));
            Assert.AreEqual("fizzbuzz", robot.Fizzbuzz(30));
            Assert.AreEqual("fizzbuzz", robot.Fizzbuzz(120));
        }

        [Test]
        public void Outros_Numeros()
        {
            Assert.AreEqual("1", robot.Fizzbuzz(1));
            Assert.AreEqual("4", robot.Fizzbuzz(4));
            Assert.AreEqual("13", robot.Fizzbuzz(13));
        }
    }
}