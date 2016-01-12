using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    public class MockCoinFactory : ICoinFactory
    {
        public int NumberOfTimesBuildCoinCalled { get; private set; }
        public CoinPhysicalProperties.SizeAndWeight LastSizeAndWeightPassed { get; private set; }
        public MockCoin CoinToReturn { get; set; }

        public MockCoinFactory()
        {
            NumberOfTimesBuildCoinCalled = 0;
            CoinToReturn = new MockCoin();
        }

        public ICoin BuildCoin(CoinPhysicalProperties.SizeAndWeight sizeAndWeight)
        {
            LastSizeAndWeightPassed = sizeAndWeight;
            NumberOfTimesBuildCoinCalled++;
            return CoinToReturn;
        }
    }
}
