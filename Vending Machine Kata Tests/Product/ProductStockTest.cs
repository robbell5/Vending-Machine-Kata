using System.Collections.Generic;
using NUnit.Framework;
using Vending_Machine_Kata.Product;

namespace Vending_Machine_Kata_Tests.Product
{
    [TestFixture]
    public class ProductStockTest
    {
        [Test]
        public void TestProductStockStartsWithFiveOfEachItem()
        {
            ProductStock productStock = new ProductStock();

            Assert.AreEqual(5, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Chips));
            Assert.AreEqual(5, productStock.Count(Products.Candy));
        }

        [TestCase]
        public void TestCreatesADictionaryOfIProductsAndIntsForCandyColaAndChips()
        {
            ProductStock productStock = new ProductStock();

            Dictionary<IProduct, int> stock = productStock.Stock;

            Assert.AreEqual(3, stock.Count);

            Assert.AreEqual(5, stock[Products.Cola]);
            Assert.AreEqual(5, stock[Products.Candy]);
            Assert.AreEqual(5, stock[Products.Chips]);
        }

        [Test]
        public void TestRemovingAColaDecrementsCountForColaOnly()
        {
            ProductStock productStock = new ProductStock();

            productStock.Remove(Products.Cola);

            Assert.AreEqual(4, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Chips));
            Assert.AreEqual(5, productStock.Count(Products.Candy));

            productStock.Remove(Products.Cola);

            Assert.AreEqual(3, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Chips));
            Assert.AreEqual(5, productStock.Count(Products.Candy));
        }

        [Test]
        public void TestRemovingAChipsDecrementsCountForChipsOnly()
        {
            ProductStock productStock = new ProductStock();

            productStock.Remove(Products.Chips);

            Assert.AreEqual(4, productStock.Count(Products.Chips));
            Assert.AreEqual(5, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Candy));

            productStock.Remove(Products.Chips);

            Assert.AreEqual(3, productStock.Count(Products.Chips));
            Assert.AreEqual(5, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Candy));
        }

        [Test]
        public void TestRemovingACandyDecrementsCountForCandyOnly()
        {
            ProductStock productStock = new ProductStock();

            productStock.Remove(Products.Candy);

            Assert.AreEqual(4, productStock.Count(Products.Candy));
            Assert.AreEqual(5, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Chips));

            productStock.Remove(Products.Candy);

            Assert.AreEqual(3, productStock.Count(Products.Candy));
            Assert.AreEqual(5, productStock.Count(Products.Cola));
            Assert.AreEqual(5, productStock.Count(Products.Chips));
        }

        [Test]
        public void TestCountCantGoBelowZero()
        {
            ProductStock productStock = new ProductStock();

            int originalCountAndMore = productStock.Count(Products.Cola) + 3;
            for (int i = 0; i < originalCountAndMore; i++)
            {
                productStock.Remove(Products.Cola);
                Assert.GreaterOrEqual(productStock.Count(Products.Cola), 0);
            }
        }

        [Test]
        public void TestHandlesUnknownProductsGracefully()
        {
            MockProduct mockProduct = new MockProduct();

            ProductStock productStock = new ProductStock();
            
            productStock.Remove(mockProduct);
            Assert.AreEqual(0, productStock.Count(mockProduct));
        }

        [Test]
        public void TestRegisterObserverAddsObserverToList()
        {
            ProductStock productStock = new ProductStock();
            List<IProductStockObserver> productStockObservers = productStock.Observers;

            Assert.AreEqual(0, productStockObservers.Count);

            productStock.RegisterObserver(new MockProductStockObserver());

            Assert.AreEqual(1, productStockObservers.Count);
        }
    }
}
