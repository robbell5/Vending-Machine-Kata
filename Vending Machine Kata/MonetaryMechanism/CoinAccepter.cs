using System.ComponentModel.Design.Serialization;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public class CoinAccepter : ICoinAccepter
    {
        private const decimal FiveCents = 0.05m;
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

            if (receivedCoin.Value >= FiveCents)
                CoinPurse.AddCoin(receivedCoin);
            else
                CoinReturn.AddCoin(receivedCoin);
        }
    }
}
