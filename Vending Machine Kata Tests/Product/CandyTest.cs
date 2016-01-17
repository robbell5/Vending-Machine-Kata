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
    public class CandyTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof (IProduct), new Candy());
        }
    }
}
