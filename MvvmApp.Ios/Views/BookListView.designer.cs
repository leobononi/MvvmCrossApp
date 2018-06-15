// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MvvmApp.Ios.Views
{
    [Register ("BookListView")]
    partial class BookListView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView BooksTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BooksTableView != null) {
                BooksTableView.Dispose ();
                BooksTableView = null;
            }
        }
    }
}