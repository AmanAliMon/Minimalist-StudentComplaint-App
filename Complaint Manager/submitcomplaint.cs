using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Complaint_Manager
{
    public partial class submitcomplaint : MaterialForm
    {
        public submitcomplaint()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
     Primary.Blue500, Primary.Blue700, Primary.Blue100,
     Accent.Amber200, TextShade.WHITE
 );
        }

        private void submitcomplaint_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DodgerBlue;
            label4.BackColor = Color.DodgerBlue;
            label5.BackColor = Color.DodgerBlue;
            label7.BackColor = Color.DodgerBlue;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string connectionString = "server=localhost;user=root;password=;database=complaint_app;";

        private void button4_Click(object sender, EventArgs e)
        {
            //user_id	subject	description
            string Desc = des.Text.Trim();
            string Subj = sub.Text;

            if (string.IsNullOrEmpty(Desc) || string.IsNullOrEmpty(Subj))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO complaints(user_id, subject, description) VALUES(@id, @sub, @desc); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Session.UserId);
                    cmd.Parameters.AddWithValue("@sub", Subj);
                    cmd.Parameters.AddWithValue("@desc", Desc);


                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);


                        MessageBox.Show("Complaint submitted");

                        submissionhistory loginpage = new submissionhistory();
                        this.Hide();
                        loginpage.Show();

                        loginpage.FormClosed += (s, args) => this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

            studentpanel stdp = new studentpanel();
            this.Hide();
            stdp.Show();

            stdp.FormClosed += (s, args) => this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            studentpanel stdp = new studentpanel();
            this.Hide();
            stdp.Show();
            stdp.FormClosed += (s, args) => this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

            submissionhistory stdp = new submissionhistory();
            this.Hide();
            stdp.Show();
            stdp.FormClosed += (s, args) => this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            submitcomplaint stdp = new submitcomplaint();
            this.Hide();
            stdp.Show();
            stdp.FormClosed += (s, args) => this.Close();
        }
    }
}
