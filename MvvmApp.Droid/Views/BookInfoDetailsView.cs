
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvvmApp.Droid.Views
{
    [Activity(
       Label = "Book Info Details")]
    public class BookInfoDetailsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.BookInfoDetailsView);
        }
    }
}