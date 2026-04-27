using System;
using System.Windows.Forms;
using INBENT_VISUAL.Kudeatzaileak;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Erabiltzailearen profilaren informazioa erakusten duen leihoa.
    /// Hemendik pasahitza aldatzeko aukera ere badu.
    /// </summary>
    public partial class FProfila : Form
    {
        private string erabiltzaileIzena;

        public FProfila(string izena, string rola, string mintegia)
        {
            InitializeComponent();
            this.erabiltzaileIzena = izena;

            // Datuak interfazean kargatu
            lblIzenaData.Text = izena;
            lblRolaData.Text = rola;
            lblMintegiaData.Text = mintegia;
        }

        private void btnAldatuPasahitza_Click(object sender, EventArgs e)
        {
            // Aurreko pausoan sortu genuen leihoa berrerabiltzen dugu!
            using (FPasahitzaAldatu leihoa = new FPasahitzaAldatu())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                    if (kudeatzailea.AldatuPasahitza(this.erabiltzaileIzena, leihoa.PasahitzBerria))
                    {
                        MessageBox.Show("Pasahitza ondo aldatu da! Mesedez, gogoratu hurrengoan sartzeko.", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}