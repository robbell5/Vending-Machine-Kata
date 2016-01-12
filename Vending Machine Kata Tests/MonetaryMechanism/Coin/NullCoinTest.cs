using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
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
