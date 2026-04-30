using System;
using System.Globalization;
using System.Windows.Data;

namespace CADE.Aurora.Converters;

public class TruncateStringConverter : IValueConverter
{
    public int MaxLength { get; set; } = 100;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string str && !string.IsNullOrEmpty(str))
        {
            if (str.Length > MaxLength)
            {
                return str.Substring(0, MaxLength) + "...";
            }
            return str;
        }
        return value ?? string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
