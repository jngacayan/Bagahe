using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Presenters;
using MvvmCross.Platform;
//using Acr.UserDialogs;
//using MvvmCross.Platform.Droid.Platform;

namespace Bagahe.Droid
{
    [Activity(
        Label = "Bagahe",
        Icon = "@drawable/icon",
        Theme = "@style/MainTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class BagaheActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //UserDialogs.Init(this);
            //UserDialogs.Init(() => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity);
            /*
            global::Xamarin.Forms.Forms.Init(this, bundle);

            var formsPresenter = (MvxFormsPagePresenter)Mvx.Resolve<IMvxAndroidViewPresenter>();
            LoadApplication(formsPresenter.FormsApplication);
            */
        }
    }
}
