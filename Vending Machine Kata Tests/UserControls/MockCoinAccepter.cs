﻿using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.UserControls
{
    public class MockCoinAccepter : ICoinAccepter
    {
        public ICoinFactory CoinFactory { get; }
        public ICoinPurse CoinPurse { get; }
        public ICoinReturn CoinReturn { get; }
        public CoinSize LastCoinSizePassedToAccept { get; private set; }

        public void Accept(CoinSize coinSize)
        {
            LastCoinSizePassedToAccept = coinSize;
        }
    }
}