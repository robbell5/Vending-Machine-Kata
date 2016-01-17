using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.Product;

namespace Vending_Machine_Kata_Tests.Product
{
    [TestFixture]
    public class ProductsTest
    {
        [Test]
        public void TestProductsTypes()
        {
            Assert.IsInstanceOf(typeof(Cola), Products.Cola);
            Assert.IsInstanceOf(typeof(Chips), Products.Chips);
            Assert.IsInstanceOf(typeof(Candy), Products.Candy);
        }

        [Test]
        public void TestColaIsTreatedAsSingleton()
        {
            Assert.AreSame(Products.Cola, Products.Cola);
        }
    }
}
