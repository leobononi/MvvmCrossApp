using Acr.UserDialogs;
using Android.App;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
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
            AppCenter.Start("ca454f95-7ba8-4780-ada6-9b44c7f26b33", typeof(Analytics), typeof(Crashes));
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
            UserDialogs.Init(this);
        }
    }
}
