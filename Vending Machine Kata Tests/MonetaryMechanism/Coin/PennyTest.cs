using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.Coin
{
    [TestFixture]
    public class PennyTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(ICoin), new Penny());
        }

        [Test]
        public void TestValue()
        {
            const decimal expectedNickleValue = 0.01m;
            Assert.AreEqual(expectedNickleValue, new Penny().Value);
        }
    }
}
