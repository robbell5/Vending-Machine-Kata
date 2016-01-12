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
    public class NickleTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoin), new Nickel());
        }

        [Test]
        public void TestValue()
        {
            const decimal expectedNickleValue = 0.05m;
            Assert.AreEqual(expectedNickleValue, new Nickel().Value);
        }
    }
}
