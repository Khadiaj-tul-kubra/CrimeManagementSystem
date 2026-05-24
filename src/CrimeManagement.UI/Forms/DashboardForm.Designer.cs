namespace CrimeManagement.UI.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebar;
        private Label lblLogo;

        private Button btnDashboard;
        private Button btnFIR;
        private Button btnCriminals;
        private Button btnReports;
        private Button btnLogout;

        private Panel topPanel;
        private Label lblTitle;

        private Panel card1;
        private Panel card2;
        private Panel card3;

        private Label lblCases;
        private Label lblSolved;
        private Label lblPending;

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
            sidebar = new Panel();

            lblLogo = new Label();

            btnDashboard = new Button();
            btnFIR = new Button();
            btnCriminals = new Button();
            btnReports = new Button();
            btnLogout = new Button();

            topPanel = new Panel();
            lblTitle = new Label();

            card1 = new Panel();
            card2 = new Panel();
            card3 = new Panel();

            lblCases = new Label();
            lblSolved = new Label();
            lblPending = new Label();

            SuspendLayout();

            // FORM
            BackColor = Color.FromArgb(245, 245, 250);
            ClientSize = new Size(1400, 800);
            WindowState = FormWindowState.Maximized;
            Text = "Dashboard";

            // SIDEBAR
            sidebar.BackColor = Color.FromArgb(88, 28, 135);
            sidebar.Size = new Size(250, 800);
            sidebar.Dock = DockStyle.Left;

            // LOGO
            lblLogo.Text = "CRIME\nSYSTEM";
            lblLogo.ForeColor = Color.White;
            lblLogo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblLogo.Location = new Point(35, 40);
            lblLogo.AutoSize = true;

            // BUTTON STYLE METHOD
            Button[] buttons =
            {
                btnDashboard,
                btnFIR,
                btnCriminals,
                btnReports,
                btnLogout
            };

            string[] texts =
            {
                "Dashboard",
                "FIR Management",
                "Criminal Records",
                "Reports",
                "Logout"
            };

            int top = 180;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = texts[i];

                buttons[i].Size = new Size(210, 50);
                buttons[i].Location = new Point(20, top);

                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;

                buttons[i].BackColor = Color.FromArgb(88, 28, 135);
                buttons[i].ForeColor = Color.White;

                buttons[i].Font = new Font("Segoe UI", 11, FontStyle.Bold);

                top += 70;

                sidebar.Controls.Add(buttons[i]);
            }

            sidebar.Controls.Add(lblLogo);

            // TOP PANEL
            topPanel.BackColor = Color.White;
            topPanel.Size = new Size(1200, 80);
            topPanel.Location = new Point(250, 0);

            // TITLE
            lblTitle.Text = "Crime Management Dashboard";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.Location = new Point(40, 20);
            lblTitle.AutoSize = true;

            topPanel.Controls.Add(lblTitle);

            // CARD 1
            card1.BackColor = Color.White;
            card1.Size = new Size(280, 160);
            card1.Location = new Point(320, 140);

            lblCases.Text = "Total Cases\n120";
            lblCases.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblCases.Location = new Point(50, 40);
            lblCases.AutoSize = true;

            card1.Controls.Add(lblCases);

            // CARD 2
            card2.BackColor = Color.White;
            card2.Size = new Size(280, 160);
            card2.Location = new Point(660, 140);

            lblSolved.Text = "Solved Cases\n80";
            lblSolved.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblSolved.Location = new Point(50, 40);
            lblSolved.AutoSize = true;

            card2.Controls.Add(lblSolved);

            // CARD 3
            card3.BackColor = Color.White;
            card3.Size = new Size(280, 160);
            card3.Location = new Point(1000, 140);

            lblPending.Text = "Pending Cases\n40";
            lblPending.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblPending.Location = new Point(40, 40);
            lblPending.AutoSize = true;

            card3.Controls.Add(lblPending);

            // ADD CONTROLS
            Controls.Add(sidebar);

            Controls.Add(topPanel);

            Controls.Add(card1);
            Controls.Add(card2);
            Controls.Add(card3);

            ResumeLayout(false);
        }
    }
}