using System.Windows;
using System.Windows.Media;
using Wpf.Ui.Controls;

namespace CADE.Aurora.Controls
{
    public class AuroraActionCard : Button
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(AuroraActionCard), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(nameof(Description), typeof(string), typeof(AuroraActionCard), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty IconSourceProperty =
            DependencyProperty.Register(nameof(IconSource), typeof(ImageSource), typeof(AuroraActionCard), new PropertyMetadata(null));

        public static readonly DependencyProperty AccentBrushProperty =
            DependencyProperty.Register(nameof(AccentBrush), typeof(Brush), typeof(AuroraActionCard), new PropertyMetadata(null));

        public static readonly DependencyProperty AdditionalContentProperty =
            DependencyProperty.Register(nameof(AdditionalContent), typeof(object), typeof(AuroraActionCard), new PropertyMetadata(null));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public ImageSource IconSource
        {
            get => (ImageSource)GetValue(IconSourceProperty);
            set => SetValue(IconSourceProperty, value);
        }

        public Brush AccentBrush
        {
            get => (Brush)GetValue(AccentBrushProperty);
            set => SetValue(AccentBrushProperty, value);
        }

        public object AdditionalContent
        {
            get => (object)GetValue(AdditionalContentProperty);
            set => SetValue(AdditionalContentProperty, value);
        }

        static AuroraActionCard()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AuroraActionCard), new FrameworkPropertyMetadata(typeof(AuroraActionCard)));
        }
    }
}
