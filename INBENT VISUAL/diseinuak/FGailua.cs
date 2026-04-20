using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FGailua : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Mota { get { return cmbMota.Text; } set { cmbMota.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Marka { get { return txtMarka.Text.Trim(); } set { txtMarka.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Gela { get { return txtGela.Text.Trim(); } set { txtGela.Text = value; } }

        // He añadido esta propiedad para poder recuperar y modificar la fecha
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime ErosteData { get { return dtpErosteData.Value; } set { dtpErosteData.Value = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RAM { get { return txtRAM.Text; } set { txtRAM.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ROM { get { return txtROM.Text; } set { txtROM.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CPU { get { return txtCPU.Text; } set { txtCPU.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Koloretakoa { get { return cmbKoloretakoa.Text; } set { cmbKoloretakoa.Text = value; } }

        // CONSTRUCTOR 1: Modo ALTA (Ventana vacía)
        public FGailua()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR 2: Modo ALDATU (Recibe los datos de la tabla y los rellena)
        public FGailua(string mota, string marka, string gela, DateTime data, string ram, string rom, string cpu, string kolore)
        {
            InitializeComponent();

            // Rellenamos los datos comunes
            this.Mota = mota;
            this.Marka = marka;
            this.Gela = gela;
            this.ErosteData = data;

            // Bloqueamos el tipo para que no puedan convertir una impresora en ordenador
            cmbMota.Enabled = false;

            // Rellenamos los paneles específicos y los mostramos según toque
            if (mota == "Ordenagailua")
            {
                this.RAM = ram;
                this.ROM = rom;
                this.CPU = cpu;
                pnlOrdenagailua.Visible = true;
                pnlInprimagailua.Visible = false;
            }
            else if (mota == "Inprimagailua")
            {
                this.Koloretakoa = kolore;
                pnlOrdenagailua.Visible = false;
                pnlInprimagailua.Visible = true;
            }
        }

        private void cmbMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMota.Text == "Ordenagailua")
            {
                pnlOrdenagailua.Visible = true;
                pnlInprimagailua.Visible = false;
            }
            else if (cmbMota.Text == "Inprimagailua")
            {
                pnlOrdenagailua.Visible = false;
                pnlInprimagailua.Visible = true;
            }
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (cmbMota.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Mesedez, bete oinarrizko datuak (Mota eta Marka gutxienez).", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
