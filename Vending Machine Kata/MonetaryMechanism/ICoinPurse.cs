using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public interface ICoinPurse
    {
        void AddCoin(ICoin coin);
        decimal AmountAvailable();
    }
}
