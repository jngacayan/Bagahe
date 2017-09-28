using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Bagahe.Core.ViewModels.Login
{
    public class SignupResultViewModel : BaseViewModel
    {
        public ICommand SignInCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<LoginViewModel>();
                });
            }
        }
    }
}
