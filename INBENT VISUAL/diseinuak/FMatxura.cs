using System;
using System.Windows.Forms;
using System.ComponentModel;
using INBENT_VISUAL.Entitateak;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Gailu baten matxura berria erregistratzeko erabiltzen den leihoa (Formularioa).
    /// Erabiltzaileari arazoaren deskribapena eta data eskatzen dizkio.
    /// </summary>
    public partial class FMatxura : Form
    {
        #region ALDAGAI OROKORRAK
        private int idSekretua;
        #endregion

        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
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
        /// Leihoan sartutako datuekin Matxura objektu berri bat sortu eta itzultzen du, 
        /// Kudeatzailearen bidez datu-basean zuzenean gordetzeko prest.
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
        /// Matxura leihoa hasieratzen du, matxuratu den gailuaren datuak kargatuz.
        /// </summary>
        /// <param name="idGailua">Matxuratu den gailuaren identifikatzailea.</param>
        /// <param name="gailuInfo">Gailuaren informazioa (marka eta gela) interfazean erakusteko.</param>
        public FMatxura(int idGailua, string gailuInfo)
        {
            InitializeComponent();
            this.idSekretua = idGailua;

            cmbGailua.DataSource = null;
            cmbGailua.Items.Clear();
            cmbGailua.Items.Add(gailuInfo);
            cmbGailua.SelectedIndex = 0;

            cmbGailua.Enabled = false;
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// 'Gorde' botoiaren gertaera (Click). 
        /// Matxuraren azalpena idatzita dagoela balidatzen du eta, dena zuzen badago, 
        /// DialogResult.OK seinalea bidaltzen du.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeskribapena.Text))
            {
                MessageBox.Show("Mesedez, idatzi matxuraren deskribapena.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}