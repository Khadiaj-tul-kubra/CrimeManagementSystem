namespace CrimeManagement.UI.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel leftPanel;
        private Label lblWelcome;
        private Label lblSubtitle;

        private Panel loginPanel;

        private Label lblLogin;
        private Label lblEmail;
        private Label lblPassword;

        private TextBox txtEmail;
        private TextBox txtPassword;

        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            leftPanel = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();

            loginPanel = new Panel();

            lblLogin = new Label();
            lblEmail = new Label();
            lblPassword = new Label();

            txtEmail = new TextBox();
            txtPassword = new TextBox();

            btnLogin = new Button();

            SuspendLayout();

            // Form
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Crime Management System";

            // Left Panel
            leftPanel.BackColor = Color.FromArgb(88, 28, 135);
            leftPanel.Location = new Point(0, 0);
            leftPanel.Size = new Size(420, 600);

            // Welcome Label
            lblWelcome.Text = "Crime\nManagement\nSystem";
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            lblWelcome.Location = new Point(40, 140);
            lblWelcome.AutoSize = true;

            // Subtitle
            lblSubtitle.Text = "Secure Crime Record Management";
            lblSubtitle.ForeColor = Color.Gainsboro;
            lblSubtitle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblSubtitle.Location = new Point(45, 320);
            lblSubtitle.AutoSize = true;

            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(lblSubtitle);

            // Login Panel
            loginPanel.BackColor = Color.White;
            loginPanel.Location = new Point(500, 100);
            loginPanel.Size = new Size(380, 360);

            // Login Label
            lblLogin.Text = "Login";
            lblLogin.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblLogin.Location = new Point(120, 20);
            lblLogin.AutoSize = true;

            // Email Label
            lblEmail.Text = "Email";
            lblEmail.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblEmail.Location = new Point(40, 90);
            lblEmail.AutoSize = true;

            // Email TextBox
            txtEmail.Location = new Point(40, 120);
            txtEmail.Size = new Size(290, 32);
            txtEmail.Font = new Font("Segoe UI", 11);

            // Password Label
            lblPassword.Text = "Password";
            lblPassword.Font = new Font("Segoe UI", 11);
            lblPassword.Location = new Point(40, 180);
            lblPassword.AutoSize = true;

            // Password TextBox
            txtPassword.Location = new Point(40, 210);
            txtPassword.Size = new Size(290, 32);
            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.UseSystemPasswordChar = true;

            // Login Button
            btnLogin.Text = "LOGIN";
            btnLogin.Size = new Size(290, 45);
            btnLogin.Location = new Point(40, 280);

            btnLogin.BackColor = Color.FromArgb(88, 28, 135);
            btnLogin.ForeColor = Color.White;

            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnLogin.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btnLogin.Click += btnLogin_Click;

            // Add Controls
            loginPanel.Controls.Add(lblLogin);

            loginPanel.Controls.Add(lblEmail);
            loginPanel.Controls.Add(txtEmail);

            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtPassword);

            loginPanel.Controls.Add(btnLogin);

            Controls.Add(leftPanel);
            Controls.Add(loginPanel);

            ResumeLayout(false);
        }
    }
}