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
    public class CoinFactoryTest
    {
        [Test]
        public void TestImplementsInterface()
        {
           Assert.IsInstanceOf(typeof(ICoinFactory), new CoinFactory());
        }


        [Test]
        public void TestBuildsDimeFromSmallCoin()
        {
            CoinFactory coinFactory = new CoinFactory();
            ICoin coin = coinFactory.BuildCoin(CoinPhysicalProperties.SizeAndWeight.SMALL);

            Assert.IsInstanceOf(typeof(Dime), coin);
        }

        [Test]
        public void TestBuildsNickleFromMediumCoin()
        {
            CoinFactory coinFactory = new CoinFactory();
            ICoin coin = coinFactory.BuildCoin(CoinPhysicalProperties.SizeAndWeight.MEDIUM);

            Assert.IsInstanceOf(typeof(Nickel), coin);
        }

        [Test]
        public void TestBuildsQuarterFromLargeCoin()
        {
            CoinFactory coinFactory = new CoinFactory();
            ICoin coin = coinFactory.BuildCoin(CoinPhysicalProperties.SizeAndWeight.LARGE);

            Assert.IsInstanceOf(typeof(Quarter), coin);
        }

        [Test]
        public void TestBuildsNullCoinFromUnknownCoin()
        {
            CoinFactory coinFactory = new CoinFactory();
            ICoin coin = coinFactory.BuildCoin(CoinPhysicalProperties.SizeAndWeight.UNKNOWN);

            Assert.IsInstanceOf(typeof(NullCoin), coin);
        }
    }
}
