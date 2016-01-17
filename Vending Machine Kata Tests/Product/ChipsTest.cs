using NUnit.Framework;
using Vending_Machine_Kata.Product;

namespace Vending_Machine_Kata_Tests.Product
{
    [TestFixture]
    public class ChipsTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof (IProduct), new Chips());
        }

        [Test]
        public void TestDisplayName()
        {
            Assert.AreEqual("Chips", new Chips().DisplayName);
        }

        [Test]
        public void TestValue()
        {
            Assert.AreEqual(0.5, new Chips().Value);
        }
    }
}
