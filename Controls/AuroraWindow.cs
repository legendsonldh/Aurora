using System.Windows;
using Wpf.Ui.Controls;

namespace CADE.Aurora.Controls;

public class AuroraWindow : FluentWindow
{
    static AuroraWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(AuroraWindow),
            new FrameworkPropertyMetadata(typeof(AuroraWindow)));
    }

    public AuroraWindow()
    {
        WindowBackdropType = WindowBackdropType.Acrylic;
        WindowCornerPreference = WindowCornerPreference.Round;
    }
}
