using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "buzz")]
        [TestCase(6, "fizz")]
        [TestCase(9, "fizz")]
        [TestCase(10, "buzz")]
        [TestCase(12, "fizz")]
        [TestCase(15, "fizz buzz")]
        public void Test(int value, string expected)
        {
            var result = FizzBuzzGame.GetResponse(value);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
