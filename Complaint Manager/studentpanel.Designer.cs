namespace Complaint_Manager
{
    partial class studentpanel
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
            label1 = new Label();
            userGreet = new Label();
            button1 = new TButton();
            button2 = new TButton();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(184, 99);
            label1.Name = "label1";
            label1.Size = new Size(315, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Complaint Portal";
            label1.Click += label1_Click;
            // 
            // userGreet
            // 
            userGreet.AutoSize = true;
            userGreet.Font = new Font("Segoe UI", 16F);
            userGreet.ForeColor = Color.Black;
            userGreet.Location = new Point(359, 180);
            userGreet.Name = "userGreet";
            userGreet.Size = new Size(160, 30);
            userGreet.TabIndex = 1;
            userGreet.Text = "Welcome! User";
            userGreet.Click += userGreet_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(155, 144, 192);
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(537, 330);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(86, 36);
            button1.TabIndex = 20;
            button1.Text = "Proceed";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(155, 144, 192);
            button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button2.Depth = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.HighEmphasis = true;
            button2.Icon = null;
            button2.Location = new Point(537, 250);
            button2.Margin = new Padding(4, 6, 4, 6);
            button2.MouseState = MaterialSkin.MouseState.HOVER;
            button2.Name = "button2";
            button2.NoAccentTextColor = Color.Empty;
            button2.Size = new Size(86, 36);
            button2.TabIndex = 21;
            button2.Text = "Proceed";
            button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button2.UseAccentColor = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(285, 261);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 22;
            label3.Text = "Submit new complaint";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(285, 330);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 23;
            label4.Text = "Submission history";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 386);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 126);
            label7.Name = "label7";
            label7.Size = new Size(103, 19);
            label7.TabIndex = 27;
            label7.Text = "New Complaint";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 79);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 26;
            label5.Text = "History";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 35);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 25;
            label6.Text = "Home";
            label6.Click += label6_Click;
            // 
            // studentpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(userGreet);
            Controls.Add(label1);
            Name = "studentpanel";
            Text = "Student Panel";
            Load += studentpanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userGreet;
        private TButton button1;
        private TButton button2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label6;
    }
}