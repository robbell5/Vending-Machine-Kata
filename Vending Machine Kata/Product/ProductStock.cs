using System.Collections.Generic;

namespace Vending_Machine_Kata.Product
{
    public class ProductStock
    {
        public Dictionary<IProduct, int> Stock
            => new Dictionary<IProduct, int> {{Products.Candy, 5}, {Products.Chips, 5}, {Products.Cola, 5}};

        public int Count(IProduct product)
        {
            return 5;
        }

        public void Remove(Cola cola)
        {
            throw new System.NotImplementedException();
        }
    }
}