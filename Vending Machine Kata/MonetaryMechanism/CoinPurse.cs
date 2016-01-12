using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinPurse : ICoinPurse
    {
        public List<ICoin> Coins { get; private set; }
        public List<ICoinPurseObserver> Observers { get; private set; }

        public CoinPurse()
        {
            Observers = new List<ICoinPurseObserver>();
            Coins = new List<ICoin>();
        }

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
            NotifyObservers();
        }

        public decimal AmountAvailable()
        {
            return Coins.Sum(coin => coin.Value);
        }

        public void RegisterObserver(ICoinPurseObserver coinPurseObserver)
        {
            Observers.Add(coinPurseObserver);
        }

        private void NotifyObservers()
        {
            foreach (ICoinPurseObserver coinPurseObserver in Observers)
            {
                coinPurseObserver.CoinPurseUpdated();
            }
        }

        public List<ICoin> Clear()
        {
            List<ICoin> clearedCoins = new List<ICoin>();
            clearedCoins.AddRange(Coins);

            Coins = new List<ICoin>();

            return clearedCoins;
        }
    }
}
