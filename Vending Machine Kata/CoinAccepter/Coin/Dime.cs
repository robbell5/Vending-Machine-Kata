using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Kata.CoinAccepter.Coin
{
    public class Dime : ICoin
    {
        public decimal Value => 0.10m;
    }
}
