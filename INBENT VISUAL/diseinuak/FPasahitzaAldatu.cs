using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Erabiltzaileari pasahitza modu seguruan aldatzeko aukera ematen dion leihoa.
    /// Pasahitza bi aldiz idaztea eskatzen du akatsak ekiditeko.
    /// </summary>
    public partial class FPasahitzaAldatu : Form
    {
        #region PROPIETATEAK
        /// <summary>
        /// Erabiltzaileak sartutako pasahitz berria itzultzen du (balidazioak gainditu ondoren).
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PasahitzBerria
        {
            get { return txtPasahitza.Text.Trim(); }
        }
        #endregion

        #region ERAIKITZAILEA
        public FPasahitzaAldatu()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTOIEN EKINTZAK
        /// <summary>
        /// Gorde botoiaren gertaera. Eremuak beteta daudela eta bi pasahitzak 
        /// bat datozela ziurtatzen du.
        /// </summary>
        private void btnOnartu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasahitza.Text) || string.IsNullOrWhiteSpace(txtKonfirmatu.Text))
            {
                MessageBox.Show("Mesedez, bete bi eremuak.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPasahitza.Text != txtKonfirmatu.Text)
            {
                MessageBox.Show("Pasahitzak ez datoz bat. Saiatu berriro.", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasahitza.Clear();
                txtKonfirmatu.Clear();
                txtPasahitza.Focus();
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