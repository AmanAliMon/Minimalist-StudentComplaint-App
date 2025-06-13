namespace Complaint_Manager
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4 = new TButton();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new TButton();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(128, 231);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(76, 21);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(129, 174);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(48, 21);
            label3.TabIndex = 17;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(91, 94);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(435, 37);
            label2.TabIndex = 16;
            label2.Text = "Sign in to Student Complaint Portal";
            label2.Click += label2_Click_1;
            // 
            // button4
            // 
            button4.AutoSize = false;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(155, 144, 192);
            button4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button4.Depth = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.HighEmphasis = true;
            button4.Icon = null;
            button4.Location = new Point(129, 295);
            button4.Margin = new Padding(4, 6, 4, 6);
            button4.MouseState = MaterialSkin.MouseState.HOVER;
            button4.Name = "button4";
            button4.NoAccentTextColor = Color.Empty;
            button4.Size = new Size(124, 36);
            button4.TabIndex = 14;
            button4.Text = "Login";
            button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button4.UseAccentColor = false;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtUsername
            // 
            txtUsername.AccessibleName = "";
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(214, 172);
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.Size = new Size(253, 23);
            txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(215, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(253, 23);
            txtPassword.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            label1.BackColor = Color.MidnightBlue;
            label1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            label1.Depth = 0;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.HighEmphasis = true;
            label1.Icon = null;
            label1.Location = new Point(339, 295);
            label1.Margin = new Padding(4, 6, 4, 6);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.NoAccentTextColor = Color.Empty;
            label1.Size = new Size(124, 36);
            label1.TabIndex = 20;
            label1.Text = "Register";
            label1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            label1.UseAccentColor = false;
            label1.UseVisualStyleBackColor = false;
            label1.Click += label1_Click_1;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 144, 255);
            ClientSize = new Size(631, 374);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "login";
            Text = "Login in order to continue";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private TButton button4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TButton label1;
    }
}