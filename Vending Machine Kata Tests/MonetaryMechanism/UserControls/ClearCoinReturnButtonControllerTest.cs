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
    public class ClearCoinReturnButtonControllerTest
    {
        [Test]
        public void TestProperties()
        {
            Button expectedClearCoinReturnButton = new Button();
            MockCoinReturn expectedCoinReturn = new MockCoinReturn();

            ClearCoinReturnButtonController clearCoinReturnButtonController = new ClearCoinReturnButtonController(expectedClearCoinReturnButton, expectedCoinReturn);

            Assert.AreSame(expectedCoinReturn, clearCoinReturnButtonController.CoinReturn);
            Assert.AreSame(expectedClearCoinReturnButton, clearCoinReturnButtonController.Button);
        }

        [Test]
        public void TestClickingButtonCallsClearOnCoinReturn()
        {
            Button clearCoinReturnButton = new Button();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();

            ClearCoinReturnButtonController clearCoinReturnButtonController =
                new ClearCoinReturnButtonController(clearCoinReturnButton, mockCoinReturn);

            Assert.AreEqual(0, mockCoinReturn.NumberOfTimesClearWasCalled);

            clearCoinReturnButton.PerformClick();

            Assert.AreEqual(1, mockCoinReturn.NumberOfTimesClearWasCalled);
        }
    }
}
