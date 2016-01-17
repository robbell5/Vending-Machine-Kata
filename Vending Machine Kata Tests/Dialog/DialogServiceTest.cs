using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending_Machine_Kata.Dialog;

namespace Vending_Machine_Kata_Tests.Dialog
{
    [TestFixture]
    public class DialogServiceTest
    {
        [Test]
        public void TestImplementsInterface()
        {
            Assert.IsInstanceOf(typeof(IDialogService), new DialogService());
        }
    }
}
