using System.Collections.Generic;

namespace Vending_Machine_Kata.Product
{
    public class ProductStock
    {
        public Dictionary<IProduct, int> Stock
            = new Dictionary<IProduct, int> {{Products.Candy, 5}, {Products.Chips, 5}, {Products.Cola, 5}};

        public List<IProductStockObserver> Observers = new List<IProductStockObserver>();

        public int Count(IProduct product)
        {
            if(Stock.ContainsKey(product))
                return Stock[product];
            return 0;
        }

        public void Remove(IProduct product)
        {
            if (Stock.ContainsKey(product))
                if (Stock[product] > 0)
                {
                    Stock[product] = Stock[product] - 1;
                    Observers.ForEach(observer => observer.ProductStockUpdated(product));
                }
        }

        public void RegisterObserver(IProductStockObserver productStockObserver)
        {
                Observers.Add(productStockObserver);
        }
    }
}