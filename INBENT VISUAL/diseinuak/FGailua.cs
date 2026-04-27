using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using INBENT_VISUAL.Entitateak;
using INBENT_VISUAL.Kudeatzaileak;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Gailu berri bat (Ordenagailua edo Inprimagailua) sortzeko edo lehendik dagoen baten 
    /// datuak editatzeko erabiltzen den leihoa (Formularioa).
    /// </summary>
    public partial class FGailua : Form
    {
        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Mota { get { return cmbMota.Text; } set { cmbMota.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? IdMintegia
        {
            get
            {
                if (cmbMintegia.SelectedValue != null)
                {
                    return Convert.ToInt32(cmbMintegia.SelectedValue);
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    cmbMintegia.SelectedValue = value.Value;
                }
                else
                {
                    cmbMintegia.SelectedIndex = -1;
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Marka { get { return txtMarka.Text.Trim(); } set { txtMarka.Text = value; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Gela { get { return txtGela.Text.Trim(); } set { txtGela.Text = value; } }

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
        #endregion

        #region METODO PRIBATUAK
        /// <summary>
        /// Datu-basetik eskuragarri dauden mintegi guztiak irakurtzen ditu eta 
        /// interfazearen desplegablean (ComboBox) kargatzen ditu gailuari esleitzeko.
        /// </summary>
        private void KargatuMintegiak()
        {
            try
            {
                Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();
                List<Mintegia> mintegiak = kudeatzailea.MintegiakErakutsiPOO();

                cmbMintegia.DataSource = mintegiak;
                cmbMintegia.DisplayMember = "Izena";
                cmbMintegia.ValueMember = "IdMintegia";
                cmbMintegia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea mintegiak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// POO: Erabiltzailearen rola irakurtzen du, eta Mintegi burua bada, 
        /// bere mintegia jartzen du lehenespenez eta desplegablea blokeatzen du beste mintegi batean ezer sar ez dezan.
        /// </summary>
        /// <param name="rola">Uneko erabiltzailearen rola.</param>
        /// <param name="mintegiIzena">Uneko erabiltzailearen mintegiaren izena.</param>
        private void AplikatuMintegiBuruarenBlokeoa(string rola, string mintegiIzena)
        {
            if (rola == "Mintegi burua")
            {
                // Erabiltzailearen mintegia bilatzen du zerrendan eta hautatzen du
                int index = cmbMintegia.FindStringExact(mintegiIzena);
                if (index != -1)
                {
                    cmbMintegia.SelectedIndex = index;
                }

                // Desplegablea blokeatzen dugu ezin aldatzeko
                cmbMintegia.Enabled = false;
            }
        }
        #endregion

        #region ERAIKITZAILEAK (CONSTRUCTORES)
        /// <summary>
        /// ERAIKITZAILEA: "ALTA" modua. Leihoa hutsik irekitzen da gailu berri bat erregistratzeko.
        /// </summary>
        /// <param name="erabiltzaileRola">Uneko erabiltzailearen rola (blokeoak aplikatzeko).</param>
        /// <param name="erabiltzaileMintegia">Uneko erabiltzailearen mintegiaren izena.</param>
        public FGailua(string erabiltzaileRola, string erabiltzaileMintegia)
        {
            InitializeComponent();
            KargatuMintegiak();

            // Blokeoa aplikatu (bakarrik Mintegi buruei eragingo die)
            AplikatuMintegiBuruarenBlokeoa(erabiltzaileRola, erabiltzaileMintegia);
        }

        /// <summary>
        /// ERAIKITZAILEA: "ALDATU" modua. Datuak jasotzen ditu eta interfazea betetzen du, 
        /// gailuaren motaren arabera (Ordenagailua edo Inprimagailua) panel zuzena erakutsiz.
        /// </summary>
        /// <param name="mota">Gailuaren mota (Ordenagailua / Inprimagailua).</param>
        /// <param name="marka">Gailuaren marka.</param>
        /// <param name="gela">Gailua dagoen gela.</param>
        /// <param name="data">Gailuaren eroste-data.</param>
        /// <param name="ram">RAM memoria (ordenagailua bada).</param>
        /// <param name="rom">Disko gogorra (ordenagailua bada).</param>
        /// <param name="cpu">Prozesadorea (ordenagailua bada).</param>
        /// <param name="kolore">Koloretakoa den ala ez (inprimagailua bada).</param>
        /// <param name="idMintegia">Gailuari esleitutako mintegiaren ID-a.</param>
        /// <param name="erabiltzaileRola">Uneko erabiltzailearen rola (blokeoak aplikatzeko).</param>
        /// <param name="erabiltzaileMintegia">Uneko erabiltzailearen mintegiaren izena.</param>
        public FGailua(string mota, string marka, string gela, DateTime data, string ram, string rom, string cpu, string kolore, int? idMintegia, string erabiltzaileRola, string erabiltzaileMintegia)
        {
            InitializeComponent();
            KargatuMintegiak();

            this.Mota = mota;
            this.Marka = marka;
            this.Gela = gela;
            this.ErosteData = data;
            this.IdMintegia = idMintegia;

            cmbMota.Enabled = false;

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

            // Datuak kargatu ondoren, blokeoa aplikatzen dugu (Mintegi buruei beraien mintegia inposatzeko)
            AplikatuMintegiBuruarenBlokeoa(erabiltzaileRola, erabiltzaileMintegia);
        }
        #endregion

        #region INTERFAZEAREN EKINTZAK (EVENTOS DE UI)
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
        #endregion

        #region BOTOIEN EKINTZAK (EVENTOS DE BOTONES)
        /// <summary>
        /// 'Gorde' botoiaren gertaera (Click). 
        /// Datuen oinarrizko balidazioa egiten du (Mota, Marka eta Mintegia nahitaezkoak dira) 
        /// eta dena zuzen badago DialogResult.OK seinalea bidaltzen du aplikazio nagusira.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (cmbMota.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMarka.Text) || cmbMintegia.SelectedIndex == -1)
            {
                MessageBox.Show("Mesedez, bete oinarrizko datuak (Mota, Mintegia eta Marka gutxienez).", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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