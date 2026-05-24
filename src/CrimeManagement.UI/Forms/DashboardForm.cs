namespace CrimeManagement.UI.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            btnFIR.Click += btnFIR_Click;

            btnDashboard.Click += btnDashboard_Click;

            btnLogout.Click += btnLogout_Click;

            btnReports.Click += btnReports_Click;

            btnCriminals.Click += btnCriminals_Click;
        }

        private void btnDashboard_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Dashboard Loaded");
        }

        private void btnFIR_Click(
            object sender,
            EventArgs e)
        {
            FIRForm firForm = new FIRForm();

            firForm.ShowDialog();
        }

        private void btnCriminals_Click(
             object sender,
             EventArgs e)
        {
            CriminalForm criminalForm =
                new CriminalForm();

            criminalForm.ShowDialog();
        }

        private void btnReports_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Reports Module Coming Soon");
        }

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            LoginForm login = new LoginForm();

            login.Show();

            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}