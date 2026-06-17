using CADE.Aurora.Settings;
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

            DateTimeOffset displayTime = TimeZoneSettings.UseLocalTime
                ? dateTimeOffset.ToLocalTime()
                : dateTimeOffset;

            string suffix = TimeZoneSettings.UseLocalTime ? " (本地)" : " (UTC)";
            return displayTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + suffix;
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
