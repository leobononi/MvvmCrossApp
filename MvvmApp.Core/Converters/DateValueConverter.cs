using MvvmCross.Platform.Converters;
using System;
using System.Globalization;

namespace MvvmApp.Core.Converters
{
    [Preserve(AllMembers = true)]
    public class DateValueConverter : MvxValueConverter<DateTime?, string>
    {
        protected override string Convert(DateTime? value, Type targetType, object parameter, CultureInfo culture) => 
            value.HasValue ? value.Value.ToString("d") : string.Empty;
    }
}
