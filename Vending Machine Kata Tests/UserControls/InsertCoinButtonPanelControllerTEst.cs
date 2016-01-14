using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.MonetaryMechanism.Coin;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata_Tests.UserControls
{
    [TestFixture]
    public class InsertCoinButtonPanelControllerTest
    {
        [Test]
        public void TestProperties()
        {
            MockInsertCoinButtonPanel expectedInsertCoinButtonPanel = new MockInsertCoinButtonPanel();
            MockCoinAccepter expectedCoinAccepter = new MockCoinAccepter();

            InsertCoinButtonPanelController insertCoinButtonPanelController =
                new InsertCoinButtonPanelController(expectedInsertCoinButtonPanel, expectedCoinAccepter);

            Assert.AreSame(expectedInsertCoinButtonPanel, insertCoinButtonPanelController.InsertCoinButtonPanel);
            Assert.AreSame(expectedCoinAccepter, insertCoinButtonPanelController.CoinAccepter);
        }

        [Test]
        public void TestClickingTheInsertPennyButtonPassesASmallCoinToTheCoinAccepter()
        {
            MockInsertCoinButtonPanel mockInsertCoinButtonPanel = new MockInsertCoinButtonPanel();
            MockCoinAccepter mockCoinAccepter = new MockCoinAccepter();

            new InsertCoinButtonPanelController(mockInsertCoinButtonPanel, mockCoinAccepter);

            TestClickingButtonPassesCorrectCoinSizeToCoinAccepter(CoinSize.Tiny,
                mockInsertCoinButtonPanel.InsertDimeButton, mockCoinAccepter);

            TestClickingButtonPassesCorrectCoinSizeToCoinAccepter(CoinSize.Small,
                mockInsertCoinButtonPanel.InsertPennyButton, mockCoinAccepter);

            TestClickingButtonPassesCorrectCoinSizeToCoinAccepter(CoinSize.Medium,
                mockInsertCoinButtonPanel.InsertNickelButton, mockCoinAccepter);

            TestClickingButtonPassesCorrectCoinSizeToCoinAccepter(CoinSize.Large,
                mockInsertCoinButtonPanel.InsertQuarterButton, mockCoinAccepter);

        }

        private void TestClickingButtonPassesCorrectCoinSizeToCoinAccepter(CoinSize expectedCoinSize, Button buttonToClick, MockCoinAccepter mockCoinAccepter)
        {
            buttonToClick.PerformClick();
            Assert.AreEqual(expectedCoinSize, mockCoinAccepter.LastCoinSizePassedToAccept);
        }
    }
}
