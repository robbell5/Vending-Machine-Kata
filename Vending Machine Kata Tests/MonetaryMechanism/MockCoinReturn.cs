using System;
using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    public class MockCoinReturn : ICoinReturn
    {
        public int NumberOfTimesAddCoinCalled { get; set; }
        public List<ICoin> CoinsPassedToAddCoin { get; set; } = new List<ICoin>();
        public List<ICoin> Coins { get; } = new List<ICoin>();
        public List<ICoinReturnObserver> Observers { get; } = new List<ICoinReturnObserver>();
        public decimal AmountAvailable => ValueToReturnFromAmountAvailable;
        public List<ICoinReturnObserver> ObserversPassedToRegisterObserver { get; } = new List<ICoinReturnObserver>();
        public int NumberOfTimesRegisterObserverWasCalled { get; private set; }
        public decimal ValueToReturnFromAmountAvailable { get; set; } = 0;
        public decimal ValueToReturnFromAClear { get; set; } = 0;
        public int NumberOfTimesClearWasCalled { get; set; }

        public void RegisterObserver(ICoinReturnObserver coinReturnObserver)
        {
            ObserversPassedToRegisterObserver.Add(coinReturnObserver);
            NumberOfTimesRegisterObserverWasCalled++;
        }

        public void AddCoin(ICoin coin)
        {
            NumberOfTimesAddCoinCalled++;
            CoinsPassedToAddCoin.Add(coin);
        }

        public decimal Clear()
        {
            NumberOfTimesClearWasCalled++;
            return ValueToReturnFromAClear;
        }
    }
}
