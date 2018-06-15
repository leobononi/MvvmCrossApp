// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmApp.Ios.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonListBook { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonSave { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextGenre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonListBook != null) {
                ButtonListBook.Dispose ();
                ButtonListBook = null;
            }

            if (ButtonSave != null) {
                ButtonSave.Dispose ();
                ButtonSave = null;
            }

            if (TextAuthor != null) {
                TextAuthor.Dispose ();
                TextAuthor = null;
            }

            if (TextGenre != null) {
                TextGenre.Dispose ();
                TextGenre = null;
            }

            if (TextTitle != null) {
                TextTitle.Dispose ();
                TextTitle = null;
            }
        }
    }
}