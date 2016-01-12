using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    [TestFixture]
    public class DimeTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoin), new Dime());
        }

        [Test]
        public void TestValue()
        {
            const decimal expectedDimeValue = 0.10m;
            Assert.AreEqual(expectedDimeValue, new Dime().Value);
        }
    }
}
