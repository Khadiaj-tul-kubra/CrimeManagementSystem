namespace CrimeManagement.UI.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Button btnExportPdf;
        private DataGridView dgvReports;

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

            dgvReports =
                new DataGridView();

            ((System.ComponentModel.ISupportInitialize)
            (dgvReports)).BeginInit();

            SuspendLayout();

            // FORM
            BackColor =
                Color.FromArgb(245, 245, 250);

            ClientSize =
                new Size(1200, 700);

            Text = "Reports";

            StartPosition =
                FormStartPosition.CenterScreen;

            // TITLE
            lblTitle.Text =
                "FIR Reports";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    28,
                    FontStyle.Bold);

            lblTitle.Location =
                new Point(40, 30);

            lblTitle.AutoSize = true;

            // GRID
            dgvReports.Location =
                new Point(40, 120);

            dgvReports.Size =
                new Size(1100, 500);

            dgvReports.BackgroundColor =
                Color.White;

            dgvReports.BorderStyle =
                BorderStyle.None;

            dgvReports.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReports.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // EXPORT BUTTON
            btnExportPdf = new Button();

            btnExportPdf.Text =
                "Export PDF";

            btnExportPdf.Location =
                new Point(40, 640);

            btnExportPdf.Size =
                new Size(180, 45);

            btnExportPdf.BackColor =
                Color.FromArgb(88, 28, 135);

            btnExportPdf.ForeColor =
                Color.White;

            btnExportPdf.FlatStyle =
                FlatStyle.Flat;

            btnExportPdf.FlatAppearance.BorderSize = 0;

            btnExportPdf.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            Controls.Add(btnExportPdf);


            // ADD CONTROLS
            Controls.Add(lblTitle);

            Controls.Add(dgvReports);

            ((System.ComponentModel.ISupportInitialize)
            (dgvReports)).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}