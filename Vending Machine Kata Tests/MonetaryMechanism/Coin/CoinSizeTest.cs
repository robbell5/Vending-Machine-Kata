using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    [TestFixture]
    public class CoinSizeTest
    {
        [TestCase(CoinSize.Tiny, 1)]
        [TestCase(CoinSize.Small, 2)]
        [TestCase(CoinSize.Medium, 3)]
        [TestCase(CoinSize.Large, 4)]
        public void TestEnumValues(CoinSize coinSize, int expectedValue)
        {
            Assert.AreEqual(expectedValue, coinSize.GetHashCode());
        }
    }
}
