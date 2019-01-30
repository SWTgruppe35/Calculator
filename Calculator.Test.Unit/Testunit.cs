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

        [Test]
        public void Add_Add2and2_Return4()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
        }
    }
}

