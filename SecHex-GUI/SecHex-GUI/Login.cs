using System.Windows.Forms;  // Required for MessageBoxButtons and MessageBoxIcon
using MetroFramework.Forms;

namespace SecHex_GUI
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = lblUsername.Text ?? string.Empty; // Replace null with empty string
            string password = lblPassword.Text ?? string.Empty;

            username = username.Trim(); // Remove extra spaces
            password = password.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "admin" && password == "password") // Replace with real authentication
            {
                this.Hide();
                Spoofy mainForm = new Spoofy();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show(this, "Invalid credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}