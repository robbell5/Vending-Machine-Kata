﻿using System.Collections.Generic;
using System.Linq;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinPurse : ICoinPurse
    {
        public List<ICoin> Coins { get; private set; } = new List<ICoin>();
        public decimal AmountAvailable { get { return Coins.Sum(coin => coin.Value); } }
        public List<ICoinPurseObserver> Observers { get; } = new List<ICoinPurseObserver>();

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
            NotifyObservers();
        }

        public void RegisterObserver(ICoinPurseObserver coinPurseObserver)
        {
            Observers.Add(coinPurseObserver);
        }

        private void NotifyObservers()
        {
            Observers.ForEach(observer => observer.CoinPurseUpdated());
        }

        public List<ICoin> Clear()
        {
            List<ICoin> clearedCoins = new List<ICoin>();
            clearedCoins.AddRange(Coins);

            Coins = new List<ICoin>();
            NotifyObservers();

            return clearedCoins;
        }
    }
}
