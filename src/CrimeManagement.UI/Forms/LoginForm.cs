using CrimeManagement.UI.Data;
using System.Linq;

namespace CrimeManagement.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();

            var user = context.Users.FirstOrDefault(x =>
                x.Email == txtEmail.Text &&
                x.Password == txtPassword.Text);

            if (user != null)
            {
                DashboardForm dashboard = new DashboardForm();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Email or Password",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}