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
            MockCoinPurse expectedCoinPurse = new MockCoinPurse();
            MockCoinReturn expectedCoinReturn = new MockCoinReturn();

            ChangeReturnButtonController changeReturnButtonController =
                new ChangeReturnButtonController(expectedChangeReturnButton, expectedCoinPurse, expectedCoinReturn);

            Assert.AreEqual(expectedChangeReturnButton, changeReturnButtonController.Button);
            Assert.AreEqual(expectedCoinPurse, changeReturnButtonController.CoinPurse);
            Assert.AreEqual(expectedCoinReturn, changeReturnButtonController.CoinReturn);
        }

        [Test]
        public void TestClickingTheButtonCallsClearOnCoinPurse()
        {
            Button changeReturnButton = new Button();
            MockCoinPurse mockCoinPurse = new MockCoinPurse();

            new ChangeReturnButtonController(changeReturnButton,
                mockCoinPurse, new MockCoinReturn());

            changeReturnButton.PerformClick();

            Assert.AreEqual(1, mockCoinPurse.NumberOfTimesClearWasCalled);
        }
    }
}
