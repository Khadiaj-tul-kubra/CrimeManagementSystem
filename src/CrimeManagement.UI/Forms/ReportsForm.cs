using CrimeManagement.UI.Data;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CrimeManagement.UI.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            LoadReports();

            btnExportPdf.Click +=
                btnExportPdf_Click;
        }

        // LOAD REPORTS
        private void LoadReports()
        {
            using var context =
                new AppDbContext();

            dgvReports.DataSource =
                context.FIRs.ToList();
        }

        // EXPORT PDF
        private void btnExportPdf_Click(
            object? sender,
            EventArgs e)
        {
            SaveFileDialog save =
                new SaveFileDialog();

            save.Filter =
                "PDF File|*.pdf";

            save.Title =
                "Save PDF Report";

            save.FileName =
                "FIR_Report.pdf";

            if (save.ShowDialog()
                == DialogResult.OK)
            {
                Document document =
                    new Document();

                PdfWriter.GetInstance(
                    document,
                    new FileStream(
                        save.FileName,
                        FileMode.Create));

                document.Open();

                Paragraph title =
                    new Paragraph(
                        "Crime Management System Reports");

                title.Alignment =
                    Element.ALIGN_CENTER;

                title.SpacingAfter = 20f;

                document.Add(title);

                PdfPTable table =
                    new PdfPTable(
                        dgvReports.Columns.Count);

                // HEADERS
                foreach (
                    DataGridViewColumn column
                    in dgvReports.Columns)
                {
                    table.AddCell(
                        column.HeaderText);
                }

                // ROWS
                foreach (
                    DataGridViewRow row
                    in dgvReports.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (
                            DataGridViewCell cell
                            in row.Cells)
                        {
                            table.AddCell(
                                cell.Value?
                                .ToString());
                        }
                    }
                }

                document.Add(table);

                document.Close();

                MessageBox.Show(
                    "PDF Exported Successfully");
            }
        }
    }
}