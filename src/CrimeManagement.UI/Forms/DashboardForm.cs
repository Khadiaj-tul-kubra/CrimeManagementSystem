using CrimeManagement.UI.Data;
namespace CrimeManagement.UI.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            LoadDashboardStats();

            btnFIR.Click += btnFIR_Click;

            btnCriminals.Click +=
                btnCriminals_Click;

            btnReports.Click +=
                btnReports_Click;

            btnLogout.Click +=
                btnLogout_Click;
        }


// DASHBOARD STATS
private void LoadDashboardStats()
        {
            using var context =
                new AppDbContext();

            int totalCases =
                context.FIRs.Count();

            int solvedCases =
                context.FIRs
                .Count(x =>
                    x.Status == "Solved");

            int pendingCases =
                context.FIRs
                .Count(x =>
                    x.Status == "Pending");

            int totalCriminals =
                context.Criminals.Count();

            lblCases.Text =
                $"Total Cases\n{totalCases}";

            lblSolved.Text =
                $"Solved Cases\n{solvedCases}";

            lblPending.Text =
                $"Pending Cases\n{pendingCases}";

            lblCriminals.Text =
                $"Criminals\n{totalCriminals}";
        }

        // FIR MODULE
        private void btnFIR_Click(
            object? sender,
            EventArgs e)
        {
            FIRForm firForm =
                new FIRForm();

            firForm.ShowDialog();

            LoadDashboardStats();
        }

        // CRIMINAL MODULE
        private void btnCriminals_Click(
            object? sender,
            EventArgs e)
        {
            CriminalForm criminalForm =
                new CriminalForm();

            criminalForm.ShowDialog();

            LoadDashboardStats();
        }

        // REPORTS MODULE
        private void btnReports_Click(
            object? sender,
            EventArgs e)
        {
            ReportsForm reports =
                new ReportsForm();

            reports.ShowDialog();
        }

        // LOGOUT
        private void btnLogout_Click(
            object? sender,
            EventArgs e)
        {
            LoginForm login =
                new LoginForm();

            login.Show();

            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}