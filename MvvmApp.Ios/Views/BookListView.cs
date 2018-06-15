using Foundation;
using MvvmApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using System;
using System.Collections.Generic;
using UIKit;

namespace MvvmApp.Ios.Views
{
    public partial class BookListView : MvxViewController
    {
        public BookListView() : base("BookListView", null)
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

            NavigationItem.Title = "Book List";

            var source = new MvxSimpleTableViewSource(BooksTableView, "BookCell", BookCell.Key);
            //var source = new MvxStandardTableViewSource(BooksTableView, UITableViewCellStyle.Default, new NSString("MenuCellIdentifier"), "TitleText Title");

            var set = this.CreateBindingSet<BookListView, BookListViewModel>();
            set.Bind(source).To(vm => vm.BookList);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.ShowCommand);
            set.Apply();

            BooksTableView.RowHeight = 138;

            BooksTableView.Source = source;
            BooksTableView.ReloadData();
        }
    }

    public class TableSource : MvxStandardTableViewSource
    {
        private static readonly NSString Identifier = new NSString("MenuCellIdentifier");
        private const string BindingText = "TitleText Title;SelectedCommand ShowCommand";

        public TableSource(UITableView tableView)
            : base(tableView, UITableViewCellStyle.Default, Identifier, BindingText)
        {
        }
    }
}