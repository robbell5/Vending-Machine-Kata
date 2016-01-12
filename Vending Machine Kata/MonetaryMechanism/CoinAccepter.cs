using System;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinAccepter : ICoinAccepter
    {
        public ICoinFactory CoinFactory { get; }
        public ICoinPurse CoinPurse { get; }

        public CoinAccepter(ICoinFactory coinFactory, ICoinPurse coinPurse)
        {
            CoinFactory = coinFactory;
            CoinPurse = coinPurse;
        }

        public decimal Accept(CoinPhysicalProperties.SizeAndWeight coinSizeAndWeight)
        {
            ICoin receivedCoin = CoinFactory.BuildCoin(coinSizeAndWeight);
            CoinPurse.AddCoin(receivedCoin);
            return CoinPurse.AmountAvailable();
        }
    }
}
