using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(new TextBox(), new MockCoinReturn());
            Assert.IsInstanceOf(typeof(IDisplayController), coinReturnDisplayController);
            Assert.IsInstanceOf(typeof(ICoinReturnObserver), coinReturnDisplayController);
        }

        [Test]
        public void TestProperties()
        {
            MockCoinReturn expectedCoinReturn = new MockCoinReturn();
            TextBox expectedTextBox = new TextBox();

            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(expectedTextBox, expectedCoinReturn);

            Assert.AreEqual(expectedCoinReturn, coinReturnDisplayController.CoinReturn);
            Assert.AreEqual(expectedTextBox, coinReturnDisplayController.Display);
        }

        [Test]
        public void TestRegistersSelfAsObserverWithCoinReturn()
        {
            MockCoinReturn mockCoinReturn = new MockCoinReturn();
            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(new TextBox(), mockCoinReturn);

            Assert.AreEqual(1, mockCoinReturn.NumberOfTimesRegisterObserverWasCalled);
            Assert.AreSame(coinReturnDisplayController, mockCoinReturn.ObserversPassedToRegisterObserver[0]);
        }
    }
}
