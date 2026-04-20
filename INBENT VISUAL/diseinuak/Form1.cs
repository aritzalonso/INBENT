using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class Form1 : Form
    {
        // El Login empieza vacío, sin pedir roles
        public Form1()
        {
            InitializeComponent();
        }

        // El botón para entrar



        // El botón para salir
        private void BIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- DEJAMOS ESTOS EVENTOS VACÍOS PARA QUE EL DESIGNER NO DE ERROR ---
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e) { }
        private void FHasiera_Load(object sender, EventArgs e) { }
       

        private void BSaioa_Click_1(object sender, EventArgs e)
        {
            string izena = txtIzena.Text.Trim();
            string pasahitza = txtPasahitza.Text.Trim();

            if (string.IsNullOrWhiteSpace(izena) || string.IsNullOrWhiteSpace(pasahitza))
            {
                MessageBox.Show("Mesedez, sartu erabiltzailea eta pasahitza.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
            string rola = kudeatzailea.EgiaztatuLogin(izena, pasahitza);

            if (rola != null)
            {
                this.Hide();

                // ¡Aquí es donde engancha con tu FHasiera!
                FHasiera pantailaNagusia = new FHasiera(izena, rola);
                pantailaNagusia.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Erabiltzailea edo pasahitza ez dira zuzenak.", "Sarrera ukatuta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasahitza.Clear();
                txtPasahitza.Focus();
            }
        }
    }
}