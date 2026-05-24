namespace CrimeManagement.UI.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            btnDarkMode.Click +=
                btnDarkMode_Click;

            btnLightMode.Click +=
                btnLightMode_Click;
        }

        // DARK MODE
        private void btnDarkMode_Click(
            object? sender,
            EventArgs e)
        {
            this.BackColor =
                Color.FromArgb(30, 30, 30);

            lblTitle.ForeColor =
                Color.White;

            MessageBox.Show(
                "Dark Mode Enabled");
        }

        // LIGHT MODE
        private void btnLightMode_Click(
            object? sender,
            EventArgs e)
        {
            this.BackColor =
                Color.White;

            lblTitle.ForeColor =
                Color.Black;

            MessageBox.Show(
                "Light Mode Enabled");
        }
    }
}