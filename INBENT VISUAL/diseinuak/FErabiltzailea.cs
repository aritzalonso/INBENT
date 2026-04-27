using INBENT_VISUAL.Kudeatzaileak;
using MySql.Data.MySqlClient; // BERRIA: Datu-baseko kontsulta zuzena egiteko
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Erabiltzaile bat (Irakaslea, Mintegi burua, IKT Arduraduna) sortzeko edo aldatzeko 
    /// erabiltzen den leihoa (Formularioa).
    /// </summary>
    public partial class FErabiltzailea : Form
    {
        // BERRIA: Erabiltzailea editatzen ari garenean bere jatorrizko izena gordetzeko
        private string jatorrizkoIzena = "";

        #region PROPIETATEAK (DATUEN ENKAPSULAZIOA)
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
        #endregion

        #region ERAIKITZAILEAK (CONSTRUCTORES)
        /// <summary>
        /// ERAIKITZAILEA: "ALTA" modua. Leihoa hutsik irekitzen da.
        /// </summary>
        public FErabiltzailea()
        {
            InitializeComponent();
            KargatuMintegiakDesplegablera();
        }

        /// <summary>
        /// ERAIKITZAILEA: "ALDATU" modua. Datuak jasotzen ditu eta testu-kutxetan kargatzen ditu.
        /// </summary>
        public FErabiltzailea(string izena, string pasahitza, string rola, string mintegia)
        {
            InitializeComponent();
            KargatuMintegiakDesplegablera();

            this.jatorrizkoIzena = izena; // Jatorrizko izena gordetzen dugu balidazioetarako

            this.Izena = izena;
            this.Pasahitza = pasahitza;
            this.Rola = rola;
            this.Mintegia = mintegia;
        }
        #endregion

        #region DATUAK KARGATZEA
        private void KargatuMintegiakDesplegablera()
        {
            cmbMintegia.Items.Clear();
            Mintegi_Kudeatzailea mintegiMotorra = new Mintegi_Kudeatzailea();

            var mintegiak = mintegiMotorra.MintegiakErakutsiPOO();

            foreach (var m in mintegiak)
            {
                cmbMintegia.Items.Add(m.Izena);
            }

            if (cmbMintegia.Items.Count > 0 && string.IsNullOrEmpty(this.Mintegia))
            {
                cmbMintegia.SelectedIndex = 0;
            }
        }
        #endregion

        #region BALIDAZIOAK ETA BOTOIAK
        /// <summary>
        /// Funtzio honek datu-baseari galdetzen dio ea aukeratutako mintegiak jada baduen buru bat.
        /// Jatorrizko izena pasatzen diogu, gure burua editatzen ari bagara ez dezan errore gisa hartu.
        /// </summary>
        private bool MintegiakBaduBurua(string mintegiIzena, string jatorrizkoErabiltzaileIzena)
        {
            try
            {
                DBkonexioa db = new DBkonexioa();
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = @"SELECT COUNT(*) FROM ERABILTZAILEA e 
                                     JOIN ROLA r ON e.id_rola = r.id_rola 
                                     JOIN MINTEGIA m ON e.id_mintegia = m.id_mintegia
                                     WHERE m.izena = @mintegi 
                                     AND r.izena = 'Mintegi burua' 
                                     AND e.izena != @izena";

                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@mintegi", mintegiIzena);
                    cmd.Parameters.AddWithValue("@izena", jatorrizkoErabiltzaileIzena);

                    int kopurua = Convert.ToInt32(cmd.ExecuteScalar());
                    db.Itxi();

                    return kopurua > 0;
                }
                return false;
            }
            catch
            {
                return false;
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

            // POO ZUZENA: Kudeatzaile objektuari deitzen diogu, Formularioak ez du SQL-rik egiten.
            if (cmbRola.Text == "Mintegi burua" && !string.IsNullOrWhiteSpace(cmbMintegia.Text))
            {
                Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();

                // Kudeatzaileari galdetzen diogu ea jada existitzen den buru bat
                if (kudeatzailea.MintegiakBaduBuruaIzenekin(cmbMintegia.Text, this.jatorrizkoIzena))
                {
                    MessageBox.Show($"'{cmbMintegia.Text}' mintegiak badauka jada Mintegi buru bat.\nEzin dira bi egon mintegi berean.",
                                    "Muga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kodea hemen geratzen da, ez du leihoa ixten
                }
            }

            // Dena ondo badago, onartu seinalea bidali eta itxi
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