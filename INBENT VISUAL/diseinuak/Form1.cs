namespace INBENT_VISUAL
{
    public partial class FHasiera : Form
    {
        public FHasiera()
        {
            InitializeComponent();
        }

        private void BSaioa_Click(object sender, EventArgs e)
        {
            string erabiltzailea = TErabiltzailea.Text?.Trim() ?? string.Empty;
            string pasahitza = TPasahitza.Text ?? string.Empty;

            if (string.IsNullOrEmpty(erabiltzailea))
            {
                MessageBox.Show("Sartu erabiltzailea.", "Abisua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TErabiltzailea.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pasahitza))
            {
                MessageBox.Show("Sartu pasahitza.", "Abisua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TPasahitza.Focus();
                return; 
            }

            if (erabiltzailea == "admin" && pasahitza == "password")
            {
                MessageBox.Show($"Ongi etorri, {erabiltzailea}.", "Saioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erabiltzailea edo pasahitza okerra.", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TPasahitza.Clear();
                TErabiltzailea.Focus();
            }
        }

        private void BIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}