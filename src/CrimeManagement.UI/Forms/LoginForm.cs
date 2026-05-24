using CrimeManagement.UI.Data;

namespace CrimeManagement.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click +=
                btnLogin_Click;

            btnRegister.Click +=
                btnRegister_Click;
        }

        // LOGIN
        private void btnLogin_Click(
            object? sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            var user =
                context.Users.FirstOrDefault(
                    x =>
                    x.Email == txtEmail.Text
                    &&
                    x.Password == txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show(
                    $"Welcome {user.Role}");

                DashboardForm dashboard =
                    new DashboardForm();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Email or Password");
            }
        }

        // REGISTER
        private void btnRegister_Click(
            object? sender,
            EventArgs e)
        {
            RegisterForm register =
                new RegisterForm();

            register.ShowDialog();
        }
    }
}