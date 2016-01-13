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
        public void TestBuildsInsertCoinButtonPanelWithCorrectInsertPennyButton()
        {
            Form mainForm = new Form();
            Button expectedInsertPennyButton = new Button {Name = "InsertPennyButton"};

            mainForm.Controls.Add(expectedInsertPennyButton);

            MainFormWrapper mainFormWrapper = new MainFormWrapper(mainForm);

            IInsertCoinButtonPanel insertCoinButtonPanel = mainFormWrapper.InsertCoinButtonPanel;

            Assert.AreSame(expectedInsertPennyButton, insertCoinButtonPanel.InsertPennyButton);
        }
    }
}
