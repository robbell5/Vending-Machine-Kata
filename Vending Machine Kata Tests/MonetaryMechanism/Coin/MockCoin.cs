using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    public class MockCoin : ICoin
    {
        public decimal Value => ValueToReturn;
        public decimal ValueToReturn { get; set; }

        public MockCoin()
        {
            ValueToReturn = 0;
        }
    }
}
