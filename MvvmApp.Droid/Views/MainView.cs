using Acr.UserDialogs;
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvvmApp.Droid.Views
{
    [Activity(
       ClearTaskOnLaunch = true,
       Label = "Book Manager")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
            UserDialogs.Init(this);
        }
    }
}
