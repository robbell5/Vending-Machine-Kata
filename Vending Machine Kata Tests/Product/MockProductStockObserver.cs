using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.Product;

namespace Vending_Machine_Kata_Tests.Product
{
    public class MockProductStockObserver : IProductStockObserver
    {
        public IProduct LastProductPassedToProductStockUpdated { get; private set; }
        public int NumberOfTimesProductStockUpdatedWasCalled { get; private set; }

        public void ProductStockUpdated(IProduct product)
        {
            NumberOfTimesProductStockUpdatedWasCalled++;
            LastProductPassedToProductStockUpdated = product;
        }
    }
}
