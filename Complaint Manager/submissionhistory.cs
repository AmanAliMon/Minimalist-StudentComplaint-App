using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Complaint_Manager
{
    public partial class submissionhistory : MaterialForm
    {
        public submissionhistory()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            studentpanel stdp = new studentpanel();
            this.Hide();
            stdp.Show();
            stdp.FormClosed += (s, args) => this.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "View" button column
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnView"].Index)
            {
                // Retrieve the data for the clicked row (for example, the description)
                string date = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                string type = dataGridView1.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                int sno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Sno"].Value.ToString());
                string description = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                view v = new view(sno);
                this.Hide();
                v.Show();
                // You can now open a new form or show a message box with details
            }
        }

        //private void submissionhistory_Load(object sender, EventArgs e)
        //{
        //    // Define columns if none exist
        //    if (dataGridView1.Columns.Count == 0)
        //    {
        //        dataGridView1.Columns.Add("Date", "Date");
        //        dataGridView1.Columns.Add("Type", "Type");
        //        dataGridView1.Columns.Add("Description", "Description");
        //        dataGridView1.Columns.Add("Status", "Status");
        //    }

        //    dataGridView1.Rows.Clear();
        //    dataGridView1.Rows.Add("2025-06-01", "Complaint", "WiFi not working", "Pending");
        //    dataGridView1.Rows.Add("2025-06-02", "Feedback", "Canteen food improved", "Resolved");
        //}
        private string connectionString = "server=localhost;user=root;password=;database=complaint_app;";

        private void submissionhistory_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DodgerBlue;
            label4.BackColor = Color.DodgerBlue;
            label5.BackColor = Color.DodgerBlue;
            label7.BackColor = Color.DodgerBlue;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.Columns.Add("Sno", "No.");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Status", "Status");

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "View";
            btnColumn.DefaultCellStyle.BackColor = Color.White;
            btnColumn.Name = "btnView";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select *,  DATE_FORMAT(date_submitted, '%d-%m-%Y %H:%i') AS date FROM complaints where user_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Session.UserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string subject = reader.GetString("subject");
                            string desc = reader.GetString("description");
                            string date = reader.GetString("date");
                            int _status = reader.GetInt32("status");
                            int id = reader.GetInt32("id");
                            string status = _status == 2 ? "Resolved" : _status == 1 ? "Fixing" : "Delivered";
                            string response = reader.IsDBNull(reader.GetOrdinal("response")) ? "" : reader.GetString("response"); ;
                            dataGridView1.Rows.Add(id, date, subject, desc, status);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            dataGridView1.CellClick += DataGridView1_CellClick;
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
