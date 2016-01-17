using System;
using System.Windows.Forms;
using Vending_Machine_Kata.Dialog;

namespace Vending_Machine_Kata.MonetaryMechanism.UserControls
{
    public class ClearCoinReturnButtonController
    {
        public ICoinReturn CoinReturn { get; }
        public Button Button { get; }
        public IDialogService DialogService { get; set; }

        public ClearCoinReturnButtonController(Button clearCoinReturnButton, ICoinReturn coinReturn, IDialogService dialogService)
        {
            CoinReturn = coinReturn;
            DialogService = dialogService;
            Button = clearCoinReturnButton;
            Button.Click += ButtonEventListener;
        }

        private void ButtonEventListener(object sender, EventArgs eventArgs)
        {
            decimal amountReturnedFromClear = CoinReturn.Clear();

            if(amountReturnedFromClear > 0)
                DialogService.ShowMessage("You receive: " + $"{amountReturnedFromClear:C}");
        }
    }
}