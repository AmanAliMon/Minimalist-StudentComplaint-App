using MaterialSkin;

namespace Complaint_Manager
{
    partial class view
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
            subj = new Label();
            date = new Label();
            desc = new Label();
            status = new Label();
            resp = new Label();
            label6 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // subj
            // 
            subj.AutoSize = true;
            subj.Font = new Font("Segoe UI", 18F);
            subj.Location = new Point(171, 99);
            subj.Name = "subj";
            subj.Size = new Size(93, 32);
            subj.TabIndex = 0;
            subj.Text = "Subject";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 12F);
            date.Location = new Point(646, 108);
            date.Name = "date";
            date.Size = new Size(42, 21);
            date.TabIndex = 1;
            date.Text = "Date";
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Location = new Point(187, 154);
            desc.Name = "desc";
            desc.Size = new Size(67, 15);
            desc.TabIndex = 2;
            desc.Text = "Description";
            desc.Click += label3_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI", 12F);
            status.Location = new Point(696, 403);
            status.Name = "status";
            status.Size = new Size(76, 21);
            status.TabIndex = 3;
            status.Text = "Delivered";
            // 
            // resp
            // 
            resp.AutoSize = true;
            resp.Location = new Point(187, 307);
            resp.Name = "resp";
            resp.Size = new Size(92, 15);
            resp.TabIndex = 4;
            resp.Text = "No response yet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(171, 247);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 5;
            label6.Text = "Response";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(635, 404);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 7;
            label2.Text = "Status:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-1, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 386);
            panel1.TabIndex = 24;
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
            // view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(resp);
            Controls.Add(status);
            Controls.Add(desc);
            Controls.Add(date);
            Controls.Add(subj);
            Name = "view";
            Text = "View feedback";
            Load += view_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subj;
        private Label date;
        private Label desc;
        private Label status;
        private Label resp;
        private Label label6;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label4;
    }
}