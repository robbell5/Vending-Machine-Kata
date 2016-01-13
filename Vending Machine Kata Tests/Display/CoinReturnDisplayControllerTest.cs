using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata_Tests.MonetaryMechanism;

namespace Vending_Machine_Kata_Tests.Display
{
    [TestFixture]
    public class CoinReturnDisplayControllerTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(new MockCoinReturn());
            Assert.IsInstanceOf(typeof(IDisplayController), coinReturnDisplayController);
            Assert.IsInstanceOf(typeof(ICoinReturnObserver), coinReturnDisplayController);
        }

        [Test]
        public void TestProperties()
        {
            MockCoinReturn expectedCoinReturn = new MockCoinReturn();

            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(expectedCoinReturn);

            Assert.AreEqual(expectedCoinReturn, coinReturnDisplayController.CoinReturn);
        }

        [Test]
        public void TestRegistersSelfAsObserverWithCoinReturn()
        {
            MockCoinReturn mockCoinReturn = new MockCoinReturn();
            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(mockCoinReturn);

            Assert.AreEqual(1, mockCoinReturn.NumberOfTimesRegisterObserverWasCalled);
            Assert.AreSame(coinReturnDisplayController, mockCoinReturn.ObserversPassedToRegisterObserver[0]);
        }
    }
}
