using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine_Kata.Dialog;

namespace Vending_Machine_Kata_Tests.Dialog
{
    public class MockDialogService : IDialogService
    {
        public string LastMessageShown { get; private set; } = "";
        public int NumberOfTimesShowMessageWasCalled { get; private set; } = 0;

        public void ShowMessage(string message)
        {
            NumberOfTimesShowMessageWasCalled++;
            LastMessageShown = message;
        }
    }
}
