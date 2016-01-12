﻿using System.Collections.Generic;
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

        [Test]
        public void TestClearReturnsAllCoins()
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

            Assert.AreEqual(expectedCoins, coinReturn.Clear());
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
    }
}