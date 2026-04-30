using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace CADE.Aurora.Converters;

public class BoolToBrushConverter : IValueConverter
{
    public Brush TrueBrush { get; set; } = Brushes.Green;
    public Brush FalseBrush { get; set; } = Brushes.Gray;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool isActive && isActive)
            return TrueBrush;
        return FalseBrush;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
