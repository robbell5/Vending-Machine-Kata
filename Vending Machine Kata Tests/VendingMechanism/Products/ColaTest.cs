using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.VendingMechanism.Products;

namespace Vending_Machine_Kata_Tests.VendingMechanism.Products
{
    [TestFixture]
    public class ColaTest
    {
        [Test]
        public void TestImplementsInterFace()
        {
            Assert.IsInstanceOf(typeof(IProduct), new Cola());
        }
    }
}
