using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata_Tests.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    [TestFixture]
    public class CoinAccepterTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof (ICoinAccepter), new CoinAccepter(null, null, null));
        }

        [Test]
        public void TestProperties()
        {
            MockCoinFactory expectedCoinFactory = new MockCoinFactory();
            MockCoinPurse expectedCoinPurse = new MockCoinPurse();
            MockCoinReturn expectedCoinReturn = new MockCoinReturn();

            CoinAccepter coinAccepter = new CoinAccepter(expectedCoinFactory, expectedCoinPurse, expectedCoinReturn);

            Assert.AreSame(expectedCoinFactory, coinAccepter.CoinFactory);
            Assert.AreSame(expectedCoinPurse, coinAccepter.CoinPurse);
            Assert.AreSame(expectedCoinReturn, coinAccepter.CoinReturn);
        }

        [TestCase(CoinSize.Tiny)]
        [TestCase(CoinSize.Small)]
        [TestCase(CoinSize.Medium)]
        [TestCase(CoinSize.Large)]
        public void TestAcceptCallsBuildOnCoinFactoryWithSizeAndWeightPassed(CoinSize coinSize)
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, new MockCoinPurse(), new MockCoinReturn());
            coinAccepter.Accept(coinSize);

            Assert.AreEqual(1, mockCoinFactory.NumberOfTimesBuildCoinCalled);
            Assert.AreEqual(coinSize, mockCoinFactory.LastSizeAndWeightPassed);
        }

        [Test]
        public void TestAcceptAddsCoinReturnedByCoinFactoryToCoinPurseIfItHasValue()
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();

            MockCoin expectedCoin = new MockCoin {ValueToReturn = decimal.MaxValue};
            mockCoinFactory.CoinToReturn = expectedCoin;

            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse, new MockCoinReturn());
            coinAccepter.Accept(CoinSize.Tiny);

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesAddCoinWasCalled);
            Assert.AreEqual(1, mockCoinPurse.CoinsPassedToAddCoin.Count);
            Assert.AreEqual(expectedCoin, mockCoinPurse.CoinsPassedToAddCoin[0]);
        }

        [TestCase(0)]
        [TestCase(0.01)]
        [TestCase(0.04)]
        public void TestCoinWithNoValueIsPutIntoTheCoinReturnAndNotTheCoinPurse(decimal coinValue)
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();

            MockCoin mockCoin = new MockCoin {ValueToReturn = coinValue};
            mockCoinFactory.CoinToReturn = mockCoin;

            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse, mockCoinReturn);

            coinAccepter.Accept(CoinSize.Large);

            Assert.AreSame(mockCoin, mockCoinReturn.CoinsPassedToAddCoin[0]);
            Assert.AreEqual(1, mockCoinReturn.NumberOfTimesAddCoinCalled);
            Assert.AreEqual(0, mockCoinPurse.NumberOfTimesAddCoinWasCalled);
            Assert.AreEqual(0, mockCoinPurse.Coins.Count);
        }
    }
}
