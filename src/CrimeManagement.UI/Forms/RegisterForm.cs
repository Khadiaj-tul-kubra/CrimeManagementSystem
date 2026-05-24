using CrimeManagement.UI.Data;
using CrimeManagement.UI.Models;
using System.Xml.Linq;

namespace CrimeManagement.UI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            btnRegister.Click +=
                btnRegister_Click;
        }

        private void btnRegister_Click(
            object? sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            User user = new User()
            {
                FullName =
                    txtName.Text,

                Email =
                    txtEmail.Text,

                Password =
                    txtPassword.Text,

                Role =
                    cmbRole.Text
            };

            context.Users.Add(user);

            context.SaveChanges();

            MessageBox.Show(
                "User Registered Successfully");

            this.Close();
        }
    }
}