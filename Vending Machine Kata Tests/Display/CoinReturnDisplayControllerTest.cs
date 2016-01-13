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

        [TestCase(12.11, "$12.11")]
        [TestCase(0.34, "$0.34")]
        [TestCase(1234.34, "$1,234.34")]
        public void TestInitializesTextOnDisplayToValueOfCoinReturn(decimal valueToReturnFromCoinReturn, string expectedText)
        {
            MockCoinReturn mockCoinReturn = new MockCoinReturn();
            TextBox displayTextBox = new TextBox();

            mockCoinReturn.ValueToReturnFromAmountAvailable = valueToReturnFromCoinReturn;

            new CoinReturnDisplayController(displayTextBox, mockCoinReturn);

            Assert.AreEqual(expectedText, displayTextBox.Text);
        }

        [TestCase(34.76, "$34.76")]
        [TestCase(0.14, "$0.14")]
        [TestCase(9212.22, "$9,212.22")]
        public void TestUpdatesDisplayTextWithCoinReturnValueWhenCoinReturnUpdatedIsCalled(decimal valueToReturnFromCoinReturn, string expectedUpdatedText)
        {
            MockCoinReturn mockCoinReturn = new MockCoinReturn();
            TextBox displayTextBox = new TextBox();

            CoinReturnDisplayController coinReturnDisplayController = new CoinReturnDisplayController(displayTextBox, mockCoinReturn);

            const string expectedStartingAmountBecauseTheMockReturnsAnAmoutOfZeroByDefualt = "$0.00";
            Assert.AreEqual(expectedStartingAmountBecauseTheMockReturnsAnAmoutOfZeroByDefualt, displayTextBox.Text);

            mockCoinReturn.ValueToReturnFromAmountAvailable = valueToReturnFromCoinReturn;

            coinReturnDisplayController.CoinReturnUpdated();

            Assert.AreEqual(expectedUpdatedText, displayTextBox.Text);
        }
    }
}
