using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using MaterialSkin;


namespace Complaint_Manager
{
    public partial class login : MaterialForm
    {
        public login()
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

        private readonly string connectionString = "server=localhost;user=root;password=;database=complaint_app;";

        private void button4_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password, username,role, id FROM users WHERE LOWER(email) = LOWER(@mail)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mail", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader.GetString("password");
                            string role = reader.GetString("role");
                            int userId = reader.GetInt32("id");

                            if (password == storedPassword) 
                            {
                                Session.Username = reader.GetString("username");
                                Session.UserId = userId;
                                Session.Role = role;

                                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();

                                Form nextForm = role == "admin"
                                    ? new adminpanel()
                                    : new studentpanel();

                                nextForm.FormClosed += (s, args) => this.Close();
                                nextForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No user found with this email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting to database:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            var registerForm = new Form1();
            this.Hide();
            registerForm.FormClosed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void login_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("Segoe UI", 20F);

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
