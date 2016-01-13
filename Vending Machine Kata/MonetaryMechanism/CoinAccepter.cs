using System;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinAccepter : ICoinAccepter
    {
        public ICoinFactory CoinFactory { get; }
        public ICoinPurse CoinPurse { get; }
        public ICoinReturn CoinReturn { get; }

        public CoinAccepter(ICoinFactory coinFactory, ICoinPurse coinPurse, ICoinReturn coinReturn)
        {
            CoinFactory = coinFactory;
            CoinPurse = coinPurse;
            CoinReturn = coinReturn;
        }

        public void Accept(CoinSize coinSize)
        {
            ICoin receivedCoin = CoinFactory.BuildCoin(coinSize);

            const decimal fiveCents = 0.05m;

            if (receivedCoin.Value >= fiveCents)
                CoinPurse.AddCoin(receivedCoin);
            else
                CoinReturn.AddCoin(receivedCoin);
        }
    }
}
