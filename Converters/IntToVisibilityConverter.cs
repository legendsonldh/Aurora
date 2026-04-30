using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CADE.Aurora.Converters;

public class IntToVisibilityConverter : IValueConverter
{
    public bool CollapsedInsteadOfHidden { get; set; }
    public bool IsInverted { get; set; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int count = (value is int intValue) ? intValue : 0;
        int compareValue = parameter != null && int.TryParse(parameter.ToString(), out int param) ? param : 0;
        bool isVisible = count > compareValue;

        if (IsInverted)
            isVisible = !isVisible;

        if (isVisible)
            return Visibility.Visible;
        return CollapsedInsteadOfHidden ? Visibility.Collapsed : Visibility.Hidden;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
