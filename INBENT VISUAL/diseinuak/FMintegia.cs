using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Mintegi berri bat sortzeko erabiltzen den leihoa (Formularioa).
    /// Erabiltzaileari mintegiaren izena eskatzen dio.
    /// </summary>
    public partial class FMintegia : Form
    {
        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        /// <summary>
        /// Leihoan idatzitako mintegiaren izena lortzeko edo ezartzeko propietatea, 
        /// FNagusia-tik zuzenean irakurri ahal izateko.
        /// </summary>
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
        /// Mintegiaren leihoa hasieratzen du.
        /// </summary>
        public FMintegia()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS)
        /// <summary>
        /// 'Gorde' botoiaren gertaera (Click). 
        /// Mintegiaren izena hutsik ez dagoela balidatzen du. Zuzen badago, 
        /// DialogResult.OK seinalea bidaltzen du aplikazio nagusira.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text))
            {
                MessageBox.Show("Mesedez, idatzi mintegiaren izena.", "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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