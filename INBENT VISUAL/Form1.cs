namespace INBENT_VISUAL
{
    public partial class FHasiera : Form
    {
        public FHasiera()
        {
            InitializeComponent();
        }

        private void LErabiltzaailea_Click(object sender, EventArgs e)
        {

        }

        private void BHasiSaioa_Click(object sender, EventArgs e)
        {
            string message = "hola";
            string caption = "proba";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBox.Show(message, caption, buttons);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
