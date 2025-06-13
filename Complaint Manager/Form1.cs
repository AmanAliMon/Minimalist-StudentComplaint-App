using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Complaint_Manager
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private string connectionString = "server=localhost;user=root;password=;database=complaint_app;";

        private void button4_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (name.Length < 6)
            {
                MessageBox.Show("Name must be at least 6 characters long.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @mail";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@mail", email);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Email is already registered.");
                        return;
                    }
                    string query = "INSERT INTO users(username, email, password, role) VALUES(@name, @mail, @pass, 'user'); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@pass", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);

                        Session.UserId = userId;
                        Session.Username = name;
                        Session.Role = "user";

                        MessageBox.Show("Account Created");

                        studentpanel stdp = new studentpanel();
                        this.Hide();
                        stdp.Show();

                        stdp.FormClosed += (s, args) => this.Close(); // stackoverflow line
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





        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.MidnightBlue;

            UIStyle.ApplyTheme(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            login loginpage = new login();
            this.Hide();
            loginpage.Show();

            loginpage.FormClosed += (s, args) => this.Close();

        }

        private void tButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
