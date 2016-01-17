using System.Collections.Generic;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata_Tests.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    [TestFixture]
    public class CoinReturnTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoinReturn), new CoinReturn());
        }

        [Test]
        public void TestCoinReturnStartsWithEmptyCoinList()
        {
            CoinReturn coinReturn = new CoinReturn();
            Assert.AreEqual(new List<ICoin>(), coinReturn.Coins);
        }

        [Test]
        public void TestAddPutsCoinIntoCoinList()
        {
            CoinReturn coinReturn = new CoinReturn();
            MockCoin coinAdded = new MockCoin();

            coinReturn.AddCoin(coinAdded);
            Assert.AreEqual(new List<ICoin>() { coinAdded }, coinReturn.Coins);
        }

        [Test]
        public void TestAddPutsCoinIntoCoinListMultipleCoins()
        {
            CoinReturn coinReturn = new CoinReturn();

            MockCoin firstCoinAdded = new MockCoin();
            MockCoin secondCoinAdded = new MockCoin();
            MockCoin thirdCoinAdded = new MockCoin();

            List<ICoin> expectedCoins = new List<ICoin>()
            {
                firstCoinAdded,
                secondCoinAdded,
                thirdCoinAdded
            };

            coinReturn.AddCoin(firstCoinAdded);
            coinReturn.AddCoin(secondCoinAdded);
            coinReturn.AddCoin(thirdCoinAdded);

            Assert.AreEqual(expectedCoins, coinReturn.Coins);
        }

        [TestCase(1, 2, 3)]
        [TestCase(0.33, 11.23, 11.56)]
        [TestCase(1.13, 3.99, 5.12)]
        public void TestClearReturnsValueOfAllCoins(decimal coinOneValue, decimal coinTwoValue, decimal expectedTotalValue)
        {
            CoinReturn coinReturn = new CoinReturn();
            coinReturn.AddCoin(new MockCoin() {ValueToReturn = coinOneValue });
            coinReturn.AddCoin(new MockCoin() {ValueToReturn = coinTwoValue });

            Assert.AreEqual(expectedTotalValue, coinReturn.Clear());
        }

        [Test]
        public void TestClearEmptiesCoinList()
        {
            CoinReturn coinReturn = new CoinReturn();

            MockCoin firstCoinAdded = new MockCoin();
            MockCoin secondCoinAdded = new MockCoin();
            MockCoin thirdCoinAdded = new MockCoin();

            coinReturn.AddCoin(firstCoinAdded);
            coinReturn.AddCoin(secondCoinAdded);
            coinReturn.AddCoin(thirdCoinAdded);

            coinReturn.Clear();

            Assert.AreEqual(new List<ICoin>(), coinReturn.Coins);
        }

        [Test]
        public void TestRegisterAddsObserverToObserverList()
        {
            CoinReturn coinReturn = new CoinReturn();
            MockCoinReturnObserver mockCoinReturnObserver = new MockCoinReturnObserver();

            coinReturn.RegisterObserver(mockCoinReturnObserver);

            Assert.AreEqual(1, coinReturn.Observers.Count);
            Assert.AreEqual(mockCoinReturnObserver, coinReturn.Observers[0]);
        }

        [Test]
        public void TestAddingACoinCallsCoinReturnUpdatedOnObservers()
        {
            CoinReturn coinReturn = new CoinReturn();
            MockCoinReturnObserver mockCoinReturnObserverOne = new MockCoinReturnObserver();
            MockCoinReturnObserver mockCoinReturnObserverTwo = new MockCoinReturnObserver();

            coinReturn.RegisterObserver(mockCoinReturnObserverOne);
            coinReturn.RegisterObserver(mockCoinReturnObserverTwo);

            coinReturn.AddCoin(new MockCoin());

            Assert.AreEqual(1, mockCoinReturnObserverOne.NumberOfTimesCoinPurseUpdatedCalled);
            Assert.AreEqual(1, mockCoinReturnObserverTwo.NumberOfTimesCoinPurseUpdatedCalled);
        }

        [Test]
        public void TestClearCallsCoinReturnUpdatedOnObservers()
        {
            CoinReturn coinReturn = new CoinReturn();
            MockCoinReturnObserver mockCoinReturnObserverOne = new MockCoinReturnObserver();
            MockCoinReturnObserver mockCoinReturnObserverTwo = new MockCoinReturnObserver();

            coinReturn.RegisterObserver(mockCoinReturnObserverOne);
            coinReturn.RegisterObserver(mockCoinReturnObserverTwo);

            coinReturn.Clear();

            Assert.AreEqual(1, mockCoinReturnObserverOne.NumberOfTimesCoinPurseUpdatedCalled);
            Assert.AreEqual(1, mockCoinReturnObserverTwo.NumberOfTimesCoinPurseUpdatedCalled);
        }

        [Test]
        public void TestAmoutAvaibleReturnsValueOfAllCoinsInTheReturn()
        {
            CoinReturn coinReturn = new CoinReturn();

            decimal expectedValue = 4.00m;
            MockCoin mockCoinOne = new MockCoin() { ValueToReturn = expectedValue};

            coinReturn.AddCoin(mockCoinOne);

            Assert.AreEqual(expectedValue, coinReturn.AmountAvailable);
        }

        [Test]
        public void TestAmoutAvaibleReturnsValueOfAllCoinsInTheReturnMulitpleCoins()
        {
            CoinReturn coinReturn = new CoinReturn();

            MockCoin mockCoinOne = new MockCoin() {ValueToReturn = 1.00m};
            MockCoin mockCoinTwo = new MockCoin() {ValueToReturn = 99.28m};
            MockCoin mockCoinThree = new MockCoin() {ValueToReturn = 123.123m};

            decimal expectedValue = mockCoinOne.ValueToReturn + mockCoinTwo.ValueToReturn + mockCoinThree.ValueToReturn;

            coinReturn.AddCoin(mockCoinOne);
            coinReturn.AddCoin(mockCoinTwo);
            coinReturn.AddCoin(mockCoinThree);

            Assert.AreEqual(expectedValue, coinReturn.AmountAvailable);
        }
    }
}
