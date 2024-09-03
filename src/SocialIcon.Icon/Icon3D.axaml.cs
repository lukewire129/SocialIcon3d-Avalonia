using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace SocialIcon.Icon;

public class Icon3D : ContentControl
{
    public static readonly AvaloniaProperty BorderBrushProperty =
        AvaloniaProperty.Register<Icon3D, IBrush?>(nameof(BorderBrush));

    public IBrush? BorderBrush
    {
        get => (IBrush?)GetValue(BorderBrushProperty);
        set => SetValue(BorderBrushProperty, value);
    }
}