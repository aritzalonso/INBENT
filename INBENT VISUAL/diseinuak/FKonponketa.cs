using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Gailu matxuratu bat konpontzerakoan zabaltzen den leihoa (Formularioa).
    /// Teknikariari konponketa-data eta egindako lanaren azalpena eskatzen dizkio.
    /// </summary>
    public partial class FKonponketa : Form
    {
        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        // Leiho honetan sartutako datuak kanpotik (FNagusia) irakurtzeko propietateak.

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime KonponketaData
        {
            get { return dtpData.Value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Deskribapena
        {
            get { return txtDeskribapena.Text.Trim(); }
        }
        #endregion

        #region ERAIKITZAILEA (CONSTRUCTOR)
        public FKonponketa()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// 'Gorde' botoiaren gertaera (Click). 
        /// Teknikariak konponketaren azalpena idatzi duela ziurtatzen du (balidazioa).
        /// Dena ondo badago, DialogResult.OK seinalea bidaltzen du datu-basean eguneraketa egiteko.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Nahitaezkoa da gailuari zer egin zaion idaztea
            if (string.IsNullOrWhiteSpace(txtDeskribapena.Text))
            {
                MessageBox.Show("Mesedez, idatzi zer egin zaion gailuari konpontzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dena ondo badago, prozesua onartu eta leihoa ixten da
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 'Ezeztatu' botoiaren gertaera (Click).
        /// Prozesua bertan behera uzten du (DialogResult.Cancel) daturik gorde gabe.
        /// </summary>
        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}