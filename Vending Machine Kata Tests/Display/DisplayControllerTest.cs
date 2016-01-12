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
            DisplayController displayController = new DisplayController(new TextBox(), null);

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
        public void TestSetsTextBoxToMultiline()
        {
            TextBox displayTextBox = new TextBox();
            DisplayController displayController = new DisplayController(displayTextBox, null);

            Assert.True(displayTextBox.Multiline);
        }

        [Test]
        public void TestSetsFirstMessageOnDisplayTextBox()
        {
            TextBox displayTextBox = new TextBox();
            new DisplayController(displayTextBox, null);

            string expectedText = "INSERT COINS" + Environment.NewLine;

            Assert.AreEqual(expectedText, displayTextBox.Text);
        }

    }
}
