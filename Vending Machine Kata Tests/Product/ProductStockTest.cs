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
    }
}
