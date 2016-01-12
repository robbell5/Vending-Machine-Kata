using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinReturn : ICoinReturn
    {
        public List<ICoin> Coins { get; private set; }

        public CoinReturn()
        {
            Coins = new List<ICoin>();
        }

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
        }

        public List<ICoin> Clear()
        {
            List<ICoin> coinsCleared = new List<ICoin>();
            coinsCleared.AddRange(Coins);
            Coins = new List<ICoin>();

            return coinsCleared;
        }
    }
}