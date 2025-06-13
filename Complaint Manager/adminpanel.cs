using MaterialSkin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
namespace Complaint_Manager
{
    public partial class adminpanel : MaterialForm
    {
        public List<string[]> ArrayOfData = new List<string[]>();
        public adminpanel()
        {

            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
     Primary.Blue500, Primary.Blue700, Primary.Blue100,
     Accent.Amber200, TextShade.WHITE);
        }
        private string connectionString = "server=localhost;user=root;password=;database=complaint_app;";
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnView"].Index)
            {
                string date = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                string subject = dataGridView1.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                string sno = dataGridView1.Rows[e.RowIndex].Cells["Sno"].Value.ToString();
                string description = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();


                feedback fdback = new feedback(sno, description, date, subject);
                this.Hide();
                fdback.Show();

                fdback.FormClosed += (s, args) => this.Close();
            }
        }
        public void refreshData()
        {
            dataGridView1.Rows.Clear();
            foreach (string[] e in this.ArrayOfData)
            {
                if (e[2].ToLower().Contains(textBox1.Text.ToLower()) || e[3].ToLower().Contains(textBox1.Text.ToLower()))
                {
                  
                    dataGridView1.Rows.Add(e[0], e[1], e[2], e[3], e[4]);
                }
            }
        }
        private void adminpanel_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("Segoe UI", 20F);
            label4.Font = new Font("Segoe UI", 18F);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.BackgroundColor = Theme.Surface;
            dataGridView1.ForeColor = Theme.TextPrimary;
            dataGridView1.GridColor = Theme.Primary;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Theme.Primary;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Theme.TextOnPrimary;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Theme.Accent;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Theme.TextPrimary;
            dataGridView1.Columns.Add("Sno", "No.");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Type", "Subject");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Status", "Status");


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "View";
            btnColumn.Name = "btnView";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select *,users.username, DATE_FORMAT(date_submitted, '%d-%m-%Y %H:%i') AS date FROM complaints left join users on complaints.user_id = users.id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Session.UserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string subject = reader.GetString("subject");
                            string desc = reader.GetString("description");
                            string sno = $"{(reader.GetInt32("id"))}";
                            string date = reader.GetString("date");
                            int _status = reader.GetInt32("status");
                            string status = _status == 2 ? "Resolved" : _status == 1 ? "Fixing" : "Delivered";
                            string response = reader.IsDBNull(reader.GetOrdinal("response")) ? "" : reader.GetString("response"); ;
                            string[] x = { sno, date, subject, desc, status };

                            this.ArrayOfData.Add(x);




                        }
                        refreshData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
