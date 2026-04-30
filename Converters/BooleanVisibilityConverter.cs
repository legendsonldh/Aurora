using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace CADE.Aurora.Converters;

public class BooleanVisibilityConverter : MarkupExtension, IValueConverter
{
    public bool CollapsedInsteadOfHidden { get; set; } = false;
    public bool IsInverted { get; set; } = false;

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        string? param = parameter?.ToString();
        Visibility invisible = CollapsedInsteadOfHidden ? Visibility.Collapsed : Visibility.Hidden;

        if (value is int count)
        {
            if (param == "Zero")
                return count == 0 ? Visibility.Visible : invisible;
            if (param == "NonZero")
                return count > 0 ? Visibility.Visible : invisible;
            return Visibility.Visible;
        }

        if (value is bool booleanValue)
        {
            return booleanValue ^ IsInverted ? Visibility.Visible : invisible;
        }

        return Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Visibility visibility)
        {
            return visibility == Visibility.Visible;
        }
        return false;
    }
}
