using System;
using System.Globalization;
using System.Windows.Data;

namespace CADE.Aurora.Converters;

public class TimeStampConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is DateTimeOffset dateTimeOffset)
        {
            if (dateTimeOffset == DateTimeOffset.MinValue)
            {
                return string.Empty;
            }
            return dateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
