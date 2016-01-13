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
    public class MainFormWrapperTest
    {
        [Test]
        public void TestProperties()
        {
            Form expectedForm = new Form();
            MainFormWrapper mainFormWrapper = new MainFormWrapper(expectedForm);

            Assert.AreSame(expectedForm, mainFormWrapper.MainForm);
        }

        [Test]
        public void TestBuildsInsertCoinButtonPanel()
        {
            Form mainForm = new Form();
            MainFormWrapper mainFormWrapper = new MainFormWrapper(mainForm);

            Assert.IsInstanceOf(typeof(IInsertCoinButtonPanel), mainFormWrapper.InsertCoinButtonPanel);
        }

        [Test]
        public void TestBuildsInsertCoinButtonPanelWithCorrectInsertCoinButtons()
        {
            Form mainForm = new Form();

            Button expectedInsertPennyButton = new Button {Name = "InsertPennyButton"};
            Button expectedInsertNickelButton = new Button {Name = "InsertNickelButton"};
            Button expectedInsertDimeButton = new Button {Name = "InsertDimeButton"};
            Button expectedInsertQuaterButton = new Button {Name = "InsertQuarterButton"};

            mainForm.Controls.Add(expectedInsertPennyButton);
            mainForm.Controls.Add(expectedInsertNickelButton);
            mainForm.Controls.Add(expectedInsertDimeButton);
            mainForm.Controls.Add(expectedInsertQuaterButton);

            MainFormWrapper mainFormWrapper = new MainFormWrapper(mainForm);

            IInsertCoinButtonPanel insertCoinButtonPanel = mainFormWrapper.InsertCoinButtonPanel;

            Assert.AreSame(expectedInsertPennyButton, insertCoinButtonPanel.InsertPennyButton);
            Assert.AreSame(expectedInsertNickelButton, insertCoinButtonPanel.InsertNickelButton);
            Assert.AreSame(expectedInsertDimeButton, insertCoinButtonPanel.InsertDimeButton);
            Assert.AreSame(expectedInsertQuaterButton, insertCoinButtonPanel.InsertQuarterButton);
        }
    }
}
