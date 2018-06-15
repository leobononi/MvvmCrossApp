using System;
using System.Collections.Generic;
using Foundation;
using MvvmApp.Core;
using MvvmApp.Core.Converters;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace MvvmApp.Ios.Views
{
    public partial class BookCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("BookCell");
        public static readonly UINib Nib;

        static BookCell()
        {
            Nib = UINib.FromName("BookCell", NSBundle.MainBundle);
        }

        protected BookCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<BookCell, Book>();
                set.Bind(LabelTitle).To(m => m.Title);
                set.Bind(LabelGenre).To(m => m.Genre);
                set.Bind(LabelPublishDate).To(m => m.PublishDate).WithConversion<DateValueConverter>();
                set.Apply();
            });
        }
    }
}
