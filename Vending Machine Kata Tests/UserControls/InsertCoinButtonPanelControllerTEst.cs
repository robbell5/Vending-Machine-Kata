using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
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
    }
}
