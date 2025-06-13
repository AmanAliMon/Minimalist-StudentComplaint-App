using System.Drawing;
using System.Windows.Forms;

namespace Complaint_Manager
{
    static class Theme
    {

        public static readonly Color Primary = Color.FromArgb(33, 150, 243);       // Blue 500
        public static readonly Color PrimaryDark = Color.FromArgb(25, 118, 210);   // Blue 700
        public static readonly Color Accent = Color.FromArgb(255, 193, 7);         // Amber 500
        public static readonly Color Background = Color.FromArgb(245, 245, 245);   // Light grey
        public static readonly Color Surface = Color.White;
        public static readonly Color TextPrimary = Color.Black;
        public static readonly Color TextOnPrimary = Color.White;
        public static readonly Font PrimaryFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font BoldFont = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Size DefaultButtonSize = new Size(120, 36);
    }
}
