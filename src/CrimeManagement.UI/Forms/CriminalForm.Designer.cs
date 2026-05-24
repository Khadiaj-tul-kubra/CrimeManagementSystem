namespace CrimeManagement.UI.Forms
{
    partial class CriminalForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblName;
        private Label lblAge;
        private Label lblCrimeType;
        private Label lblAddress;
        private Label lblStatus;
        private Label lblSearch;

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtCrimeType;
        private TextBox txtAddress;
        private TextBox txtSearch;

        private ComboBox cmbStatus;

        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvCriminals;

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
            lblAge = new Label();
            lblCrimeType = new Label();
            lblAddress = new Label();
            lblStatus = new Label();
            lblSearch = new Label();

            txtName = new TextBox();
            txtAge = new TextBox();
            txtCrimeType = new TextBox();
            txtAddress = new TextBox();
            txtSearch = new TextBox();

            cmbStatus = new ComboBox();

            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            dgvCriminals = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)
            (dgvCriminals)).BeginInit();

            SuspendLayout();

            BackColor =
                Color.FromArgb(245, 245, 250);

            ClientSize =
                new Size(1400, 800);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Criminal Records";

            // TITLE
            lblTitle.Text =
                "Criminal Records";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    28,
                    FontStyle.Bold);

            lblTitle.Location =
                new Point(50, 30);

            lblTitle.AutoSize = true;

            // LABELS
            lblName.Text = "Criminal Name";
            lblName.Location =
                new Point(50, 130);

            lblAge.Text = "Age";
            lblAge.Location =
                new Point(50, 220);

            lblCrimeType.Text =
                "Crime Type";

            lblCrimeType.Location =
                new Point(50, 310);

            lblAddress.Text =
                "Address";

            lblAddress.Location =
                new Point(50, 400);

            lblStatus.Text =
                "Status";

            lblStatus.Location =
                new Point(50, 520);

            lblSearch.Text =
                "Search Criminal";

            lblSearch.Location =
                new Point(520, 60);

            // TEXTBOXES
            txtName.Location =
                new Point(50, 160);

            txtName.Size =
                new Size(350, 30);

            txtAge.Location =
                new Point(50, 250);

            txtAge.Size =
                new Size(350, 30);

            txtCrimeType.Location =
                new Point(50, 340);

            txtCrimeType.Size =
                new Size(350, 30);

            txtAddress.Location =
                new Point(50, 430);

            txtAddress.Multiline =
                true;

            txtAddress.Size =
                new Size(350, 60);

            txtSearch.Location =
                new Point(670, 55);

            txtSearch.Size =
                new Size(300, 30);

            // COMBO
            cmbStatus.Location =
                new Point(50, 550);

            cmbStatus.Size =
                new Size(350, 30);

            cmbStatus.Items.Add("Wanted");
            cmbStatus.Items.Add("Captured");
            cmbStatus.Items.Add("Under Investigation");

            // BUTTONS
            btnSave.Text = "Save";

            btnSave.Location =
                new Point(50, 650);

            btnSave.Size =
                new Size(150, 50);

            btnSave.BackColor =
                Color.FromArgb(88, 28, 135);

            btnSave.ForeColor =
                Color.White;

            btnSave.FlatStyle =
                FlatStyle.Flat;

            btnSave.FlatAppearance.BorderSize = 0;

            btnUpdate.Text =
                "Update";

            btnUpdate.Location =
                new Point(250, 650);

            btnUpdate.Size =
                new Size(150, 50);

            btnUpdate.BackColor =
                Color.DarkOrange;

            btnUpdate.ForeColor =
                Color.White;

            btnUpdate.FlatStyle =
                FlatStyle.Flat;

            btnUpdate.FlatAppearance.BorderSize = 0;

            btnDelete.Text =
                "Delete";

            btnDelete.Location =
                new Point(50, 720);

            btnDelete.Size =
                new Size(150, 50);

            btnDelete.BackColor =
                Color.Crimson;

            btnDelete.ForeColor =
                Color.White;

            btnDelete.FlatStyle =
                FlatStyle.Flat;

            btnDelete.FlatAppearance.BorderSize = 0;

            btnClear.Text =
                "Clear";

            btnClear.Location =
                new Point(250, 720);

            btnClear.Size =
                new Size(150, 50);

            btnClear.BackColor =
                Color.Gray;

            btnClear.ForeColor =
                Color.White;

            btnClear.FlatStyle =
                FlatStyle.Flat;

            btnClear.FlatAppearance.BorderSize = 0;

            // GRID
            dgvCriminals.Location =
                new Point(500, 120);

            dgvCriminals.Size =
                new Size(850, 650);

            dgvCriminals.BackgroundColor =
                Color.White;

            dgvCriminals.BorderStyle =
                BorderStyle.None;

            dgvCriminals.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCriminals.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // ADD CONTROLS
            Controls.Add(lblTitle);

            Controls.Add(lblName);
            Controls.Add(lblAge);
            Controls.Add(lblCrimeType);
            Controls.Add(lblAddress);
            Controls.Add(lblStatus);
            Controls.Add(lblSearch);

            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(txtCrimeType);
            Controls.Add(txtAddress);
            Controls.Add(txtSearch);

            Controls.Add(cmbStatus);

            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);

            Controls.Add(dgvCriminals);

            ((System.ComponentModel.ISupportInitialize)
            (dgvCriminals)).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}