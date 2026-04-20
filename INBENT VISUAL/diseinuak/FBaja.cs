using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FBaja : Form
    {
        #region PROPIETATEAK (POO)
        // Informatikariak idatzitako testua gordeko duen propietatea.
        // Honi esker, FNagusia-k testu hau irakurri dezake objektu gisa.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Arrazoia
        {
            get { return txtDeskribapena.Text.Trim(); }
        }
        #endregion

        #region ERAIKITZAILEA (CONSTRUCTOR)
        public FBaja()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// Gorde botoia sakatzean exekutatzen da. 
        /// Testu-kutxa hutsik ez dagoela ziurtatzen du.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Nahitaezkoa da arrazoi bat idaztea baja emateko
            if (string.IsNullOrWhiteSpace(txtDeskribapena.Text))
            {
                MessageBox.Show("Mesedez, idatzi baja emateko arrazoia.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dena ondo badago, leihoak "OK" seinalea bidaltzen du eta ixten da
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Ezeztatu botoia sakatzean exekutatzen da.
        /// Prozesua bertan behera utzi eta leihoa ixten du.
        /// </summary>
        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            // "Cancel" seinalea bidaltzen du ezer gorde gabe
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}