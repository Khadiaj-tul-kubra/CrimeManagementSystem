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
        private Button btnVoice;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btnVoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFIRs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.Location = new Point(62, 38);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(481, 74);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "FIR Management";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.Location = new Point(62, 150);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 29);
            lblName.TabIndex = 2;
            lblName.Text = "Complainant Name";
            // 
            // lblCrimeType
            // 
            lblCrimeType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCrimeType.Location = new Point(62, 262);
            lblCrimeType.Margin = new Padding(4, 0, 4, 0);
            lblCrimeType.Name = "lblCrimeType";
            lblCrimeType.Size = new Size(125, 29);
            lblCrimeType.TabIndex = 4;
            lblCrimeType.Text = "Crime Type";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescription.Location = new Point(62, 375);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(125, 29);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.Location = new Point(62, 612);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(125, 29);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSearch.Location = new Point(650, 62);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(125, 29);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Search FIR";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(62, 188);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(436, 34);
            txtName.TabIndex = 3;
            // 
            // txtCrimeType
            // 
            txtCrimeType.Font = new Font("Segoe UI", 10F);
            txtCrimeType.Location = new Point(62, 300);
            txtCrimeType.Margin = new Padding(4, 4, 4, 4);
            txtCrimeType.Name = "txtCrimeType";
            txtCrimeType.Size = new Size(436, 34);
            txtCrimeType.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(62, 412);
            txtDescription.Margin = new Padding(4, 4, 4, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(436, 149);
            txtDescription.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(812, 62);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(374, 34);
            txtSearch.TabIndex = 15;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Solved" });
            cmbStatus.Location = new Point(62, 650);
            cmbStatus.Margin = new Padding(4, 4, 4, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(436, 36);
            cmbStatus.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(88, 28, 135);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(62, 750);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 62);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save FIR";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(312, 750);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(188, 62);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update FIR";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(62, 850);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 62);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete FIR";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(312, 850);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(188, 62);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvFIRs
            // 
            dgvFIRs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFIRs.BackgroundColor = Color.White;
            dgvFIRs.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFIRs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFIRs.ColumnHeadersHeight = 34;
            dgvFIRs.Font = new Font("Segoe UI", 10F);
            dgvFIRs.Location = new Point(625, 150);
            dgvFIRs.Margin = new Padding(4, 4, 4, 4);
            dgvFIRs.MultiSelect = false;
            dgvFIRs.Name = "dgvFIRs";
            dgvFIRs.RowHeadersWidth = 62;
            dgvFIRs.RowTemplate.Height = 35;
            dgvFIRs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFIRs.Size = new Size(1062, 762);
            dgvFIRs.TabIndex = 16;
            // 
            // btnVoice
            // 
            btnVoice.BackColor = Color.Teal;
            btnVoice.FlatAppearance.BorderSize = 0;
            btnVoice.FlatStyle = FlatStyle.Flat;
            btnVoice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVoice.ForeColor = Color.White;
            btnVoice.Location = new Point(62, 950);
            btnVoice.Margin = new Padding(4, 4, 4, 4);
            btnVoice.Name = "btnVoice";
            btnVoice.Size = new Size(438, 62);
            btnVoice.TabIndex = 0;
            btnVoice.Text = "Voice Report";
            btnVoice.UseVisualStyleBackColor = false;
            // 
            // FIRForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 250);
            ClientSize = new Size(1750, 1000);
            Controls.Add(btnVoice);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "FIRForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FIR Management";
            ((System.ComponentModel.ISupportInitialize)dgvFIRs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}