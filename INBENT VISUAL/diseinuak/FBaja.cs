using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Gailu bati baja ematerakoan zabaltzen den leiho txikia (Formularioa).
    /// Erabiltzaileari baja emateko arrazoia eskatzen dio prozesua amaitu aurretik.
    /// </summary>
    public partial class FBaja : Form
    {
        #region PROPIETATEAK (POO)
        /// <summary>
        /// Erabiltzaileak testu-kutxan idatzitako baja-arrazoia itzultzen du.
        /// Honi esker, FNagusia-k testu hau irakurri dezake leihoa itxi ondoren.
        /// </summary>
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
        /// 'Gorde' botoiaren gertaera (Click). 
        /// Testu-kutxa hutsik ez dagoela balidatzen du. Dena zuzen badago, 
        /// DialogResult.OK seinalea bidali eta leihoa ixten du.
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
        /// 'Ezeztatu' botoiaren gertaera (Click).
        /// Prozesua bertan behera uzten du (DialogResult.Cancel) daturik gorde gabe.
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