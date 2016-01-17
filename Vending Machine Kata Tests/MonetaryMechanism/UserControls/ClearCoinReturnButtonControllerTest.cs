using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.UserControls;
using Vending_Machine_Kata_Tests.Dialog;

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
            MockDialogService expectedDialogService = new MockDialogService();

            ClearCoinReturnButtonController clearCoinReturnButtonController = new ClearCoinReturnButtonController(expectedClearCoinReturnButton, expectedCoinReturn, expectedDialogService);

            Assert.AreSame(expectedCoinReturn, clearCoinReturnButtonController.CoinReturn);
            Assert.AreSame(expectedClearCoinReturnButton, clearCoinReturnButtonController.Button);
            Assert.AreSame(expectedDialogService, clearCoinReturnButtonController.DialogService);
        }

        [Test]
        public void TestClickingButtonCallsClearOnCoinReturn()
        {
            Button clearCoinReturnButton = new Button();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();

            ClearCoinReturnButtonController clearCoinReturnButtonController =
                new ClearCoinReturnButtonController(clearCoinReturnButton, mockCoinReturn, new MockDialogService());

            Assert.AreEqual(0, mockCoinReturn.NumberOfTimesClearWasCalled);

            clearCoinReturnButton.PerformClick();

            Assert.AreEqual(1, mockCoinReturn.NumberOfTimesClearWasCalled);
        }
    }
}
