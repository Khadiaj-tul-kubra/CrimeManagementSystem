namespace CrimeManagement.UI.Forms
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Button btnDarkMode;

        private Button btnLightMode;

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

            btnDarkMode = new Button();

            btnLightMode = new Button();

            SuspendLayout();

            // FORM
            BackColor =
                Color.White;

            ClientSize =
                new Size(500, 350);

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Settings";

            // TITLE
            lblTitle.Text =
                "Application Settings";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22,
                    FontStyle.Bold);

            lblTitle.Location =
                new Point(60, 40);

            lblTitle.AutoSize = true;

            // DARK BUTTON
            btnDarkMode.Text =
                "Enable Dark Mode";

            btnDarkMode.Location =
                new Point(120, 140);

            btnDarkMode.Size =
                new Size(250, 50);

            btnDarkMode.BackColor =
                Color.Black;

            btnDarkMode.ForeColor =
                Color.White;

            btnDarkMode.FlatStyle =
                FlatStyle.Flat;

            btnDarkMode.FlatAppearance.BorderSize = 0;

            btnDarkMode.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // LIGHT BUTTON
            btnLightMode.Text =
                "Enable Light Mode";

            btnLightMode.Location =
                new Point(120, 220);

            btnLightMode.Size =
                new Size(250, 50);

            btnLightMode.BackColor =
                Color.Gainsboro;

            btnLightMode.ForeColor =
                Color.Black;

            btnLightMode.FlatStyle =
                FlatStyle.Flat;

            btnLightMode.FlatAppearance.BorderSize = 0;

            btnLightMode.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            // ADD CONTROLS
            Controls.Add(lblTitle);

            Controls.Add(btnDarkMode);

            Controls.Add(btnLightMode);

            ResumeLayout(false);

            PerformLayout();
        }
    }
}