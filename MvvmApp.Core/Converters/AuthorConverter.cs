using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MvvmApp.Core.Converters
{
    [Preserve(AllMembers = true)]
    public class AuthorConverter : MvxValueConverter<List<string>, string>
    {
        protected override string Convert(List<string> value, Type targetType, object parameter, CultureInfo culture) =>
            value?.FirstOrDefault();
    }
}
