using System;
using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    class MockCoinReturn : ICoinReturn
    {
        public int NumberOfTimesAddCoinCalled { get; set; }
        public List<ICoin> CoinsPassedToAddCoin { get; set; }
        public List<ICoin> Coins { get; }
        public List<ICoinReturnObserver> Observers { get; }
        public decimal AmountAvailable => ValueToReturnFromAmountAvailable;
        public List<ICoinReturnObserver> ObserversPassedToRegisterObserver { get; }
        public int NumberOfTimesRegisterObserverWasCalled { get; private set; }
        public decimal ValueToReturnFromAmountAvailable { get; set; }

        public void RegisterObserver(ICoinReturnObserver coinReturnObserver)
        {
            ObserversPassedToRegisterObserver.Add(coinReturnObserver);
            NumberOfTimesRegisterObserverWasCalled++;
        }

        public MockCoinReturn()
        {
            ValueToReturnFromAmountAvailable = 0;
            NumberOfTimesRegisterObserverWasCalled = 0;
            NumberOfTimesAddCoinCalled = 0;
            CoinsPassedToAddCoin = new List<ICoin>();
            ObserversPassedToRegisterObserver = new List<ICoinReturnObserver>();
        }

        public void AddCoin(ICoin coin)
        {
            NumberOfTimesAddCoinCalled++;
            CoinsPassedToAddCoin.Add(coin);
        }

        public List<ICoin> Clear()
        {
            return null;
        }
    }
}
