using System;
using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.Display;

namespace Vending_Machine_Kata_Tests.Display
{
    [TestFixture]
    public class DisplayControllerTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(IDisplayController), new DisplayController(new TextBox()));
        }

        [Test]
        public void TestProperties()
        {
            TextBox expectedTextBox = new TextBox();
            DisplayController displayController = new DisplayController(expectedTextBox);

            Assert.AreSame(expectedTextBox, displayController.Display);
        }

        [Test]
        public void TestSetsTextBoxToMultiline()
        {
            TextBox displayTextBox = new TextBox();
            DisplayController displayController = new DisplayController(displayTextBox);

            Assert.True(displayTextBox.Multiline);
        }

        [Test]
        public void TestSetsFirstMessageOnDisplayTextBox()
        {
            TextBox displayTextBox = new TextBox();
            new DisplayController(displayTextBox);

            string expectedText = "INSERT COINS" + Environment.NewLine;

            Assert.AreEqual(expectedText, displayTextBox.Text);
        }

    }
}
