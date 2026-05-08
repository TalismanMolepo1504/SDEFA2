using ULMSWinFormsApp.Forms;

namespace ULMSWinFormsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // to encrypt the student password
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Enter both username and password !");
                return;
            }

            // correct validation logic
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login Successful!");

                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
        }

        //btnclear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

    }
}
