using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Complaint_Manager
{
    public partial class view : MaterialForm
    {
        int caseID;
        public view(int id)
        {
            this.caseID = id;

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
     Primary.Blue500, Primary.Blue700, Primary.Blue100,
     Accent.Amber200, TextShade.WHITE
 );
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private string connectionString = "server=localhost;user=root;password=;database=complaint_app;";

        private void view_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DodgerBlue;
            label4.BackColor = Color.DodgerBlue;
            label5.BackColor = Color.DodgerBlue;
            label7.BackColor = Color.DodgerBlue;
            label4.ForeColor= Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label6.Font = new Font("Segoe UI", 18F);
            subj.Font = new Font("Segoe UI", 18F);


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT *,DATE_FORMAT(date_submitted, '%d-%m-%Y %H:%i') AS date  FROM complaints WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", caseID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            subj.Text = reader.GetString("subject");
                            date.Text = reader.GetString("date");
                            desc.Text = reader.GetString("description");
                            resp.Text = reader.IsDBNull(reader.GetOrdinal("response")) ? "No response" : reader.GetString("response");
                            int _status = reader.GetInt32("id");
                            status.Text = _status == 2 ? "Resolved" : _status == 1 ? "Fixing" : "Delivered";

                        }
                        else
                        {
                            MessageBox.Show("Case not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
