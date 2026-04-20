using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FMintegia : Form
    {
        // Esta variable guardará el texto para enviarlo a la Base de Datos luego
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string MintegiIzena
        {
            get { return txtIzena.Text.Trim(); }
            set { txtIzena.Text = value; }
        }

        public FMintegia()
        {
            InitializeComponent();
        }

        // Acción al pulsar 💾 Gorde
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

        // Acción al pulsar ❌ Ezeztatu
        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}