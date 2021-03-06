﻿using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public interface ICoinAccepter
    {
        ICoinFactory CoinFactory { get; }
        ICoinPurse CoinPurse { get; }
        ICoinReturn CoinReturn { get; }
        void Accept(CoinSize coinSize);
    }
}
