using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FMatxura : Form
    {
        private int idSekretua; // Aquí guardaremos el ID que nos pasan desde la tabla

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdGailuAukeratua { get { return idSekretua; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime MatxuraData { get { return dtpData.Value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Deskribapena { get { return txtDeskribapena.Text.Trim(); } }

        // NUEVO CONSTRUCTOR: Recibe el ID y el texto para mostrar
        public FMatxura(int idGailua, string gailuInfo)
        {
            InitializeComponent();
            this.idSekretua = idGailua;

            // TRUCO: Quitamos la conexión a la base de datos del desplegable
            cmbGailua.DataSource = null;
            cmbGailua.Items.Clear();

            // Le metemos a mano el texto del ordenador seleccionado
            cmbGailua.Items.Add(gailuInfo);
            cmbGailua.SelectedIndex = 0;

            // ¡Lo bloqueamos para que no se pueda cambiar!
            cmbGailua.Enabled = false;
        }

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
    }
}