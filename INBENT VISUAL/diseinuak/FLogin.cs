using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Aplikazioaren sarrera-pantaila (Login). Erabiltzaileak identifikatzeko eta 
    /// dagozkion baimen zein mintegiekin pantaila nagusia (FNagusia) irekitzeko ardura du.
    /// </summary>
    public partial class FLogin : Form
    {
        #region ERAIKITZAILEA (CONSTRUCTOR)
        /// <summary>
        /// Login leihoa hasieratzen du.
        /// </summary>
        public FLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// 'Saioa Hasi' botoiaren gertaera (Click).
        /// Erabiltzaileak sartutako kredentzialak irakurtzen ditu, datu-basearen aurka 
        /// balidatzen ditu (Erabiltzaile_kudeaketa erabiliz), eta zuzenak badira, 
        /// dagokion rola eta mintegiarekin pantaila nagusia (FNagusia) irekitzen du.
        /// </summary>
        private void BSaioa_Click_1(object sender, EventArgs e)
        {
            string izena = txtIzena.Text.Trim();
            string pasahitza = txtPasahitza.Text.Trim();

            // 1. Datuak hutsik ez daudela ziurtatzen dugu
            if (string.IsNullOrWhiteSpace(izena) || string.IsNullOrWhiteSpace(pasahitza))
            {
                MessageBox.Show("Mesedez, sartu erabiltzailea eta pasahitza.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. POO: Kudeatzaileari deitzen diogu datu-basearekin hitz egin dezan
            Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
            string rola = kudeatzailea.EgiaztatuLogin(izena, pasahitza);

            // 3. Erantzunaren arabera sartu edo errorea eman
            if (rola != null)
            {
                // BERRIA: Mintegia lortzen dugu (Erabiltzaile_kudeaketa.cs barruan LortuMintegia funtzioa sortu beharko duzu horretarako, 'rola' lortu duzun modu berean)
                string mintegia = kudeatzailea.LortuMintegia(izena);

                this.Hide(); // Login leihoa ezkutatzen dugu

                // Pantaila nagusia ireki, erabiltzailearen izena, rola ETA mintegia pasatuz
                FNagusia pantailaNagusia = new FNagusia(izena, rola, mintegia);
                pantailaNagusia.ShowDialog();

                this.Close(); // Pantaila nagusia ixtean, aplikazio osoa itxi
            }
            else
            {
                MessageBox.Show("Erabiltzailea edo pasahitza ez dira zuzenak.", "Sarrera ukatuta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasahitza.Clear();
                txtPasahitza.Focus();
            }
        }

        private void BIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region EKINTZA HUTSAK (EVENTOS VACÍOS)
        // Diseinatzaileak (Designer) errorerik ez emateko, ekintza hauek mantentzen ditugu
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e) { }
        private void FHasiera_Load(object sender, EventArgs e) { }
        #endregion
    }
}