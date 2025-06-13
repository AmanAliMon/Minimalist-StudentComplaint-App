using MaterialSkin.Controls;
using MaterialSkin;


namespace Complaint_Manager
{
    public partial class studentpanel : MaterialForm
    {

        public studentpanel()
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

        private void studentpanel_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DodgerBlue;
            label6.BackColor = Color.DodgerBlue;
            label5.BackColor = Color.DodgerBlue;
            label7.BackColor = Color.DodgerBlue;
            label6.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            userGreet.Text = $"Welcome! {Session.Username}";
            label1.Font = new Font("Segoe UI", 20F);
           
            userGreet.Font = new Font("Segoe UI", 18F,(FontStyle.Bold));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            submitcomplaint sc = new submitcomplaint();
            this.Hide();
            sc.Show();

            sc.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            submissionhistory sc = new submissionhistory();
            this.Hide();
            sc.Show();

            sc.FormClosed += (s, args) => this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
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
        private void userGreet_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
