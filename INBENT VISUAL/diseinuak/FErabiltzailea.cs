using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FErabiltzailea : Form
    {
        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        // Propietate hauek leihoaren barruko datuak kanpotik (FNagusia) irakurtzeko aukera ematen dute.

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Izena
        {
            get { return txtIzena.Text.Trim(); }
            set { txtIzena.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Pasahitza
        {
            get { return txtPasahitza.Text.Trim(); }
            set { txtPasahitza.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Rola
        {
            get { return cmbRola.Text; }
            set { cmbRola.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Mintegia
        {
            get { return cmbMintegia.Text; }
            set { cmbMintegia.Text = value; }
        }
        #endregion

        #region ERAIKITZAILEAK (CONSTRUCTORES)
        /// <summary>
        /// 1. ERAIKITZAILEA: "ALTA" modua. Leihoa hutsik irekitzen da erabiltzaile berri bat sortzeko.
        /// </summary>
        public FErabiltzailea()
        {
            InitializeComponent();
            KargatuMintegiakDesplegablera();
        }

        /// <summary>
        /// 2. ERAIKITZAILEA: "ALDATU" modua. Datuak jasotzen ditu eta testu-kutxetan kargatzen ditu.
        /// </summary>
        public FErabiltzailea(string izena, string pasahitza, string rola, string mintegia)
        {
            InitializeComponent();
            KargatuMintegiakDesplegablera();

            // Leihoaren datuak betetzen ditugu jasotako informazioarekin
            this.Izena = izena;
            this.Pasahitza = pasahitza;
            this.Rola = rola;
            this.Mintegia = mintegia;
        }
        #endregion

        #region DATUAK KARGATZEA
        /// <summary>
        /// Datu-basetik mintegiak irakurri eta ComboBox-ean (desplegablean) kargatzen ditu objektu gisa.
        /// </summary>
        private void KargatuMintegiakDesplegablera()
        {
            cmbMintegia.Items.Clear();
            Mintegi_Kudeatzailea mintegiMotorra = new Mintegi_Kudeatzailea();

            // POO: Objektuen zerrenda jasotzen dugu
            var mintegiak = mintegiMotorra.MintegiakErakutsiPOO();

            foreach (var m in mintegiak)
            {
                cmbMintegia.Items.Add(m.Izena);
            }

            // Bat bera ere aukeratuta ez badago, lehenengoa jartzen dugu modu lehenetsian
            if (cmbMintegia.Items.Count > 0 && string.IsNullOrEmpty(this.Mintegia))
            {
                cmbMintegia.SelectedIndex = 0;
            }
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// Gorde botoia: Datuen balidazioa egiten du dena ondo beteta dagoela ziurtatzeko.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) ||
                string.IsNullOrWhiteSpace(txtPasahitza.Text) ||
                cmbRola.SelectedIndex == -1)
            {
                MessageBox.Show("Mesedez, bete itzazu ezinbesteko datuak (Izena, Pasahitza eta Rola).",
                                "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Ezeztatu botoia: Prozesua bertan behera uzten du ezer gorde gabe.
        /// </summary>
        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}