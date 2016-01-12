using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Kata.CoinAccepter.Coin
{
    public interface ICoinFactory
    {
        ICoin BuildCoin(CoinPhysicalProperties.SizeAndWeight sizeAndWeight);
    }
}
