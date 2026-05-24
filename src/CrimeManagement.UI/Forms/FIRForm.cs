using CrimeManagement.UI.Data;
using CrimeManagement.UI.Models;

namespace CrimeManagement.UI.Forms
{
    public partial class FIRForm : Form
    {
        private int selectedId = 0;

        public FIRForm()
        {
            InitializeComponent();

            LoadFIRs();

            dgvFIRs.CellClick += dgvFIRs_CellClick;

            txtSearch.TextChanged += txtSearch_TextChanged;

            btnSave.Click += btnSave_Click;

            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click += btnDelete_Click;

            btnClear.Click += btnClear_Click;
        }

        // SAVE FIR
        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            FIR fir = new FIR()
            {
                ComplainantName =
                    txtName.Text,

                CrimeType =
                    txtCrimeType.Text,

                Description =
                    txtDescription.Text,

                Status =
                    cmbStatus.Text
            };

            context.FIRs.Add(fir);

            context.SaveChanges();

            MessageBox.Show(
                "FIR Saved Successfully");

            LoadFIRs();

            ClearFields();
        }

        // LOAD ALL FIRS
        private void LoadFIRs()
        {
            using var context =
                new AppDbContext();

            dgvFIRs.DataSource =
                context.FIRs.ToList();
        }

        // GRID SELECT
        private void dgvFIRs_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvFIRs.Rows[e.RowIndex];

                selectedId =
                    Convert.ToInt32(
                        row.Cells["Id"].Value);

                txtName.Text =
                    row.Cells["ComplainantName"]
                    .Value.ToString();

                txtCrimeType.Text =
                    row.Cells["CrimeType"]
                    .Value.ToString();

                txtDescription.Text =
                    row.Cells["Description"]
                    .Value.ToString();

                cmbStatus.Text =
                    row.Cells["Status"]
                    .Value.ToString();
            }
        }

        // UPDATE FIR
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            var fir =
                context.FIRs.Find(selectedId);

            if (fir != null)
            {
                fir.ComplainantName =
                    txtName.Text;

                fir.CrimeType =
                    txtCrimeType.Text;

                fir.Description =
                    txtDescription.Text;

                fir.Status =
                    cmbStatus.Text;

                context.SaveChanges();

                MessageBox.Show(
                    "FIR Updated Successfully");

                LoadFIRs();

                ClearFields();
            }
        }

        // DELETE FIR
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (dgvFIRs.SelectedRows.Count > 0)
            {
                int id =
                    Convert.ToInt32(
                        dgvFIRs.SelectedRows[0]
                        .Cells["Id"].Value);

                using var context =
                    new AppDbContext();

                var fir =
                    context.FIRs.Find(id);

                if (fir != null)
                {
                    DialogResult result =
                        MessageBox.Show(
                            "Are you sure?",
                            "Delete FIR",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        context.FIRs.Remove(fir);

                        context.SaveChanges();

                        MessageBox.Show(
                            "FIR Deleted");

                        LoadFIRs();

                        ClearFields();
                    }
                }
            }
        }

        // SEARCH FIR
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            dgvFIRs.DataSource =
                context.FIRs
                .Where(x =>
                    x.ComplainantName.Contains(
                        txtSearch.Text)
                    ||
                    x.CrimeType.Contains(
                        txtSearch.Text)
                    ||
                    x.Status.Contains(
                        txtSearch.Text))
                .ToList();
        }

        // CLEAR FIELDS
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        // RESET FORM
        private void ClearFields()
        {
            txtName.Clear();

            txtCrimeType.Clear();

            txtDescription.Clear();

            cmbStatus.SelectedIndex = -1;

            selectedId = 0;
        }
    }
}