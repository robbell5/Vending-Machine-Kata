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
            Assert.IsInstanceOf(typeof(ICoinAccepter), new CoinAccepter(null, null, null));
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

        [TestCase(CoinPhysicalProperties.SizeAndWeight.UNKNOWN)]
        [TestCase(CoinPhysicalProperties.SizeAndWeight.SMALL)]
        [TestCase(CoinPhysicalProperties.SizeAndWeight.MEDIUM)]
        [TestCase(CoinPhysicalProperties.SizeAndWeight.LARGE)]
        public void TestAcceptCallsBuildOnCoinFactoryWithSizeAndWeightPassed(CoinPhysicalProperties.SizeAndWeight expectedCoinSizeAndWeight)
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, new MockCoinPurse(), new MockCoinReturn());
            coinAccepter.Accept(expectedCoinSizeAndWeight);

            Assert.AreEqual(1, mockCoinFactory.NumberOfTimesBuildCoinCalled);
            Assert.AreEqual(expectedCoinSizeAndWeight, mockCoinFactory.LastSizeAndWeightPassed);
        }

        [Test]
        public void TestAcceptAddsCoinReturnedByCoinFactoryToCoinPurseIfItHasValue()
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();

            MockCoin expectedCoin = new MockCoin {ValueToReturn = decimal.MaxValue};
            mockCoinFactory.CoinToReturn = expectedCoin;

            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse, new MockCoinReturn());
            coinAccepter.Accept(CoinPhysicalProperties.SizeAndWeight.UNKNOWN);

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesAddCoinWasCalled);
            Assert.AreEqual(1, mockCoinPurse.CoinsPassedToAddCoin.Count);
            Assert.AreEqual(expectedCoin, mockCoinPurse.CoinsPassedToAddCoin[0]);
        }

        [TestCase(12.45)]
        [TestCase(445.1)]
        [TestCase(98.322)]
        [TestCase(0)]
        public void TestAcceptReturnsAmountAvailableFromCoinPurse(decimal expectedAmount)
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            MockCoinPurse mockCoinPurse = new MockCoinPurse {AmountAvailableToReturn = expectedAmount};


            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse, new MockCoinReturn());
            decimal actualAmountReturned = coinAccepter.Accept(CoinPhysicalProperties.SizeAndWeight.UNKNOWN);

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesAmountAvailableWasCalled);
            Assert.AreEqual(expectedAmount, actualAmountReturned);
        }

        [Test]
        public void TestCoinWithNoValueIsPutIntoTheCoinReturnAndNotTheCoinPurse()
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();

            MockCoin mockCoin = new MockCoin {ValueToReturn = 0};
            mockCoinFactory.CoinToReturn = mockCoin;

            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse, mockCoinReturn);

            decimal amountAvailable = coinAccepter.Accept(CoinPhysicalProperties.SizeAndWeight.SMALL);

            Assert.AreSame(mockCoin, mockCoinReturn.CoinsPassedToAddCoin[0]);
            Assert.AreEqual(1, mockCoinReturn.NumberOfTimesAddCoinCalled);
            Assert.AreEqual(0, amountAvailable);
            Assert.AreEqual(0, mockCoinPurse.NumberOfTimesAddCoinWasCalled);
            Assert.AreEqual(0, mockCoinPurse.Coins.Count);
        }
    }
}
