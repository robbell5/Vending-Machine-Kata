using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.MonetaryMechanism;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism
{
    public class MockCoinPurseObserver : ICoinPurseObserver
    {
        public int NumberOfTimesCoinPurseUpdatedCalled { get; private set; }

        public void CoinPurseUpdated()
        {
            NumberOfTimesCoinPurseUpdatedCalled++;
        }
    }
}
