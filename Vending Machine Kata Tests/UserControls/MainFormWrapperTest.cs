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
    }
}
