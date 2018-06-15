using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MvvmApp.Core.Converters
{
    public class AuthorConverter : MvxValueConverter<List<string>, string>
    {
        protected override string Convert(List<string> value, Type targetType, object parameter, CultureInfo culture) =>
            value?.FirstOrDefault();
    }
}
