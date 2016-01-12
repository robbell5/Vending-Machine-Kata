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

        [TestCase(typeof(Dime), CoinPhysicalProperties.SizeAndWeight.SMALL)]
        [TestCase(typeof(Nickel), CoinPhysicalProperties.SizeAndWeight.MEDIUM)]
        [TestCase(typeof(Quarter), CoinPhysicalProperties.SizeAndWeight.LARGE)]
        [TestCase(typeof(NullCoin), CoinPhysicalProperties.SizeAndWeight.UNKNOWN)]
        public void TestBuildsCorrectCoinForGivenSizeAndWeight(Type expectedType, CoinPhysicalProperties.SizeAndWeight coinSizeAndWeight)
        {
            CoinFactory coinFactory = new CoinFactory();
            ICoin coin = coinFactory.BuildCoin(coinSizeAndWeight);

            Assert.IsInstanceOf(expectedType, coin);
        }
    }
}
