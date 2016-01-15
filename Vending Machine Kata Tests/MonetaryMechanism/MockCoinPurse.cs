using System.Collections.Generic;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    public class MockCoinPurse : ICoinPurse
    {
        public List<ICoin> CoinsPassedToAddCoin { get; } = new List<ICoin>();
        public decimal AmountAvailableToReturn { get; set; } = 0;
        public int NumberOfTimesAddCoinWasCalled { private set; get; }
        public int NumberOfTimesAmountAvailableWasCalled { private set; get; }
        public List<ICoinPurseObserver> RegisteredCoinPurseObservers { get; } = new List<ICoinPurseObserver>();
        public List<ICoin> Coins { get; } = new List<ICoin>();
        public List<ICoin> CoinsToReturnFromClear { get; set; } = new List<ICoin>();
        public int NumberOfTimesClearWasCalled { get; set; }
        public int NumberOfTimesRegisterObserverWasCalled { get; set; }

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
            NumberOfTimesAddCoinWasCalled++;
            CoinsPassedToAddCoin.Add(coin);
        }

        public decimal AmountAvailable
        {
            get
            {
                NumberOfTimesAmountAvailableWasCalled++;
                return AmountAvailableToReturn;
            }
        }

        public void RegisterObserver(ICoinPurseObserver coinPurseObserver)
        {
            NumberOfTimesRegisterObserverWasCalled++;
            RegisteredCoinPurseObservers.Add(coinPurseObserver);
        }

        public List<ICoin> Clear()
        {
            NumberOfTimesClearWasCalled++;
            return CoinsToReturnFromClear;
        }
    }
}
