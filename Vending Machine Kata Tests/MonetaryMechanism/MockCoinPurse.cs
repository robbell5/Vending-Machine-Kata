using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    public class MockCoinPurse : ICoinPurse
    {
        public List<ICoin> CoinsPassedToAddCoin { get; }
        public decimal AmountAvailableToReturn { get; set; }
        public int NumberOfTimesAddCoinWasCalled { private set; get; }
        public int NumberOfTimesAmountAvailableWasCalled { private set; get; }
        public List<ICoinPurseObserver> RegisteredCoinPurseObservers { private set; get; }
        public int NumberOfTimesRegisterObserverWasCalled { get; set; }

        public MockCoinPurse()
        {
            Coins = new List<ICoin>();
            CoinsPassedToAddCoin = new List<ICoin>();
            RegisteredCoinPurseObservers = new List<ICoinPurseObserver>();
            AmountAvailableToReturn = 0;
            NumberOfTimesAddCoinWasCalled = 0;
            NumberOfTimesAmountAvailableWasCalled = 0;
            NumberOfTimesRegisterObserverWasCalled = 0;
        }

        public void AddCoin(ICoin coin)
        {
            Coins.Add(coin);
            NumberOfTimesAddCoinWasCalled++;
            CoinsPassedToAddCoin.Add(coin);
        }

        public decimal AmountAvailable()
        {
            NumberOfTimesAmountAvailableWasCalled++;
            return AmountAvailableToReturn;
        }

        public List<ICoin> Coins { get; }

        public void RegisterObserver(ICoinPurseObserver coinPurseObserver)
        {
            NumberOfTimesRegisterObserverWasCalled++;
            RegisteredCoinPurseObservers.Add(coinPurseObserver);
        }

        public List<ICoin> Clear()
        {
            return null;
        }
    }
}
