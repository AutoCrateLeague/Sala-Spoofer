namespace SecHex_GUI
{
    partial class Login
    {
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnCancel;

        private void InitializeComponent()
        {
            lblUsername = new MetroFramework.Controls.MetroLabel();
            lblPassword = new MetroFramework.Controls.MetroLabel();
            btnLogin = new MetroFramework.Controls.MetroButton();
            btnCancel = new MetroFramework.Controls.MetroButton();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(107, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(175, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(107, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(175, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(107, 182);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseSelectable = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(207, 182);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseSelectable = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Login
            // 
            ClientSize = new Size(400, 250);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Name = "Login";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Purple;
            Text = "Login";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            ResumeLayout(false);
        }
    }
}
