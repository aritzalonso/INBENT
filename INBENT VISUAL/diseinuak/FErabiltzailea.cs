using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FErabiltzailea : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Izena
        {
            get { return txtIzena.Text.Trim(); }
            set { txtIzena.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Pasahitza
        {
            get { return txtPasahitza.Text.Trim(); }
            set { txtPasahitza.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Rola
        {
            get { return cmbRola.Text; }
            set { cmbRola.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Mintegia
        {
            get { return cmbMintegia.Text; }
            set { cmbMintegia.Text = value; }
        }

        // CONSTRUCTOR 1: Modo "ALTA" (Ventana vacía)
        public FErabiltzailea()
        {
            InitializeComponent();
            KargatuMintegiakDesplegablera();
        }

        // CONSTRUCTOR 2: Modo "ALDATU" (Recibe los datos y los rellena)
        public FErabiltzailea(string izena, string pasahitza, string rola, string mintegia)
        {
            InitializeComponent();
            KargatuMintegiakDesplegablera();

            // Rellenamos las cajas con los datos del usuario seleccionado
            this.Izena = izena;
            this.Pasahitza = pasahitza;
            this.Rola = rola;
            this.Mintegia = mintegia;
        }

        private void KargatuMintegiakDesplegablera()
        {
            cmbMintegia.Items.Clear();
            Mintegi_Kudeatzailea mintegiMotorra = new Mintegi_Kudeatzailea();
            var mintegiak = mintegiMotorra.MintegiakErakutsi();

            foreach (var m in mintegiak)
            {
                cmbMintegia.Items.Add(m.Izena);
            }

            if (cmbMintegia.Items.Count > 0 && string.IsNullOrEmpty(this.Mintegia))
            {
                cmbMintegia.SelectedIndex = 0;
            }
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) ||
                string.IsNullOrWhiteSpace(txtPasahitza.Text) ||
                cmbRola.SelectedIndex == -1)
            {
                MessageBox.Show("Mesedez, bete itzazu ezinbesteko datuak (Izena, Pasahitza eta Rola).",
                                "Datu falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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