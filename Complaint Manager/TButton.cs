using System.Drawing;
using System.Windows.Forms;

namespace Complaint_Manager
{
    class TButton : MaterialSkin.Controls.MaterialButton
    {
        public TButton()
        {
            this.BackColor = Color.Tomato;
            this.ForeColor = Theme.TextOnPrimary;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = Theme.BoldFont;
            this.Size = Theme.DefaultButtonSize;
            this.Cursor = Cursors.Hand;
            this.UseVisualStyleBackColor = false;

        }
    }
}
