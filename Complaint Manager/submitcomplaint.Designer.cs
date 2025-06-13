using MaterialSkin.Controls;

namespace Complaint_Manager
{
    partial class submitcomplaint
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
            desc = new Label();
            label2 = new Label();
            subject = new Label();
            button4 = new TButton();
            sub = new TextBox();
            des = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Font = new Font("Segoe UI", 12F);
            desc.ForeColor = Color.Black;
            desc.Location = new Point(278, 260);
            desc.Name = "desc";
            desc.Size = new Size(89, 21);
            desc.TabIndex = 17;
            desc.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(317, 104);
            label2.Name = "label2";
            label2.Size = new Size(305, 37);
            label2.TabIndex = 16;
            label2.Text = "Describe your complaint";
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Font = new Font("Segoe UI", 12F);
            subject.ForeColor = Color.Black;
            subject.Location = new Point(278, 195);
            subject.Name = "subject";
            subject.Size = new Size(61, 21);
            subject.TabIndex = 15;
            subject.Text = "Subject";
            subject.Click += label1_Click;
            // 
            // button4
            // 
            button4.AutoSize = false;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.FromArgb(155, 144, 192);
            button4.Density = MaterialButton.MaterialButtonDensity.Default;
            button4.Depth = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.HighEmphasis = true;
            button4.Icon = null;
            button4.Location = new Point(278, 385);
            button4.Margin = new Padding(4, 6, 4, 6);
            button4.MouseState = MaterialSkin.MouseState.HOVER;
            button4.Name = "button4";
            button4.NoAccentTextColor = Color.Empty;
            button4.Size = new Size(372, 29);
            button4.TabIndex = 14;
            button4.Text = "Continue";
            button4.Type = MaterialButton.MaterialButtonType.Contained;
            button4.UseAccentColor = false;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sub
            // 
            sub.BackgroundImageLayout = ImageLayout.None;
            sub.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            sub.Location = new Point(397, 197);
            sub.Name = "sub";
            sub.RightToLeft = RightToLeft.No;
            sub.Size = new Size(253, 26);
            sub.TabIndex = 13;
            sub.TabStop = false;
            // 
            // des
            // 
            des.BackgroundImageLayout = ImageLayout.None;
            des.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            des.Location = new Point(397, 260);
            des.Name = "des";
            des.RightToLeft = RightToLeft.No;
            des.Size = new Size(253, 26);
            des.TabIndex = 12;
            des.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 35);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 25;
            label4.Text = "Home";
            label4.Click += label4_Click;
            // 
            // submitcomplaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(desc);
            Controls.Add(label2);
            Controls.Add(subject);
            Controls.Add(button4);
            Controls.Add(sub);
            Controls.Add(des);
            Name = "submitcomplaint";
            Text = "Submit new complaint";
            Load += submitcomplaint_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label desc;
        private Label label2;
        private Label subject;
        private TButton button4;
        private TextBox sub;
        private TextBox des;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label4;
    }
}