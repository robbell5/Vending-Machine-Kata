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

        public decimal Accept(CoinPhysicalProperties.SizeAndWeight coinSizeAndWeight)
        {
            ICoin receivedCoin = CoinFactory.BuildCoin(coinSizeAndWeight);

            if (receivedCoin.Value > 0)
                CoinPurse.AddCoin(receivedCoin);
            else
                CoinReturn.AddCoin(receivedCoin);

            return CoinPurse.AmountAvailable();
        }
    }
}
