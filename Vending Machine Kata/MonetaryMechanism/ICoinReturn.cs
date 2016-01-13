using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public interface ICoinReturn
    {
        void AddCoin(ICoin coin);
        List<ICoin> Clear();
        List<ICoin> Coins { get; }
        List<ICoinReturnObserver> Observers { get; }
        decimal AmountAvailable { get; }
        void RegisterObserver(ICoinReturnObserver coinReturnObserver);
    }
}