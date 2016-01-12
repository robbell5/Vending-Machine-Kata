using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.UserControls;

namespace Vending_Machine_Kata_Tests.MonetaryMechanism.UserControls
{
    [TestFixture]
    public class ChangeReturnButtonControllerTest
    {
        [Test]
        public void TestProperties()
        {
            Button expectedChangeReturnButton = new Button();
            ChangeReturnButtonController changeReturnButtonController = new ChangeReturnButtonController(expectedChangeReturnButton);

            Assert.AreEqual(expectedChangeReturnButton, changeReturnButtonController.Button);
        }
    }
}
