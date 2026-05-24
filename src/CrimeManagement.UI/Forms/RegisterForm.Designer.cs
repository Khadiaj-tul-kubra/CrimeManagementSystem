namespace CrimeManagement.UI.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRole;

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;

        private ComboBox cmbRole;

        private Button btnRegister;

        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();

            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();

            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();

            cmbRole = new ComboBox();

            btnRegister = new Button();

            SuspendLayout();

            // FORM
            BackColor =
                Color.FromArgb(245, 245, 250);

            ClientSize =
                new Size(500, 550);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Register";

            // TITLE
            lblTitle.Text =
                "Create Account";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    24,
                    FontStyle.Bold);

            lblTitle.Location =
                new Point(110, 40);

            lblTitle.AutoSize = true;

            // NAME
            lblName.Text = "Full Name";

            lblName.Location =
                new Point(60, 140);

            txtName.Location =
                new Point(60, 170);

            txtName.Size =
                new Size(350, 30);

            // EMAIL
            lblEmail.Text = "Email";

            lblEmail.Location =
                new Point(60, 230);

            txtEmail.Location =
                new Point(60, 260);

            txtEmail.Size =
                new Size(350, 30);

            // PASSWORD
            lblPassword.Text =
                "Password";

            lblPassword.Location =
                new Point(60, 320);

            txtPassword.Location =
                new Point(60, 350);

            txtPassword.Size =
                new Size(350, 30);

            txtPassword.PasswordChar = '*';

            // ROLE
            lblRole.Text = "Role";

            lblRole.Location =
                new Point(60, 410);

            cmbRole.Location =
                new Point(60, 440);

            cmbRole.Size =
                new Size(350, 30);

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Officer");

            // BUTTON
            btnRegister.Text =
                "Register";

            btnRegister.Location =
                new Point(140, 500);

            btnRegister.Size =
                new Size(200, 45);

            btnRegister.BackColor =
                Color.FromArgb(88, 28, 135);

            btnRegister.ForeColor =
                Color.White;

            btnRegister.FlatStyle =
                FlatStyle.Flat;

            btnRegister.FlatAppearance.BorderSize = 0;

            // ADD CONTROLS
            Controls.Add(lblTitle);

            Controls.Add(lblName);
            Controls.Add(txtName);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblPassword);
            Controls.Add(txtPassword);

            Controls.Add(lblRole);
            Controls.Add(cmbRole);

            Controls.Add(btnRegister);

            ResumeLayout(false);

            PerformLayout();
        }
    }
}