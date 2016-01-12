using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using Vending_Machine_Kata.UserControls;

namespace Vending_Machine_Kata_Tests.UserControls
{
    [TestFixture]
    public class InsertCoinButtonPanelTest
    {
        [Test]
        public void TestProperties()
        {
            Button expectedInsertPennyButton = new Button();
            Button expectedInsertNickelButton = new Button();
            Button expectedInsertDimeButton = new Button();
            Button expectedInsertQuarterButton = new Button();

            InsertCoinButtonPanel insertCoinButtonPanel = new InsertCoinButtonPanel(expectedInsertPennyButton,
                expectedInsertNickelButton, expectedInsertDimeButton, expectedInsertQuarterButton);

            Assert.AreSame(expectedInsertPennyButton, insertCoinButtonPanel.InsertPennyButton);
            Assert.AreSame(expectedInsertNickelButton, insertCoinButtonPanel.InsertNickelButton);
            Assert.AreSame(expectedInsertDimeButton, insertCoinButtonPanel.InsertDimeButton);
            Assert.AreSame(expectedInsertQuarterButton, insertCoinButtonPanel.InsertQuarterButton);
        }
    }
}
