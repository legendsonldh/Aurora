using System;
using System.Globalization;
using System.Windows.Data;

namespace CADE.Aurora.Converters;

public class NumberToTextConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int count)
        {
            if (count > 99)
            {
                return "99+";
            }
            else
            {
                return count.ToString();
            }
        }

        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
