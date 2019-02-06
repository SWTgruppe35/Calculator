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

        private Calculator _uut = new Calculator();

        // Using the SetUp feature, saves coding (part of) the Arrange step
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
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

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(0, 4, -4)]
        [TestCase(3, 0, 3)]
        public void Sub_SubPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a,b), Is.EqualTo(result));
            
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(0, 4, 0)]
        [TestCase(3, 1, 3)]
        public void Multiply_PosAndNegNum_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a,b), Is.EqualTo(result));

        }

        [TestCase(6, 6, 1)]
        [TestCase(-6, -3, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(4, 1, 4)]
        [TestCase(0, 1, 0)]
        public void Divide_PosAndNegNum_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));

        }

        [Test]
        public void Divide_withZero_ExpThrown()
        {
            var thrown = false;

            try
            {
                _uut.Divide(10,0);
            }
            catch (DivideByZeroException)
            {
                thrown = true;
            }

            Assert.True(thrown);
        }

        [Test]
        public void AccumulatorNumplusNum()
        {
            _uut.Add(5,5);
            Assert.That(_uut.Accumulator, Is.EqualTo(10));
        }

        [Test]
        public void AccumulatorIsLastCalculation()
        {
            _uut.Subtract(5, 4);
            _uut.Multiply(10, 1);

            Assert.That(_uut.Accumulator, Is.EqualTo(10));
        }

        [Test]
        public void AccumulatorIsCleared()
        {
            _uut.Subtract(5, 4);
            _uut.Divide(10, 1);
            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }



    };
}

