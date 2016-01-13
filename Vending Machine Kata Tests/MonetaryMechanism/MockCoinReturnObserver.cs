using Vending_Machine_Kata.MonetaryMechanism;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    public class MockCoinReturnObserver : ICoinReturnObserver
    {
        public int NumberOfTimesCoinPurseUpdatedCalled { private set; get; }

        public void CoinPurseUpdated()
        {
            NumberOfTimesCoinPurseUpdatedCalled++;
        }
    }
}