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
        public List<ICoin> Coins { get; }

        public CoinPurse()
        {
            Coins = new List<ICoin>();
        }

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
        }

        public decimal AmountAvailable()
        {
            return Coins.Sum(coin => coin.Value);
        }
    }
}
