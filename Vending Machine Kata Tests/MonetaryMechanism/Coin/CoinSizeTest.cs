using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    [TestFixture]
    public class CoinSizeTest
    {
        [TestCase(CoinSize.TINY, 1)]
        [TestCase(CoinSize.SMALL, 2)]
        [TestCase(CoinSize.MEDIUM, 3)]
        [TestCase(CoinSize.LARGE, 4)]
        public void TestEnumValues(CoinSize coinSize, int expectedValue)
        {
            Assert.AreEqual(expectedValue, coinSize.GetHashCode());
        }
    }
}
