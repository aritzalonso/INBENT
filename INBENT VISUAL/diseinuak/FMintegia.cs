using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FMintegia : Form
    {
        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        // Kaxan idatzitako testua gordetzen duen propietatea.
        // Honi esker, FNagusia-k mintegiaren izena irakurri dezake.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MintegiIzena
        {
            get { return txtIzena.Text.Trim(); }
            set { txtIzena.Text = value; }
        }
        #endregion

        #region ERAIKITZAILEA (CONSTRUCTOR)
        /// <summary>
        /// Mintegia sortzeko leihoa hasieratzen du.
        /// </summary>
        public FMintegia()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// Gorde botoia: Mintegiaren izena hutsik ez dagoela ziurtatzen du.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Nahitaezkoa da mintegiari izen bat jartzea
            if (string.IsNullOrWhiteSpace(txtIzena.Text))
            {
                MessageBox.Show("Mesedez, idatzi mintegiaren izena.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dena ondo badago, onartu eta itxi
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