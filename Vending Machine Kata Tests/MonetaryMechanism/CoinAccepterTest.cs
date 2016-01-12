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
            Assert.IsInstanceOf(typeof(ICoinAccepter), new CoinAccepter(null, null));
        }

        [Test]
        public void TestProperties()
        {
            MockCoinFactory expectedCoinFactory = new MockCoinFactory();
            MockCoinPurse expectedCoinPurse = new MockCoinPurse();

            CoinAccepter coinAccepter = new CoinAccepter(expectedCoinFactory, expectedCoinPurse);

            Assert.AreSame(expectedCoinFactory, coinAccepter.CoinFactory);
            Assert.AreSame(expectedCoinPurse, coinAccepter.CoinPurse);
        }

        [TestCase(CoinPhysicalProperties.SizeAndWeight.UNKNOWN)]
        [TestCase(CoinPhysicalProperties.SizeAndWeight.SMALL)]
        [TestCase(CoinPhysicalProperties.SizeAndWeight.MEDIUM)]
        [TestCase(CoinPhysicalProperties.SizeAndWeight.LARGE)]
        public void TestAcceptCallsBuildOnCoinFactoryWithSizeAndWeightPassed(CoinPhysicalProperties.SizeAndWeight expectedCoinSizeAndWeight)
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, new MockCoinPurse());
            coinAccepter.Accept(expectedCoinSizeAndWeight);

            Assert.AreEqual(1, mockCoinFactory.NumberOfTimesBuildCoinCalled);
            Assert.AreEqual(expectedCoinSizeAndWeight, mockCoinFactory.LastSizeAndWeightPassed);
        }

        [Test]
        public void TestAcceptAddsCoinReturnedByCoinFactoryToCoinPurse()
        {
            MockCoinFactory mockCoinFactory = new MockCoinFactory();
            MockCoin expectedCoin = new MockCoin();
            mockCoinFactory.CoinToReturn = expectedCoin;

            MockCoinPurse mockCoinPurse = new MockCoinPurse();

            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse);
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

            MockCoinPurse mockCoinPurse = new MockCoinPurse();
            mockCoinPurse.AmountAvailableToReturn = expectedAmount;

            CoinAccepter coinAccepter = new CoinAccepter(mockCoinFactory, mockCoinPurse);
            decimal actualAmountReturned = coinAccepter.Accept(CoinPhysicalProperties.SizeAndWeight.UNKNOWN);

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesAmountAvailableWasCalled);
            Assert.AreEqual(expectedAmount, actualAmountReturned);
        }

    }
}
