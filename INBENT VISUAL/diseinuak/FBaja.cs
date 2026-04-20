using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FBaja : Form
    {
        // Esta variable guardará el texto que escriba el informático
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Arrazoia { get { return txtDeskribapena.Text.Trim(); } }

        public FBaja()
        {
            InitializeComponent();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Obligamos a escribir un motivo sí o sí
            if (string.IsNullOrWhiteSpace(txtDeskribapena.Text))
            {
                MessageBox.Show("Mesedez, idatzi baja emateko arrazoia.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
