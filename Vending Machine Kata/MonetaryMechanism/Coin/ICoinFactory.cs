﻿namespace Vending_Machine_Kata.MonetaryMechanism.Coin
{
    public interface ICoinFactory
    {
        ICoin BuildCoin(CoinSize coinSize);
    }
}
