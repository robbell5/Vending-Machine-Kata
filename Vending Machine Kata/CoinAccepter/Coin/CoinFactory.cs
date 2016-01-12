using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine_Kata.CoinAccepter.Coin
{
    public class CoinFactory : ICoinFactory
    {
        public ICoin BuildCoin(CoinPhysicalProperties.SizeAndWeight sizeAndWeight)
        {
            switch (sizeAndWeight)
            {
                case CoinPhysicalProperties.SizeAndWeight.SMALL:
                    return new Dime();
                case CoinPhysicalProperties.SizeAndWeight.MEDIUM:
                    return new Nickel();
                case CoinPhysicalProperties.SizeAndWeight.LARGE:
                    return  new Quarter();
            } 

            return new NullCoin();
        }
    }
}
