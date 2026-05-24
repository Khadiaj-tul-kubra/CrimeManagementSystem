using CrimeManagement.UI.Data;
using CrimeManagement.UI.Models;
using System.Xml.Linq;

namespace CrimeManagement.UI.Forms
{
    public partial class CriminalForm : Form
    {
        private int selectedId = 0;

        public CriminalForm()
        {
            InitializeComponent();

            LoadCriminals();

            dgvCriminals.CellClick +=
                dgvCriminals_CellClick;

            txtSearch.TextChanged +=
                txtSearch_TextChanged;

            btnSave.Click += btnSave_Click;

            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click += btnDelete_Click;

            btnClear.Click += btnClear_Click;
        }

        // SAVE
        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            Criminal criminal =
                new Criminal()
                {
                    CriminalName =
                        txtName.Text,

                    Age =
                        Convert.ToInt32(
                            txtAge.Text),

                    CrimeType =
                        txtCrimeType.Text,

                    Address =
                        txtAddress.Text,

                    Status =
                        cmbStatus.Text
                };

            context.Criminals.Add(
                criminal);

            context.SaveChanges();

            MessageBox.Show(
                "Criminal Record Saved");

            LoadCriminals();

            ClearFields();
        }

        // LOAD
        private void LoadCriminals()
        {
            using var context =
                new AppDbContext();

            dgvCriminals.DataSource =
                context.Criminals.ToList();
        }

        // GRID SELECT
        private void dgvCriminals_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCriminals.Rows[e.RowIndex];

                selectedId =
                    Convert.ToInt32(
                        row.Cells["Id"].Value);

                txtName.Text =
                    row.Cells["CriminalName"]
                    .Value.ToString();

                txtAge.Text =
                    row.Cells["Age"]
                    .Value.ToString();

                txtCrimeType.Text =
                    row.Cells["CrimeType"]
                    .Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"]
                    .Value.ToString();

                cmbStatus.Text =
                    row.Cells["Status"]
                    .Value.ToString();
            }
        }

        // UPDATE
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            var criminal =
                context.Criminals.Find(
                    selectedId);

            if (criminal != null)
            {
                criminal.CriminalName =
                    txtName.Text;

                criminal.Age =
                    Convert.ToInt32(
                        txtAge.Text);

                criminal.CrimeType =
                    txtCrimeType.Text;

                criminal.Address =
                    txtAddress.Text;

                criminal.Status =
                    cmbStatus.Text;

                context.SaveChanges();

                MessageBox.Show(
                    "Record Updated");

                LoadCriminals();

                ClearFields();
            }
        }

        // DELETE
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (dgvCriminals.SelectedRows
                .Count > 0)
            {
                int id =
                    Convert.ToInt32(
                        dgvCriminals
                        .SelectedRows[0]
                        .Cells["Id"].Value);

                using var context =
                    new AppDbContext();

                var criminal =
                    context.Criminals
                    .Find(id);

                if (criminal != null)
                {
                    context.Criminals
                        .Remove(criminal);

                    context.SaveChanges();

                    MessageBox.Show(
                        "Record Deleted");

                    LoadCriminals();

                    ClearFields();
                }
            }
        }

        // SEARCH
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            using var context =
                new AppDbContext();

            dgvCriminals.DataSource =
                context.Criminals
                .Where(x =>
                    x.CriminalName
                    .Contains(
                        txtSearch.Text)
                    ||
                    x.CrimeType
                    .Contains(
                        txtSearch.Text))
                .ToList();
        }

        // CLEAR
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearFields();
        }

        // RESET
        private void ClearFields()
        {
            txtName.Clear();

            txtAge.Clear();

            txtCrimeType.Clear();

            txtAddress.Clear();

            cmbStatus.SelectedIndex = -1;

            selectedId = 0;
        }
    }
}