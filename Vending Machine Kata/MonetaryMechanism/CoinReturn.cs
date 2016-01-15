using System.Collections.Generic;
using System.Linq;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinReturn : ICoinReturn
    {
        public List<ICoin> Coins { get; private set; } = new List<ICoin>();
        public List<ICoinReturnObserver> Observers { get; } = new List<ICoinReturnObserver>();
        public decimal AmountAvailable { get { return Coins.Sum(coin => coin.Value); } }

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

            NotifyObservers();

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