using System;
using System.Windows.Forms;
using System.ComponentModel;
using INBENT_VISUAL.Entitateak; // Matxura klasea erabiltzeko beharrezkoa

namespace INBENT_VISUAL.diseinuak
{
    public partial class FMatxura : Form
    {
        #region ALDAGAI OROKORRAK (VARIABLES PRIVADAS)
        private int idSekretua; // Interfazean erakutsi gabe gailuaren ID-a gordetzeko
        #endregion

        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        // Leihoan dauden datu zehatzak kanpotik (FNagusia) irakurtzeko propietateak

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdGailuAukeratua { get { return idSekretua; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime MatxuraData { get { return dtpData.Value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Deskribapena { get { return txtDeskribapena.Text.Trim(); } }

        /// <summary>
        /// PROPIETATE AURRERATUA (POO):
        /// Kaxetan dauden datuekin "Matxura" objektu berri bat zuzenean sortu eta itzultzen du.
        /// Horrela, FNagusia-k zuzenean bidali diezaioke Kudeatzaileari.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Matxura MatxuraBerria
        {
            get
            {
                return new Matxura
                {
                    IdGailua = this.idSekretua,
                    MatxuraData = dtpData.Value,
                    Deskribapena = txtDeskribapena.Text.Trim()
                };
            }
        }
        #endregion

        #region ERAIKITZAILEA (CONSTRUCTOR)
        /// <summary>
        /// Leihoa hasieratzen du, matxuratutako gailuaren ID-a ezkutuan gordez eta izena erakutsiz.
        /// </summary>
        public FMatxura(int idGailua, string gailuInfo)
        {
            InitializeComponent();
            this.idSekretua = idGailua;

            // Desplegablea estetikoki prestatzen dugu, soilik aukeratutako gailua erakutsiz
            cmbGailua.DataSource = null;
            cmbGailua.Items.Clear();
            cmbGailua.Items.Add(gailuInfo);
            cmbGailua.SelectedIndex = 0;

            // Blokeatu egiten dugu erabiltzaileak beste gailu bat hauta ez dezan
            cmbGailua.Enabled = false;
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// Gorde botoia: Matxuraren azalpena idatzita dagoela balidatzen du.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Nahitaezkoa da matxurari buruzko zehaztasunak ematea
            if (string.IsNullOrWhiteSpace(txtDeskribapena.Text))
            {
                MessageBox.Show("Mesedez, idatzi matxuraren deskribapena.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dena ondo badago, onartu seinalea bidali eta leihoa ixten da
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Ezeztatu botoia: Erregistroa bertan behera utzi eta ixten da.
        /// </summary>
        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}