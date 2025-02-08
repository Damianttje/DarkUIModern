using DarkUI.Data.Enums.Toast;

namespace DarkUI.Data.Models
{
    public sealed class DarkToastOptions
    {
        public ToastPosition DefaultPosition { get; set; } = ToastPosition.TopRight;
        public int DefaultDuration { get; set; } = 2000;
        public ToastSpeed DefaultAnimSpeed { get; set; } = ToastSpeed.Normal;
        public int MaxToasts { get; set; } = 5;
        public bool DefaultUseFadeInAnim { get; set; } = false;
    }
}
