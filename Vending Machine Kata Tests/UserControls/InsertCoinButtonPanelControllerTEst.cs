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
            InsertCoinButtonPanelController insertCoinButtonPanelController = new InsertCoinButtonPanelController(expectedInsertCoinButtonPanel);

            Assert.AreSame(expectedInsertCoinButtonPanel, insertCoinButtonPanelController.InsertCoinButtonPanel);
        }
    }
}
