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
            Assert.IsInstanceOf(typeof(IDisplayController), new DisplayController(null));
        }

        [Test]
        public void TestProperties()
        {
            TextBox expectedTextBox = new TextBox();
            DisplayController displayController = new DisplayController(expectedTextBox);

            Assert.AreSame(expectedTextBox, displayController.Display);
        }
    }
}
