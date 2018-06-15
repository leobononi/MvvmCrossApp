using MvvmApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;

namespace MvvmApp.Ios.Views
{
    public partial class BookInfoDetailsView : MvxViewController
    {
        public BookInfoDetailsView() : base("BookInfoDetailsView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<BookInfoDetailsView, BookInfoDetailsView>();
            set.Apply();
        }
    }
}