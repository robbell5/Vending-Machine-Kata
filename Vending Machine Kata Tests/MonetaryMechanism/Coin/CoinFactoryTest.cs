using System;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    [TestFixture]
    public class CoinFactoryTest
    {
        [Test]
        public void TestImplementsInterface()
        {
           Assert.IsInstanceOf(typeof(ICoinFactory), new CoinFactory());
        }

        [TestCase(typeof(Penny), CoinSize.Small)]
        [TestCase(typeof(Dime), CoinSize.Tiny)]
        [TestCase(typeof(Nickel), CoinSize.Medium)]
        [TestCase(typeof(Quarter), CoinSize.Large)]
        [TestCase(typeof(NullCoin), null)]
        public void TestBuildsCorrectCoinForGivenSizeAndWeight(Type expectedType, CoinSize coinSize)
        {
            CoinFactory coinFactory = new CoinFactory();
            ICoin coin = coinFactory.BuildCoin(coinSize);

            Assert.IsInstanceOf(expectedType, coin);
        }
    }
}
