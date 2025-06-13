using MaterialSkin.Controls;

namespace Complaint_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new MaterialTextBox();
            txtEmail = new MaterialTextBox();
            txtName = new MaterialTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button4 = new TButton();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.ForeColor = Color.Black;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(308, 268);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 50);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.ForeColor = Color.Black;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(307, 211);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 50);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.ForeColor = Color.Black;
            txtName.LeadingIcon = null;
            txtName.Location = new Point(308, 154);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 50);
            txtName.TabIndex = 5;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(221, 152);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(178, 94);
            label2.Name = "label2";
            label2.Size = new Size(449, 37);
            label2.TabIndex = 8;
            label2.Text = "Register to Student Complaint Portal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(222, 213);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(221, 270);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // button4
            // 
            button4.AutoSize = false;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.MidnightBlue;
            button4.Density = MaterialButton.MaterialButtonDensity.Default;
            button4.Depth = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.HighEmphasis = true;
            button4.Icon = null;
            button4.Location = new Point(222, 336);
            button4.Margin = new Padding(4, 6, 4, 6);
            button4.MouseState = MaterialSkin.MouseState.HOVER;
            button4.Name = "button4";
            button4.NoAccentTextColor = Color.Empty;
            button4.Size = new Size(340, 36);
            button4.TabIndex = 22;
            button4.Text = "Continue";
            button4.Type = MaterialButton.MaterialButtonType.Contained;
            button4.UseAccentColor = false;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(284, 392);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 20;
            label5.Text = "Login ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(329, 394);
            label6.Name = "label6";
            label6.Size = new Size(195, 19);
            label6.TabIndex = 23;
            label6.Text = "if you already have an account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Create a new account";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialTextBox txtPassword;
        private MaterialTextBox txtEmail;
        private MaterialTextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TButton button4;
        private Label label5;
        private Label label6;
    }
}
