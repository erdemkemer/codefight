using System;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class Tests
    {
        private readonly FizzbuzzManager _fizzbuzzManager;

        public Tests()
        {
            _fizzbuzzManager = new FizzbuzzManager();
        }
        [Test]
        public void should_return_number_if_not_fizz_or_buzz()
        {
            int n = 1;
            Assert.AreEqual("1",_fizzbuzzManager.GetFizzbuzz(n));
        }


        [Test]
        public void should_return_fizz_if_divisible_by_3()
        {
            int n = 9;
            Assert.AreEqual("Fizz",_fizzbuzzManager.GetFizzbuzz(n));
        }

        [Test]
        public void should_return_buzz_if_divisible_by_5()
        {
            int n = 10;
            Assert.AreEqual("Buzz",_fizzbuzzManager.GetFizzbuzz(n));
        }

        [Test]
        public void should_return_fizzbuzz_if_divisible_by_5_and_3()
        {
            int n = 15;
            Assert.AreEqual("FizzBuzz",_fizzbuzzManager.GetFizzbuzz(n));
        }
    }
}