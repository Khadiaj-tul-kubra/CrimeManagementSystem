namespace CrimeManagement.UI.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel leftPanel;
        private Label lblWelcome;
        private Label lblSubtitle;

        private Panel loginPanel;
        private Button btnRegister;
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
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            leftPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(88, 28, 135);
            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(lblSubtitle);
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(420, 600);
            leftPanel.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(40, 140);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(382, 222);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Crime\nManagement\nSystem";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.Gainsboro;
            lblSubtitle.Location = new Point(45, 320);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(386, 32);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Secure Crime Record Management";
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(lblLogin);
            loginPanel.Controls.Add(lblEmail);
            loginPanel.Controls.Add(txtEmail);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Location = new Point(500, 100);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(380, 360);
            loginPanel.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLogin.Location = new Point(120, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(155, 65);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(40, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 30);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(40, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 37);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.Location = new Point(40, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 30);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(40, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 37);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(88, 28, 135);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // REGISTER BUTTON
            btnRegister = new Button();

            btnRegister.Text =
                "Create Account";

            btnRegister.Location =
                new Point(100, 420);

            btnRegister.Size =
                new Size(250, 45);

            btnRegister.BackColor =
                Color.Gray;

            btnRegister.ForeColor =
                Color.White;

            btnRegister.FlatStyle =
                FlatStyle.Flat;

            btnRegister.FlatAppearance.BorderSize = 0;

            Controls.Add(btnRegister);

            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(leftPanel);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crime Management System";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}