using System.Windows.Forms;

namespace Vending_Machine_Kata.Dialog
{
    public class DialogService : IDialogService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
