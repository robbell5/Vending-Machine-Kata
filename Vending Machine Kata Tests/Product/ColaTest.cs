using NUnit.Framework;
using Vending_Machine_Kata.Product;

namespace Vending_Machine_Kata_Tests.Product
{
    [TestFixture]
    public class ColaTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(IProduct), new Cola());
        }

        [Test]
        public void TestDisplayName()
        {
            Assert.AreEqual("Cola", new Cola().DisplayName);
        }
    }
}
