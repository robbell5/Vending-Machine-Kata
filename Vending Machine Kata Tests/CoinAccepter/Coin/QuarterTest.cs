using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.CoinAccepter.Coin;

namespace Vending_Machine_Kata_Tests.CoinAccepter.Coin
{
    [TestFixture]
    public class QuarterTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoin), new Quarter());
        }

        [Test]
        public void TestValue()
        {
            const decimal expectedQuarterValue = 0.25m;
            Assert.AreEqual(expectedQuarterValue, new Quarter().Value);
        }
    }
}
