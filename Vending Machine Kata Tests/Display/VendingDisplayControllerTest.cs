using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata_Tests.MonetaryMechanism;

namespace Vending_Machine_Kata_Tests.Display
{
    [TestFixture]
    public class VendingDisplayControllerTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            VendingDisplayController displayController = new VendingDisplayController(new TextBox(), new MockCoinPurse());

            Assert.IsInstanceOf(typeof (IDisplayController), displayController);
            Assert.IsInstanceOf(typeof (ICoinPurseObserver), displayController);
        }

        [Test]
        public void TestProperties()
        {
            TextBox expectedTextBox = new TextBox();
            MockCoinPurse expectedCoinPurse = new MockCoinPurse();

            VendingDisplayController displayController = new VendingDisplayController(expectedTextBox, expectedCoinPurse);

            Assert.AreSame(expectedTextBox, displayController.Display);
            Assert.AreSame(expectedCoinPurse, displayController.CoinPurse);
        }

        [Test]
        public void TestRegistersItselfAsObserverWithCoinPurse()
        {
            MockCoinPurse mockCoinPurse = new MockCoinPurse();
            VendingDisplayController displayController = new VendingDisplayController(new TextBox(), mockCoinPurse);

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesRegisterObserverWasCalled);
            Assert.AreEqual(displayController, mockCoinPurse.RegisteredCoinPurseObservers[0]);
        }

        [Test]
        public void TestSetsFirstMessageOnDisplayTextBox()
        {
            TextBox displayTextBox = new TextBox();
            new VendingDisplayController(displayTextBox, new MockCoinPurse());

            const string expectedText = "INSERT COINS";

            Assert.AreEqual(expectedText, displayTextBox.Text);
        }

        [TestCase(2.00, "$2.00")]
        [TestCase(0.05, "$0.05")]
        [TestCase(1000.15, "$1,000.15")]
        [TestCase(0.99, "$0.99")]
        public void TestSetsCurrentPurseValueFormatedLikeMoneyWhenCoinPurseNotifiesAmountHasChanged(decimal purseValue,
            string expectedDisplayText)
        {
            TextBox displayTextBox = new TextBox();
            MockCoinPurse mockCoinPurse = new MockCoinPurse {AmountAvailableToReturn = purseValue};

            VendingDisplayController displayController = new VendingDisplayController(displayTextBox, mockCoinPurse);

            displayController.CoinPurseUpdated();

            Assert.AreEqual(expectedDisplayText, displayTextBox.Text);
        }

        [Test]
        public void TestSetsDisplayTestBackToInitialMessageIfCoinPurseIsZero()
        {
            TextBox displayTextBox = new TextBox();
            MockCoinPurse mockCoinPurse = new MockCoinPurse {AmountAvailableToReturn = 0.99m};

            VendingDisplayController displayController = new VendingDisplayController(displayTextBox, mockCoinPurse);

            displayController.CoinPurseUpdated();

            Assert.AreNotEqual("INSERT COINS", displayTextBox.Text);

            mockCoinPurse.AmountAvailableToReturn = 0;
            displayController.CoinPurseUpdated();

            Assert.AreEqual("INSERT COINS", displayTextBox.Text);
        }
    }
}
