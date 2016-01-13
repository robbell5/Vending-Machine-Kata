using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.UserControls
{
    public class MockCoinAccepter : ICoinAccepter
    {
        public ICoinFactory CoinFactory { get; }
        public ICoinPurse CoinPurse { get; }
        public CoinSize LastCoinSizePassedToAccept { get; private set; }
        public int NumberOfTimeAcceptWasCalled { get; private set; }

        public MockCoinAccepter()
        {
            NumberOfTimeAcceptWasCalled = 0;
        }

        public decimal Accept(CoinSize coinSize)
        {
            NumberOfTimeAcceptWasCalled++;
            LastCoinSizePassedToAccept = coinSize;
            return 0;
        }
    }
}