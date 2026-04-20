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
    public partial class FKonponketa : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime KonponketaData { get { return dtpData.Value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Deskribapena { get { return txtDeskribapena.Text.Trim(); } }

        public FKonponketa()
        {
            InitializeComponent();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            // Obligamos al técnico a escribir qué le ha hecho al ordenador
            if (string.IsNullOrWhiteSpace(txtDeskribapena.Text))
            {
                MessageBox.Show("Mesedez, idatzi zer egin zaion gailuari konpontzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
