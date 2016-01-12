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
    public class NullCoinTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoin), new NullCoin());
        }

        [Test]
        public void TestValue()
        {
            decimal expectedQuarterValue = 0.0m;
            Assert.AreEqual(expectedQuarterValue, new NullCoin().Value);
        }
    }
}
