using MvvmApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using System;

using UIKit;

namespace MvvmApp.Ios.Views
{
    public partial class BookDetailsView : MvxViewController
    {
        public BookDetailsView() : base("BookDetailsView", null)
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

            var set = this.CreateBindingSet<BookDetailsView, BookDetailsViewModel>();
            set.Bind(LabelTitle).To(vm => vm.Book.Title);
            set.Bind(LabelGenre).To(vm => vm.Book.Genre);
            set.Bind(LabelAuthor).To(vm => vm.Author);
            set.Bind(LabelPublishDate).To(vm => vm.Book.PublishDate).WithConversion("Date");
            set.Apply();
        }
    }
}