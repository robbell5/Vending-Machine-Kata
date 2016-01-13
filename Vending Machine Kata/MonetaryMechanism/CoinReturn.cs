using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinReturn : ICoinReturn
    {
        public List<ICoin> Coins { get; private set; }
        public List<ICoinReturnObserver> Observers { get; private set; }

        public CoinReturn()
        {
            Observers = new List<ICoinReturnObserver>();
            Coins = new List<ICoin>();
        }

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
            NotifyObservers();
        }

        public List<ICoin> Clear()
        {
            List<ICoin> coinsCleared = new List<ICoin>();
            coinsCleared.AddRange(Coins);
            Coins = new List<ICoin>();

            return coinsCleared;
        }

        public void RegisterObserver(ICoinReturnObserver coinReturnObserver)
        {
            Observers.Add(coinReturnObserver);
        }

        private void NotifyObservers()
        {
            Observers.ForEach(observer => observer.CoinReturnUpdated());
        }
    }
}