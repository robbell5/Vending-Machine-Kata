using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    [TestFixture]
    public class QuarterTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoin), new Quarter());
        }

        [Test]
        public void TestValue()
        {
            const decimal expectedQuarterValue = 0.25m;
            Assert.AreEqual(expectedQuarterValue, new Quarter().Value);
        }
    }
}
