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
    [Register ("BookCell")]
    partial class BookCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelAuthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelGenre { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPublishDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelAuthor != null) {
                LabelAuthor.Dispose ();
                LabelAuthor = null;
            }

            if (LabelGenre != null) {
                LabelGenre.Dispose ();
                LabelGenre = null;
            }

            if (LabelPublishDate != null) {
                LabelPublishDate.Dispose ();
                LabelPublishDate = null;
            }

            if (LabelTitle != null) {
                LabelTitle.Dispose ();
                LabelTitle = null;
            }
        }
    }
}