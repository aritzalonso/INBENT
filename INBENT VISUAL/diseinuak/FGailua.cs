using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FGailua : Form
    {
        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        // Propietate amankomunak (Gailua)
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Mota { get { return cmbMota.Text; } set { cmbMota.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Marka { get { return txtMarka.Text.Trim(); } set { txtMarka.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Gela { get { return txtGela.Text.Trim(); } set { txtGela.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime ErosteData { get { return dtpErosteData.Value; } set { dtpErosteData.Value = value; } }

        // Ordenagailuaren propietate espezifikoak
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RAM { get { return txtRAM.Text; } set { txtRAM.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ROM { get { return txtROM.Text; } set { txtROM.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CPU { get { return txtCPU.Text; } set { txtCPU.Text = value; } }

        // Inprimagailuaren propietate espezifikoa
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Koloretakoa { get { return cmbKoloretakoa.Text; } set { cmbKoloretakoa.Text = value; } }
        #endregion

        #region ERAIKITZAILEAK (CONSTRUCTORES)
        /// <summary>
        /// 1. ERAIKITZAILEA: "ALTA" modua. Gailu berri bat sortzeko leihoa (hutsik).
        /// </summary>
        public FGailua()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 2. ERAIKITZAILEA: "ALDATU" modua. Datuak jasotzen ditu eta form-a betetzen du.
        /// </summary>
        public FGailua(string mota, string marka, string gela, DateTime data, string ram, string rom, string cpu, string kolore)
        {
            InitializeComponent();

            // Datu amankomunak betetzen ditugu
            this.Mota = mota;
            this.Marka = marka;
            this.Gela = gela;
            this.ErosteData = data;

            // Gailu mota blokeatzen dugu (Ezin da inprimagailu bat ordenagailu bihurtu)
            cmbMota.Enabled = false;

            // Gailu motaren arabera (Polimorfismoa), panel bat edo bestea erakusten dugu
            if (mota == "Ordenagailua")
            {
                this.RAM = ram;
                this.ROM = rom;
                this.CPU = cpu;
                pnlOrdenagailua.Visible = true;
                pnlInprimagailua.Visible = false;
            }
            else if (mota == "Inprimagailua")
            {
                this.Koloretakoa = kolore;
                pnlOrdenagailua.Visible = false;
                pnlInprimagailua.Visible = true;
            }
        }
        #endregion

        #region INTERFAZEAREN EKINTZAK (EVENTOS DE UI)
        /// <summary>
        /// Erabiltzaileak gailu mota aldatzean, panel zuzena erakusten du.
        /// </summary>
        private void cmbMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMota.Text == "Ordenagailua")
            {
                pnlOrdenagailua.Visible = true;
                pnlInprimagailua.Visible = false;
            }
            else if (cmbMota.Text == "Inprimagailua")
            {
                pnlOrdenagailua.Visible = false;
                pnlInprimagailua.Visible = true;
            }
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS DE BOTONES)
        /// <summary>
        /// Gorde botoia: Oinarrizko datuak beteta daudela balidatzen du.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (cmbMota.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Mesedez, bete oinarrizko datuak (Mota eta Marka gutxienez).", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Ezeztatu botoia: Prozesua ixten du ezer gorde gabe.
        /// </summary>
        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}