using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public interface ICoinPurse
    {
        void AddCoin(ICoin coin);
        decimal AmountAvailable();
        List<ICoin> Coins { get; }
        void RegisterObserver(ICoinPurseObserver coinPurseObserver);
        List<ICoin> Clear();
    }
}
