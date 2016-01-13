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

        public MockCoinReturn()
        {
            NumberOfTimesAddCoinCalled = 0;
            CoinsPassedToAddCoin = new List<ICoin>();
        }

        public void AddCoin(ICoin coin)
        {
            NumberOfTimesAddCoinCalled++;
            CoinsPassedToAddCoin.Add(coin);
        }

        public List<ICoin> Clear()
        {
            throw new NotImplementedException();
        }
    }
}
