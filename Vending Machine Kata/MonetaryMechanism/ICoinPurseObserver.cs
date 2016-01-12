using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Kata.MonetaryMechanism
{
    public interface ICoinPurseObserver
    {
        void CoinPurseUpdated();
    }
}
