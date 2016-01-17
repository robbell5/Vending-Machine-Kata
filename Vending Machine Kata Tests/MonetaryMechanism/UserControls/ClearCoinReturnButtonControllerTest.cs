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

        [TestCase(1, "$1.00")]
        [TestCase(3.44, "$3.44")]
        [TestCase(21.21, "$21.21")]
        [TestCase(1001.99, "$1,001.99")]
        public void TestClickingButtonDisplaysDialogInformingUserOfAmountReturedFromClear(decimal amountReturnedByCoinReturn, string expectedFormatedAmount)
        {
            Button clearCoinReturnButton = new Button();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();
            MockDialogService mockDialogService = new MockDialogService();

            mockCoinReturn.ValueToReturnFromClear = amountReturnedByCoinReturn;
            string expectedDialogText = "You receive: " + expectedFormatedAmount;

            new ClearCoinReturnButtonController(clearCoinReturnButton, mockCoinReturn, mockDialogService);

            Assert.AreEqual(0, mockDialogService.NumberOfTimesShowMessageWasCalled);

            clearCoinReturnButton.PerformClick();

            Assert.AreEqual(1, mockDialogService.NumberOfTimesShowMessageWasCalled);
            Assert.AreEqual(expectedDialogText, mockDialogService.LastMessageShown);
        }

        [Test]
        public void TestClickingButtonDoesNotDisplayDialogIfAmountReturnedIsZero()
        {
            Button clearCoinReturnButton = new Button();
            MockCoinReturn mockCoinReturn = new MockCoinReturn();
            MockDialogService mockDialogService = new MockDialogService();

            mockCoinReturn.ValueToReturnFromClear = 0;

            new ClearCoinReturnButtonController(clearCoinReturnButton, mockCoinReturn, mockDialogService);

            Assert.AreEqual(0, mockDialogService.NumberOfTimesShowMessageWasCalled);

            clearCoinReturnButton.PerformClick();

            Assert.AreEqual(0, mockDialogService.NumberOfTimesShowMessageWasCalled);
        }
    }
}
