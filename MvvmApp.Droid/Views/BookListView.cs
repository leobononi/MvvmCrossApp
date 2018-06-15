
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvvmApp.Droid.Views
{
    [Activity(
       Label = "Book List")]
    public class BookListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.BookListView);
        }
    }
}