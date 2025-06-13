namespace Complaint_Manager
{
    partial class feedback
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
            Subject = new Label();
            Desc = new Label();
            resp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new TButton();
            groupBox1 = new GroupBox();
            Datebox = new Label();
            tButton1 = new TButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Subject
            // 
            Subject.AccessibleRole = AccessibleRole.MenuBar;
            Subject.AutoSize = true;
            Subject.Font = new Font("Segoe UI", 16F);
            Subject.Location = new Point(61, 78);
            Subject.Name = "Subject";
            Subject.Size = new Size(84, 30);
            Subject.TabIndex = 0;
            Subject.Text = "Subject";
            // 
            // Desc
            // 
            Desc.AccessibleRole = AccessibleRole.MenuBar;
            Desc.AutoSize = true;
            Desc.Font = new Font("Segoe UI", 12F);
            Desc.Location = new Point(61, 121);
            Desc.Name = "Desc";
            Desc.RightToLeft = RightToLeft.No;
            Desc.Size = new Size(89, 21);
            Desc.TabIndex = 2;
            Desc.Text = "Description";
            // 
            // resp
            // 
            resp.Location = new Point(62, 228);
            resp.Multiline = true;
            resp.Name = "resp";
            resp.Size = new Size(372, 137);
            resp.TabIndex = 4;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 193);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 5;
            label1.Text = "Respond";
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.MenuBar;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(483, 193);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 6;
            label2.Text = "Status";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.RightToLeft = RightToLeft.No;
            radioButton1.Size = new Size(74, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Delivered";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(0, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Resolved";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(0, 31);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Fixing";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Tomato;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(492, 337);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(135, 36);
            button1.TabIndex = 10;
            button1.Text = "Send Feedback";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(492, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(105, 82);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Datebox
            // 
            Datebox.AccessibleRole = AccessibleRole.MenuBar;
            Datebox.AutoSize = true;
            Datebox.Font = new Font("Segoe UI", 10F);
            Datebox.Location = new Point(676, 98);
            Datebox.Name = "Datebox";
            Datebox.Size = new Size(38, 19);
            Datebox.TabIndex = 12;
            Datebox.Text = "Date";
            // 
            // tButton1
            // 
            tButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tButton1.BackColor = Color.Tomato;
            tButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            tButton1.Depth = 0;
            tButton1.FlatStyle = FlatStyle.Flat;
            tButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tButton1.ForeColor = Color.White;
            tButton1.HighEmphasis = true;
            tButton1.Icon = null;
            tButton1.Location = new Point(62, 395);
            tButton1.Margin = new Padding(4, 6, 4, 6);
            tButton1.MouseState = MaterialSkin.MouseState.HOVER;
            tButton1.Name = "tButton1";
            tButton1.NoAccentTextColor = Color.Empty;
            tButton1.Size = new Size(64, 36);
            tButton1.TabIndex = 14;
            tButton1.Text = "Back";
            tButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            tButton1.UseAccentColor = false;
            tButton1.UseVisualStyleBackColor = true;
            tButton1.Click += tButton1_Click;
            // 
            // feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tButton1);
            Controls.Add(Datebox);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resp);
            Controls.Add(Desc);
            Controls.Add(Subject);
            Name = "feedback";
            Text = "Feedback";
            Load += feedback_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Subject;
        private Label Desc;
        private TextBox resp;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TButton button1;
        private GroupBox groupBox1;
        private Label Datebox;
        private TButton tButton1;
    }
}