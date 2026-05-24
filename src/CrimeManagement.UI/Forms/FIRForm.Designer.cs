namespace CrimeManagement.UI.Forms
{
    partial class FIRForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblName;
        private Label lblCrimeType;
        private Label lblDescription;
        private Label lblStatus;
        private Label lblSearch;

        private TextBox txtName;
        private TextBox txtCrimeType;
        private TextBox txtDescription;
        private TextBox txtSearch;

        private ComboBox cmbStatus;

        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvFIRs;

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
            lblCrimeType = new Label();
            lblDescription = new Label();
            lblStatus = new Label();
            lblSearch = new Label();

            txtName = new TextBox();
            txtCrimeType = new TextBox();
            txtDescription = new TextBox();
            txtSearch = new TextBox();

            cmbStatus = new ComboBox();

            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            dgvFIRs = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)
            (dgvFIRs)).BeginInit();

            SuspendLayout();

            // FORM
            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(245, 245, 250);

            ClientSize =
                new Size(1400, 800);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "FIR Management";

            // TITLE
            lblTitle.Text =
                "FIR Management";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    28,
                    FontStyle.Bold);

            lblTitle.Location =
                new Point(50, 30);

            lblTitle.AutoSize = true;

            // NAME LABEL
            lblName.Text =
                "Complainant Name";

            lblName.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold);

            lblName.Location =
                new Point(50, 120);

            // NAME TEXTBOX
            txtName.Location =
                new Point(50, 150);

            txtName.Size =
                new Size(350, 30);

            txtName.Font =
                new Font(
                    "Segoe UI",
                    10);

            // CRIME TYPE LABEL
            lblCrimeType.Text =
                "Crime Type";

            lblCrimeType.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold);

            lblCrimeType.Location =
                new Point(50, 210);

            // CRIME TYPE TEXTBOX
            txtCrimeType.Location =
                new Point(50, 240);

            txtCrimeType.Size =
                new Size(350, 30);

            txtCrimeType.Font =
                new Font(
                    "Segoe UI",
                    10);

            // DESCRIPTION LABEL
            lblDescription.Text =
                "Description";

            lblDescription.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold);

            lblDescription.Location =
                new Point(50, 300);

            // DESCRIPTION TEXTBOX
            txtDescription.Location =
                new Point(50, 330);

            txtDescription.Multiline =
                true;

            txtDescription.Size =
                new Size(350, 120);

            txtDescription.Font =
                new Font(
                    "Segoe UI",
                    10);

            // STATUS LABEL
            lblStatus.Text =
                "Status";

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold);

            lblStatus.Location =
                new Point(50, 490);

            // STATUS COMBO
            cmbStatus.Location =
                new Point(50, 520);

            cmbStatus.Size =
                new Size(350, 30);

            cmbStatus.Font =
                new Font(
                    "Segoe UI",
                    10);

            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Solved");

            // SAVE BUTTON
            btnSave.Text =
                "Save FIR";

            btnSave.Location =
                new Point(50, 600);

            btnSave.Size =
                new Size(150, 50);

            btnSave.BackColor =
                Color.FromArgb(88, 28, 135);

            btnSave.ForeColor =
                Color.White;

            btnSave.FlatStyle =
                FlatStyle.Flat;

            btnSave.FlatAppearance.BorderSize = 0;

            btnSave.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // UPDATE BUTTON
            btnUpdate.Text =
                "Update FIR";

            btnUpdate.Location =
                new Point(250, 600);

            btnUpdate.Size =
                new Size(150, 50);

            btnUpdate.BackColor =
                Color.DarkOrange;

            btnUpdate.ForeColor =
                Color.White;

            btnUpdate.FlatStyle =
                FlatStyle.Flat;

            btnUpdate.FlatAppearance.BorderSize = 0;

            btnUpdate.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // DELETE BUTTON
            btnDelete.Text =
                "Delete FIR";

            btnDelete.Location =
                new Point(50, 680);

            btnDelete.Size =
                new Size(150, 50);

            btnDelete.BackColor =
                Color.Crimson;

            btnDelete.ForeColor =
                Color.White;

            btnDelete.FlatStyle =
                FlatStyle.Flat;

            btnDelete.FlatAppearance.BorderSize = 0;

            btnDelete.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // CLEAR BUTTON
            btnClear.Text =
                "Clear";

            btnClear.Location =
                new Point(250, 680);

            btnClear.Size =
                new Size(150, 50);

            btnClear.BackColor =
                Color.Gray;

            btnClear.ForeColor =
                Color.White;

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.FlatAppearance.BorderSize = 0;

            btnClear.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // SEARCH LABEL
            lblSearch.Text =
                "Search FIR";

            lblSearch.Font =
                new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold);

            lblSearch.Location =
                new Point(520, 50);

            // SEARCH BOX
            txtSearch.Location =
                new Point(650, 50);

            txtSearch.Size =
                new Size(300, 30);

            txtSearch.Font =
                new Font(
                    "Segoe UI",
                    10);

            // GRID
            dgvFIRs.Location =
                new Point(500, 120);

            dgvFIRs.Size =
                new Size(850, 610);

            dgvFIRs.BackgroundColor =
                Color.White;

            dgvFIRs.BorderStyle =
                BorderStyle.None;

            dgvFIRs.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvFIRs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvFIRs.MultiSelect =
                false;

            dgvFIRs.RowTemplate.Height = 35;

            dgvFIRs.Font =
                new Font(
                    "Segoe UI",
                    10);

            dgvFIRs.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // ADD CONTROLS
            Controls.Add(lblTitle);

            Controls.Add(lblName);
            Controls.Add(txtName);

            Controls.Add(lblCrimeType);
            Controls.Add(txtCrimeType);

            Controls.Add(lblDescription);
            Controls.Add(txtDescription);

            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);

            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);

            Controls.Add(lblSearch);
            Controls.Add(txtSearch);

            Controls.Add(dgvFIRs);

            ((System.ComponentModel.ISupportInitialize)
            (dgvFIRs)).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}