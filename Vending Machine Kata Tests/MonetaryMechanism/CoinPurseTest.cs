using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata_Tests.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    [TestFixture]
    public class CoinPurseTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoinPurse), new CoinPurse());
        }

        [Test]
        public void TestCoinPurseStartsWithEmptyCoinList()
        {
            CoinPurse coinPurse = new CoinPurse();
            Assert.AreEqual(new List<ICoin>(), coinPurse.Coins);
        }

        [Test]
        public void TestAddPutsCoinIntoCoinList()
        {
            CoinPurse coinPurse = new CoinPurse();
            MockCoin coinAdded = new MockCoin();

            coinPurse.AddCoin(coinAdded);
            Assert.AreEqual(new List<ICoin>() {coinAdded}, coinPurse.Coins);
        }

        [Test]
        public void TestAddPutsCoinIntoCoinListMultipleCoins()
        {
            CoinPurse coinPurse = new CoinPurse();

            MockCoin firstCoinAdded = new MockCoin();
            MockCoin secondCoinAdded = new MockCoin();
            MockCoin thirdCoinAdded = new MockCoin();

            List<ICoin> expectedCoins = new List<ICoin>()
            {
                firstCoinAdded,
                secondCoinAdded,
                thirdCoinAdded
            };

            coinPurse.AddCoin(firstCoinAdded);
            coinPurse.AddCoin(secondCoinAdded);
            coinPurse.AddCoin(thirdCoinAdded);

            Assert.AreEqual(expectedCoins, coinPurse.Coins);
        }

        [Test]
        public void TestAmountAvailableReturnsTotalValueOfCoinsInPurse()
        {
            CoinPurse coinPurse = new CoinPurse();

            decimal expectedValueOfAllCoins = 5.55m;
            MockCoin coinAdded = new MockCoin() {ValueToReturn = expectedValueOfAllCoins};

            coinPurse.AddCoin(coinAdded);
            Assert.AreEqual(expectedValueOfAllCoins, coinPurse.AmountAvailable());
        }

        [Test]
        public void TestAmountAvailableReturnsTotalValueOfCoinsInPurseMultipleCoins()
        {
            CoinPurse coinPurse = new CoinPurse();

            decimal expectedValueOfAllCoins = 0;

            const decimal firstCoinValue = 1.25m;
            MockCoin firstCoinAdded = new MockCoin() { ValueToReturn = firstCoinValue };
            expectedValueOfAllCoins += firstCoinValue;

            const decimal secondCoinValue = 0.25m;
            MockCoin secondCoinAdded = new MockCoin() { ValueToReturn = secondCoinValue };
            expectedValueOfAllCoins += secondCoinValue;

            const decimal thirdCoinValue = 4.25m;
            MockCoin thirdCoinAdded = new MockCoin() { ValueToReturn = thirdCoinValue };
            expectedValueOfAllCoins += thirdCoinValue;

            coinPurse.AddCoin(firstCoinAdded);
            coinPurse.AddCoin(secondCoinAdded);
            coinPurse.AddCoin(thirdCoinAdded);

            Assert.AreEqual(expectedValueOfAllCoins, coinPurse.AmountAvailable());
        }
    }
}
