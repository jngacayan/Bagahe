using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Bagahe.Droid
{
    [Activity(
        Label = "Bagahe"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen) { }

        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(BagaheActivity));
            base.TriggerFirstNavigate();
        }
    }
}
