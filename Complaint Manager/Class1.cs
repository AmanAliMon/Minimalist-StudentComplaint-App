using System;
using System.Drawing;
using System.Windows.Forms;

public static class UIStyle
{
    // theme Colors
    public static Color BackgroundColor = Color.FromArgb(199, 188, 240);   // Light violet
    public static Color AccentColor = Color.FromArgb(111, 91, 139);        // Deep violet
    public static Color TextColor = Color.FromArgb(44, 38, 29);            // Dark brown
    public static Color BorderColor = Color.FromArgb(111, 91, 139);        // Violet border
    public static void ApplyTheme(Control parent)
    {

        foreach (Control ctrl in parent.Controls)
        {
            
            
            if (ctrl is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = BackgroundColor;
                btn.FlatAppearance.BorderSize = 2;
                btn.BackColor = AccentColor;

            }
            
            if (ctrl.HasChildren)
            {
                ApplyTheme(ctrl); 
            }
        }
    }
}
