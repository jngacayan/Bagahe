using MvvmCross.Platform.IoC;
using MvvmCross.Core.ViewModels;
using Bagahe.Core.ViewModels.Login;
using Bagahe.Core.ViewModels;
using MvvmCross.Platform;
using Acr.UserDialogs;
using MvvmCross.Core.Navigation;
using Bagahe.Core.ViewModels.Track;

namespace Bagahe.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

            RegisterAppStart(new AppStart());
        }
    }

    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        private readonly IMvxNavigationService _navigationService;

        public AppStart()
        {
            _navigationService = Mvx.Resolve<IMvxNavigationService>(); ;
        }
        public void Start(object hint = null)
        {
            //Change code where you check if the user has previously logged in
            bool isLoggedIn = false;

            if (isLoggedIn)
            {
                _navigationService.Navigate<TrackBaggageViewModel>().Wait();
            }
            else
            {
                _navigationService.Navigate<LoginViewModel>().Wait();
            }
        }
    }
}
