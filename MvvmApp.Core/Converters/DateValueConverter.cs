﻿using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MvvmApp.Core.Converters
{
    public class DateValueConverter : MvxValueConverter<DateTime?, string>
    {
        protected override string Convert(DateTime? value, Type targetType, object parameter, CultureInfo culture) => 
            value.HasValue ? value.Value.ToString("d") : string.Empty;
    }
}
