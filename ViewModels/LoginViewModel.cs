using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaoAvaDemo.ViewModels
{
    public class LoginViewModel : BindableBase,IDialogAware
    {
        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login);
        }

        public string Title => "Login";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            LoginOut();
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }

        public DelegateCommand LoginCommand { get; private set; }

        void Login() 
        {
             RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
        }

        void LoginOut()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.No));
        }
    }
}
