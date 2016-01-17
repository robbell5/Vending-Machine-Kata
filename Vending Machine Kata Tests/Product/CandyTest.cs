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

        [Test]
        public void TestDisplayName()
        {
            Assert.AreEqual("Candy", new Candy().DisplayName);
        }

        [Test]
        public void TestValue()
        {
            Assert.AreEqual(0.65, new Candy().Value);
        }
    }
}
