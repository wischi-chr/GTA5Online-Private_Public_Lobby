using System.Windows.Media;

namespace SoloPublicLobbyGTA5.Helpers
{
    public static class ColorBrush
    {
        public static SolidColorBrush Red { get; } = new SolidColorBrush(Color.FromRgb(220, 53, 69));
        public static SolidColorBrush Blue { get; } = new SolidColorBrush(Color.FromRgb(0, 123, 255));
        public static SolidColorBrush Green { get; } = new SolidColorBrush(Color.FromRgb(40, 167, 69));
        public static SolidColorBrush Yellow { get; } = new SolidColorBrush(Color.FromRgb(255, 193, 7));
    }
}
