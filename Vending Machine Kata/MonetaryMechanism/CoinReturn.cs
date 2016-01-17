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

        public decimal Clear()
        {
            decimal sumOfAllCoins = AmountAvailable;
            Coins = new List<ICoin>();

            NotifyObservers();

            return sumOfAllCoins;
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