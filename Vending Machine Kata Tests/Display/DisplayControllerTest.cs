using System;
using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.Display;
using Vending_Machine_Kata.MonetaryMechanism;
using Vending_Machine_Kata_Tests.MonetaryMechanism;

namespace Vending_Machine_Kata_Tests.Display
{
    [TestFixture]
    public class DisplayControllerTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            DisplayController displayController = new DisplayController(new TextBox(), new MockCoinPurse());

            Assert.IsInstanceOf(typeof(IDisplayController), displayController);
            Assert.IsInstanceOf(typeof(ICoinPurseObserver), displayController);
        }

        [Test]
        public void TestProperties()
        {
            TextBox expectedTextBox = new TextBox();
            MockCoinPurse expectedCoinPurse = new MockCoinPurse();

            DisplayController displayController = new DisplayController(expectedTextBox, expectedCoinPurse);

            Assert.AreSame(expectedTextBox, displayController.Display);
            Assert.AreSame(expectedCoinPurse, displayController.CoinPurse);
        }

        [Test]
        public void TestRegistersItselfAsObserverWithCoinPurse()
        {
            MockCoinPurse mockCoinPurse = new MockCoinPurse();
            DisplayController displayController = new DisplayController(new TextBox(), mockCoinPurse);

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesRegisterObserverWasCalled);
            Assert.AreEqual(displayController, mockCoinPurse.RegisteredCoinPurseObservers[0]);
        }

        [Test]
        public void TestSetsTextBoxToMultiline()
        {
            TextBox displayTextBox = new TextBox();
            DisplayController displayController = new DisplayController(displayTextBox, new MockCoinPurse());

            Assert.True(displayTextBox.Multiline);
        }

        [Test]
        public void TestSetsFirstMessageOnDisplayTextBox()
        {
            TextBox displayTextBox = new TextBox();
            new DisplayController(displayTextBox, new MockCoinPurse());

            string expectedText = "INSERT COINS" + Environment.NewLine;

            Assert.AreEqual(expectedText, displayTextBox.Text);
        }

    }
}
