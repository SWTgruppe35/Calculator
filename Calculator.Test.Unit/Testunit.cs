using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class TestUnit
    {
        private Calculator _uut;

        // Using the SetUp feature, saves coding (part of) the Arrange step
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_Add2and2_Return4()
        {
            Assert.That(_uut.Add(2,2), Is.EqualTo(4));
        }
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            // Combining the Act and Assert steps is also possible
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }
    }
}

