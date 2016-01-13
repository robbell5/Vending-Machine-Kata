using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            mockInsertCoinButtonPanel.InsertPennyButton.PerformClick();

            Assert.AreEqual(1, mockCoinAccepter.NumberOfTimeAcceptWasCalled);
            Assert.AreEqual(CoinSize.SMALL, mockCoinAccepter.LastCoinSizePassedToAccept);
        }

        [Test]
        public void TestClickingTheInsertNickelButtonPassesAMediumCoinToTheCoinAccepter()
        {
            MockInsertCoinButtonPanel mockInsertCoinButtonPanel = new MockInsertCoinButtonPanel();
            MockCoinAccepter mockCoinAccepter = new MockCoinAccepter();

            new InsertCoinButtonPanelController(mockInsertCoinButtonPanel, mockCoinAccepter);

            mockInsertCoinButtonPanel.InsertNickelButton.PerformClick();

            Assert.AreEqual(1, mockCoinAccepter.NumberOfTimeAcceptWasCalled);
            Assert.AreEqual(CoinSize.MEDIUM, mockCoinAccepter.LastCoinSizePassedToAccept);
        }

        [Test]
        public void TestClickingTheInsertDimeButtonPassesAMediumCoinToTheCoinAccepter()
        {
            MockInsertCoinButtonPanel mockInsertCoinButtonPanel = new MockInsertCoinButtonPanel();
            MockCoinAccepter mockCoinAccepter = new MockCoinAccepter();

            new InsertCoinButtonPanelController(mockInsertCoinButtonPanel, mockCoinAccepter);

            mockInsertCoinButtonPanel.InsertDimeButton.PerformClick();

            Assert.AreEqual(1, mockCoinAccepter.NumberOfTimeAcceptWasCalled);
            Assert.AreEqual(CoinSize.TINY, mockCoinAccepter.LastCoinSizePassedToAccept);
        }
    }
}
