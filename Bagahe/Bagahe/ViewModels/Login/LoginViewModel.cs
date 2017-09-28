using Acr.UserDialogs;
using Bagahe.Core.Services;
using Bagahe.Core.ViewModels.Track;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bagahe.Core.ViewModels.Login
{
    public class LoginViewModel : BaseViewModel
    {
       private readonly ILoginService _service;
       //private readonly IUserDialogs _udialog;
       private readonly IMvxNavigationService _navigationService;
       private string _userName;
       private string _password;
       private string _loginErrorMsg;
       private string _usernameErrorMsg;
       private string _passwordErrorMsg;

       //public LoginViewModel(ILoginService service, IUserDialogs dialog, IMvxNavigationService navigationService)
       public LoginViewModel(ILoginService service, IMvxNavigationService navigationService)
       {
           _service = service;
           //_udialog = dialog;
           _navigationService = navigationService;

           InitCommands();
       }

       public override Task Initialize()
       {
           //TODO: Add starting logic here

           return base.Initialize();
       }

       public ICommand ShowMenuPageCommand { private set; get; }

       public ICommand ShowSignUpCommand { private set; get; }

       private void InitCommands()
       {
           ShowSignUpCommand = new MvxCommand(async () =>
           {
               await _navigationService.Navigate<SignupViewModel>();
           });

           ShowMenuPageCommand = new MvxCommand(async () =>
           {
               if (validateUserInput())
               {
                   bool isValidUser = false;
                   //using (_udialog.Loading("Loggin in..."))
                   {
                       isValidUser = await _service.ValidateLogin(Username, Password);
                   }
                   if (isValidUser)
                   {
                       //LoginErrorMsg = "SUCCESS!";
                       //Check for a way to navigate and not have the back button/reset nav stack
                       await _navigationService.Navigate<TrackBaggageViewModel>();
                   }
                   else
                   {
                       LoginErrorMsg = "Incorrect Username or Password";
                   }
               }
           });
       }

       private bool validateUserInput()
       {
           bool isUsernameValid = false;
           bool isPasswordValid = false;

           LoginErrorMsg = "";
           UsernameErrorMsg = "Username is required.";
           PasswordErrorMsg = "Password is required.";

           if (!string.IsNullOrWhiteSpace(Username))
           {
               isUsernameValid = true;
               UsernameErrorMsg = "";
           }

           if (!string.IsNullOrWhiteSpace(Password))
           {
               isPasswordValid = true;
               PasswordErrorMsg = "";
           }

           return isPasswordValid && isUsernameValid;
       }

       public string Username
       {
           get { return _userName; }
           set { SetProperty(ref _userName, value); }
       }

       public string Password
       {
           get { return _password; }
           set { SetProperty(ref _password, value); }
       }

       public string LoginErrorMsg
       {
           get { return _loginErrorMsg; }
           set { SetProperty(ref _loginErrorMsg, value); }
       }

       public string UsernameErrorMsg
       {
           get { return _usernameErrorMsg; }
           set { SetProperty(ref _usernameErrorMsg, value); }
       }

       public string PasswordErrorMsg
       {
           get { return _passwordErrorMsg; }
           set { SetProperty(ref _passwordErrorMsg, value); }
       }
      
    }
}
