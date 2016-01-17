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

            Assert.AreEqual(5, stock[Products.Cola]);
            Assert.AreEqual(5, stock[Products.Candy]);
            Assert.AreEqual(5, stock[Products.Chips]);
        }
    }
}
