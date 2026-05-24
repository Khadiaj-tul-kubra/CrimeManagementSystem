namespace CrimeManagement.UI.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebar;
        private Panel topPanel;

        private Label lblLogo;
        private Label lblTitle;

        private Button btnDashboard;
        private Button btnFIR;
        private Button btnCriminals;
        private Button btnReports;
        private Button btnLogout;

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
            lblCases = new Label();
            card2 = new Panel();
            lblSolved = new Label();
            card3 = new Panel();
            lblPending = new Label();
            sidebar.SuspendLayout();
            topPanel.SuspendLayout();
            card1.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(88, 28, 135);
            sidebar.Controls.Add(lblLogo);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(btnFIR);
            sidebar.Controls.Add(btnCriminals);
            sidebar.Controls.Add(btnReports);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(312, 1000);
            sidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(44, 50);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(193, 120);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "CRIME\nSYSTEM";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(88, 28, 135);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(25, 225);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(262, 62);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnFIR
            // 
            btnFIR.BackColor = Color.FromArgb(88, 28, 135);
            btnFIR.FlatAppearance.BorderSize = 0;
            btnFIR.FlatStyle = FlatStyle.Flat;
            btnFIR.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFIR.ForeColor = Color.White;
            btnFIR.Location = new Point(25, 312);
            btnFIR.Margin = new Padding(4);
            btnFIR.Name = "btnFIR";
            btnFIR.Size = new Size(262, 62);
            btnFIR.TabIndex = 2;
            btnFIR.Text = "FIR Management";
            btnFIR.UseVisualStyleBackColor = false;
            // 
            // btnCriminals
            // 
            btnCriminals.BackColor = Color.FromArgb(88, 28, 135);
            btnCriminals.FlatAppearance.BorderSize = 0;
            btnCriminals.FlatStyle = FlatStyle.Flat;
            btnCriminals.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCriminals.ForeColor = Color.White;
            btnCriminals.Location = new Point(25, 400);
            btnCriminals.Margin = new Padding(4);
            btnCriminals.Name = "btnCriminals";
            btnCriminals.Size = new Size(262, 62);
            btnCriminals.TabIndex = 3;
            btnCriminals.Text = "Criminal Records";
            btnCriminals.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(88, 28, 135);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(25, 488);
            btnReports.Margin = new Padding(4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(262, 62);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(88, 28, 135);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(25, 575);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(262, 62);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblTitle);
            topPanel.Location = new Point(312, 0);
            topPanel.Margin = new Padding(4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1500, 100);
            topPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(50, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(671, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Crime Management Dashboard";
            // 
            // card1
            // 
            card1.BackColor = Color.White;
            card1.Controls.Add(lblCases);
            card1.Location = new Point(400, 175);
            card1.Margin = new Padding(4);
            card1.Name = "card1";
            card1.Size = new Size(350, 200);
            card1.TabIndex = 2;
            // 
            // lblCases
            // 
            lblCases.AutoSize = true;
            lblCases.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCases.Location = new Point(62, 50);
            lblCases.Margin = new Padding(4, 0, 4, 0);
            lblCases.Name = "lblCases";
            lblCases.Size = new Size(231, 108);
            lblCases.TabIndex = 0;
            lblCases.Text = "Total Cases\n120";
            // 
            // card2
            // 
            card2.BackColor = Color.White;
            card2.Controls.Add(lblSolved);
            card2.Location = new Point(825, 175);
            card2.Margin = new Padding(4);
            card2.Name = "card2";
            card2.Size = new Size(350, 200);
            card2.TabIndex = 3;
            // 
            // lblSolved
            // 
            lblSolved.AutoSize = true;
            lblSolved.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSolved.Location = new Point(62, 50);
            lblSolved.Margin = new Padding(4, 0, 4, 0);
            lblSolved.Name = "lblSolved";
            lblSolved.Size = new Size(265, 108);
            lblSolved.TabIndex = 0;
            lblSolved.Text = "Solved Cases\n80";
            // 
            // card3
            // 
            card3.BackColor = Color.White;
            card3.Controls.Add(lblPending);
            card3.Location = new Point(1250, 175);
            card3.Margin = new Padding(4);
            card3.Name = "card3";
            card3.Size = new Size(350, 200);
            card3.TabIndex = 4;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPending.Location = new Point(50, 50);
            lblPending.Margin = new Padding(4, 0, 4, 0);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(294, 108);
            lblPending.TabIndex = 0;
            lblPending.Text = "Pending Cases\n40";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 250);
            ClientSize = new Size(1750, 1000);
            Controls.Add(sidebar);
            Controls.Add(topPanel);
            Controls.Add(card1);
            Controls.Add(card2);
            Controls.Add(card3);
            Margin = new Padding(4);
            Name = "DashboardForm";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            card1.ResumeLayout(false);
            card1.PerformLayout();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            ResumeLayout(false);
        }
    }
}