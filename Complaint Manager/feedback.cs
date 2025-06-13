using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Complaint_Manager
{
    public partial class feedback : MaterialForm
    {
        string complaint_id;
        string subject;
        string description;
        string date;
        public feedback(string id, string ds, string dt, string sj)
        {
            this.complaint_id = id;
            this.subject = sj;
            this.description = ds;
            this.date = dt;

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
     Primary.Blue500, Primary.Blue700, Primary.Blue100,
     Accent.Amber200, TextShade.WHITE);
        }
        private string connectionString = "server=localhost;user=root;password=;database=complaint_app;";

        private void button1_Click(object sender, EventArgs e)
        {
            int state = 0;
            if (radioButton1.Checked)
            {
                state = 0;
            }
            else if (radioButton2.Checked)
            {
                state = 2;
            }
            else if (radioButton3.Checked)
            {
                state = 1;
            }
            else
            {
                MessageBox.Show("No status selected.");
                return;
            }
            string Response = resp.Text;

            if (string.IsNullOrEmpty(Response))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE `complaints` SET `response` = @r, status = @s WHERE `complaints`.`id` = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@r", Response);
                    cmd.Parameters.AddWithValue("@id", Session.UserId);
                    cmd.Parameters.AddWithValue("@s", state);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {


                        MessageBox.Show("Feedback sent");

                        adminpanel stdp = new adminpanel();
                        this.Hide();
                        stdp.Show();

                        stdp.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void feedback_Load(object sender, EventArgs e)
        {
            Subject.Text = subject;
            Desc.Text = description;
            Datebox.Text = date;
            label1.Font = new Font("Segoe UI", 12F,FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Desc.Font = new Font("Segoe UI", 12F);
            Subject.Font = new Font("RSegoe UIoboto", 16F);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new adminpanel()).Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            (new adminpanel()).Show();
        }
    }
}
