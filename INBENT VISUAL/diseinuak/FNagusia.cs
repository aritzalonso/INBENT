using INBENT_VISUAL.Entitateak;
using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Aplikazioaren pantaila nagusia (Dashboard).
    /// Nabigazioa, datuen bistaratzea (taulak), iragazki aurreratuak eta 
    /// entitate ezberdinen (Gailuak, Matxurak, Erabiltzaileak...) kudeaketa zentralizatzen ditu.
    /// </summary>
    public partial class FNagusia : Form
    {
        private string erabiltzaileRola;
        private string erabiltzaileIzena;
        private string erabiltzaileMintegia;

        private List<INBENT_VISUAL.Entitateak.Gailua> gailuGuztiakOsoa = new List<INBENT_VISUAL.Entitateak.Gailua>();

        /// <summary>
        /// Pantaila nagusiaren eraikitzailea. Saioa hasi duen erabiltzailearen datuak jasotzen ditu 
        /// interfazea pertsonalizatzeko eta baimenak aplikatzeko.
        /// </summary>
        /// <param name="izena">Erabiltzailearen izena.</param>
        /// <param name="rola">Erabiltzailearen rola (Irakaslea, Mintegi burua, IKT Arduraduna).</param>
        /// <param name="mintegia">Erabiltzailea zein mintegikoa den.</param>
        public FNagusia(string izena, string rola, string mintegia)
        {
            InitializeComponent();
            this.erabiltzaileIzena = izena;
            this.erabiltzaileRola = rola;
            this.erabiltzaileMintegia = mintegia;

            label2.Text = $"👤 {erabiltzaileIzena} | 🛡️ {erabiltzaileRola} | 🏢 {erabiltzaileMintegia}";

            BaimenakAplikatu();

            KargatuMintegiak();
            KargatuErabiltzaileak();
            KargatuGailuak();
            KargatuMatxurak();
            KargatuDashboard();
            KargatuFiltroMintegiak();
            panelHasiera.BringToFront();
            MarkatuBotoiAktiboa(btnHasiera);

            cmbFiltroMota.SelectedIndex = 0;
            cmbFiltroGailuak.SelectedIndex = 0;
        }

        #region MENUKO NABIGAZIOA (BOTOI AKTIBOA)
        /// <summary>
        /// Ezkerreko menuko botoiak dinamikoki argiztatzen ditu, erabiltzaileari non dagoen adierazteko.
        /// </summary>
        /// <param name="botoiAktiboa">Sakatutako botoiaren erreferentzia.</param>
        private void MarkatuBotoiAktiboa(Button botoiAktiboa)
        {
            System.Drawing.Color koloreOriginala = System.Drawing.Color.FromArgb(33, 47, 61);
            btnHasiera.BackColor = koloreOriginala;
            btnGailuak.BackColor = koloreOriginala;
            btnMatxurak.BackColor = koloreOriginala;
            btnErabiltzaileak.BackColor = koloreOriginala;
            btnMintegiak.BackColor = koloreOriginala;

            botoiAktiboa.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
        }
        #endregion

        #region HASIERATZEA ETA BAIMENAK
        /// <summary>
        /// Aplikazioaren segurtasun-muina. Erabiltzailearen rolaren arabera, pantailako 
        /// botoi eta funtzionalitate batzuk ezkutatzen ditu baimenik gabeko ekintzak ekidinez.
        /// </summary>
        private void BaimenakAplikatu()
        {
            if (erabiltzaileRola == "Irakaslea")
            {
                btnMatxurak.Visible = false;
                btnErabiltzaileak.Visible = false;
                btnMintegiak.Visible = false;
                btnAltaGailua.Visible = false;
                btnBajaGailua.Visible = false;
                btnAldatuGailua.Visible = false;
                btnAltaMatxura.Visible = false;
                btnKonpondu.Visible = false;
            }
            else if (erabiltzaileRola == "Mintegi burua")
            {
                btnErabiltzaileak.Visible = false;
                btnMintegiak.Visible = false;
                btnBajaGailua.Visible = false;
                btnKonpondu.Visible = false;
            }
        }
        #endregion

        #region NABIGAZIOA (EZKERREKO MENUA)
        private void btnHasiera_Click(object sender, EventArgs e)
        {
            MarkatuBotoiAktiboa(btnHasiera);
            panelHasiera.BringToFront();
        }

        private void btnGailuak_Click(object sender, EventArgs e)
        {
            MarkatuBotoiAktiboa(btnGailuak);
            panelGailuak.BringToFront();
        }

        private void btnMatxurak_Click(object sender, EventArgs e)
        {
            MarkatuBotoiAktiboa(btnMatxurak);
            panelMatxurak.BringToFront();
        }

        private void btnErabiltzaileak_Click(object sender, EventArgs e)
        {
            MarkatuBotoiAktiboa(btnErabiltzaileak);
            panelErabiltzaileak.BringToFront();
        }

        private void btnMintegiak_Click(object sender, EventArgs e)
        {
            MarkatuBotoiAktiboa(btnMintegiak);
            panelMintegiak.BringToFront();
        }
        #endregion

        #region DATUAK KARGATZEKO FUNTZIOAK (POO)
        /// <summary>
        /// Datu-basetik gailu guztien zerrenda ekarri, memorian gorde (Polimorfismoa erabiliz) 
        /// eta iragazki funtziora bidaltzen du taulan erakusteko.
        /// </summary>
        private void KargatuGailuak()
        {
            try
            {
                Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                gailuGuztiakOsoa = kudeatzailea.GailuakErakutsiPOO();
                FiltratuGailuak();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea taula kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Matxura guztiak irakurri eta dagokion taulan (DataGridView) bistaratzen ditu.
        /// Mintegi buruen kasuan, beren mintegiko matxurak soilik erakusten ditu.
        /// </summary>
        private void KargatuMatxurak()
        {
            try
            {
                Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();
                List<INBENT_VISUAL.Entitateak.Matxura> listaObj = kudeatzailea.MatxurakErakutsiPOO();

                var iragazita = System.Linq.Enumerable.Where(listaObj, m =>
                    (erabiltzaileRola != "Irakaslea" && erabiltzaileRola != "Mintegi burua") || m.MintegiIzena == erabiltzaileMintegia
                ).ToList();

                var taulaFormatua = System.Linq.Enumerable.Select(iragazita, m => new
                {
                    Matxura_ID = m.IdMatxura,
                    Gailu_ID = m.IdGailua,
                    Data = m.MatxuraData.ToString("dd/MM/yyyy"),
                    Gailua = m.GailuInfo,
                    Deskribapena = m.Deskribapena,
                    Mintegia = m.MintegiIzena
                }).ToList();

                dgvMatxurak.DataSource = taulaFormatua;

                if (dgvMatxurak.Columns["Matxura_ID"] != null)
                {
                    dgvMatxurak.Columns["Matxura_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxurak kargatzean: " + ex.Message);
            }
        }

        /// <summary>
        /// Gailuen ataleko bilatzailean agertzen den mintegien desplegablea (ComboBox) betetzen du.
        /// </summary>
        private void KargatuFiltroMintegiak()
        {
            try
            {
                Mintegi_Kudeatzailea mintegiKudeatzailea = new Mintegi_Kudeatzailea();
                List<INBENT_VISUAL.Entitateak.Mintegia> listaObj = mintegiKudeatzailea.MintegiakErakutsiPOO();

                cmbFiltroMintegia.Items.Clear();
                cmbFiltroMintegia.Items.Add("Denak");

                foreach (var m in listaObj)
                {
                    cmbFiltroMintegia.Items.Add(m.Izena);
                }

                cmbFiltroMintegia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea filtroa kargatzean: " + ex.Message);
            }
        }

        /// <summary>
        /// Aplikazioko erabiltzaile guztiak datu-basetik irakurri eta taulan formatu egokian kargatzen ditu.
        /// </summary>
        private void KargatuErabiltzaileak()
        {
            try
            {
                Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                List<INBENT_VISUAL.Entitateak.Erabiltzailea> listaObj = kudeatzailea.ErabiltzaileakErakutsiPOO();

                var taulaFormatua = System.Linq.Enumerable.Select(listaObj, e => new
                {
                    ID = e.IdErabiltzailea,
                    Izena = e.Izena,
                    Rola = e.RolIzena,
                    Mintegia = e.MintegiIzena
                }).ToList();

                dgvErabiltzaileak.DataSource = taulaFormatua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea taula kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Existitzen diren mintegi guztiak kargatzen ditu mintegien kudeaketa-taulan bistaratzeko.
        /// </summary>
        private void KargatuMintegiak()
        {
            try
            {
                Mintegi_Kudeatzailea mintegiKudeatzailea = new Mintegi_Kudeatzailea();
                List<INBENT_VISUAL.Entitateak.Mintegia> listaObj = mintegiKudeatzailea.MintegiakErakutsiPOO();

                var taulaFormatua = System.Linq.Enumerable.Select(listaObj, m => new
                {
                    ID = m.IdMintegia,
                    Izena = m.Izena
                }).ToList();

                dgvMintegiak.DataSource = taulaFormatua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea taula kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hasierako pantailako (Dashboard) estatistikak (txartelak) eguneratzen ditu, 
        /// entitate bakoitzaren zenbaketa eguneratua erakutsiz.
        /// </summary>
        private void KargatuDashboard()
        {
            Estatistikak_kudeatzailea estatistikak = new Estatistikak_kudeatzailea();
            lblGailuKop.Text = estatistikak.LortuGailuKopurua().ToString();
            lblErabiltzaileKop.Text = estatistikak.LortuErabiltzaileKopurua().ToString();
            lblMatxuraKop.Text = estatistikak.LortuMatxuraKopurua().ToString();
        }
        #endregion

        #region GAILUEN KUDEAKETA ETA FILTROAK (Buscador en tiempo real)
        /// <summary>
        /// Bilatzaile adimenduna. Memorian kargatuta dauden gailu guztiak iragazten ditu LINQ erabiliz.
        /// Erabiltzailearen rola, bilaketa-testua eta goiko hiru desplegableak hartzen ditu kontuan 
        /// emaitzak denbora errealean erakusteko.
        /// </summary>
        private void FiltratuGailuak(object sender = null, EventArgs e = null)
        {
            if (gailuGuztiakOsoa == null || gailuGuztiakOsoa.Count == 0) return;

            string bilaketa = txtBilatzailea?.Text.ToLower().Trim() ?? "";
            string motaAukera = cmbFiltroMota.SelectedItem?.ToString() ?? "Denak";
            string egoeraAukera = cmbFiltroGailuak.SelectedItem?.ToString() ?? "Denak";

            string mintegiAukera = "Denak";
            if (cmbFiltroMintegia != null && cmbFiltroMintegia.SelectedItem != null)
            {
                mintegiAukera = cmbFiltroMintegia.SelectedItem.ToString();
            }

            var iragazita = System.Linq.Enumerable.Where(gailuGuztiakOsoa, g =>
                ((erabiltzaileRola != "Irakaslea" && erabiltzaileRola != "Mintegi burua") || g.MintegiIzena == erabiltzaileMintegia)
                &&
                (string.IsNullOrEmpty(bilaketa) || g.Marka.ToLower().Contains(bilaketa) || g.Gela.ToLower().Contains(bilaketa))
                &&
                (motaAukera == "Denak" ||
                (motaAukera == "Ordenagailua" && g is INBENT_VISUAL.Entitateak.Ordenagailua) ||
                (motaAukera == "Inprimagailua" && g is INBENT_VISUAL.Entitateak.Inprimagailua))
                &&
                (egoeraAukera == "Denak" ||
                (egoeraAukera == "Aktiboak" && g.Egoera.ToLower() == "aktibo") ||
                (egoeraAukera == "Matxuratuak" && g.Egoera.ToLower() == "matxuratua") ||
                (egoeraAukera == "Bajan" && g.Egoera.ToLower() == "bajan"))
                &&
                (mintegiAukera == "Denak" || g.MintegiIzena == mintegiAukera)
            ).ToList();

            var taulaFormatua = System.Linq.Enumerable.Select(iragazita, g => new
            {
                ID = g.IdGailua,
                Mota = (g is INBENT_VISUAL.Entitateak.Ordenagailua) ? "Ordenagailua" : "Inprimagailua",
                Marka = g.Marka,
                Gela = g.Gela,
                Eroste_Data = g.ErosteData.ToString("dd/MM/yyyy"),
                Egoera = g.Egoera,
                RAM = (g is INBENT_VISUAL.Entitateak.Ordenagailua pc) ? pc.Ram : "",
                ROM = (g is INBENT_VISUAL.Entitateak.Ordenagailua pc2) ? pc2.Rom : "",
                CPU = (g is INBENT_VISUAL.Entitateak.Ordenagailua pc3) ? pc3.Cpu : "",
                Koloretakoa = (g is INBENT_VISUAL.Entitateak.Inprimagailua inp) ? inp.Koloretakoa : "",
                IdMintegia = g.IdMintegia,
                Mintegia = g.MintegiIzena
            }).ToList();

            dgvGailuak.DataSource = taulaFormatua;

            if (dgvGailuak.Columns["IdMintegia"] != null)
            {
                dgvGailuak.Columns["IdMintegia"].Visible = false;
            }
        }

        public void txtBilatzailea_TextChanged(object sender, EventArgs e)
        {
            FiltratuGailuak();
        }

        /// <summary>
        /// Gailu berri baten alta emateko leihoa (FGailua) irekitzen du, eta OK jasotzean 
        /// Gailu_Kudeatzailea erabiliz datu-basean txertatzen du bere motaren arabera.
        /// </summary>
        private void btnAltaGailua_Click(object sender, EventArgs e)
        {
            using (FGailua leihoa = new FGailua(this.erabiltzaileRola, this.erabiltzaileMintegia))
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                    bool ondoGordeta = false;

                    if (leihoa.Mota == "Ordenagailua")
                    {
                        INBENT_VISUAL.Entitateak.Ordenagailua pcBerria = new INBENT_VISUAL.Entitateak.Ordenagailua();
                        pcBerria.Marka = leihoa.Marka;
                        pcBerria.ErosteData = leihoa.ErosteData;
                        pcBerria.Gela = leihoa.Gela;
                        pcBerria.Egoera = "aktibo";
                        pcBerria.Ram = leihoa.RAM;
                        pcBerria.Rom = leihoa.ROM;
                        pcBerria.Cpu = leihoa.CPU;
                        pcBerria.IdMintegia = leihoa.IdMintegia;

                        ondoGordeta = kudeatzailea.GehituOrdenagailua(pcBerria);
                    }
                    else if (leihoa.Mota == "Inprimagailua")
                    {
                        INBENT_VISUAL.Entitateak.Inprimagailua inpriBerria = new INBENT_VISUAL.Entitateak.Inprimagailua();
                        inpriBerria.Marka = leihoa.Marka;
                        inpriBerria.ErosteData = leihoa.ErosteData;
                        inpriBerria.Gela = leihoa.Gela;
                        inpriBerria.Egoera = "aktibo";
                        inpriBerria.Koloretakoa = leihoa.Koloretakoa;
                        inpriBerria.IdMintegia = leihoa.IdMintegia;

                        ondoGordeta = kudeatzailea.GehituInprimagailua(inpriBerria);
                    }

                    if (ondoGordeta)
                    {
                        MessageBox.Show($"{leihoa.Mota} ondo gorde da datu-basean!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuGailuak();
                    }
                }
            }
        }

        /// <summary>
        /// Hautatutako gailuaren datuak aldatzeko leihoa irekitzen du.
        /// Bajan dauden gailuak blokeatzen ditu aldaketak ekiditeko.
        /// </summary>
        private void btnAldatuGailua_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count > 0)
            {
                string egoera = dgvGailuak.SelectedRows[0].Cells["Egoera"].Value?.ToString() ?? "";

                if (egoera == "Bajan" || egoera == "Baja")
                {
                    MessageBox.Show("Bajan dauden gailuak blokeatuta daude eta ezin dira aldatu.", "Gailua blokeatuta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    int idGailua = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells[0].Value);
                    string mota = dgvGailuak.SelectedRows[0].Cells[1].Value.ToString();
                    string marka = dgvGailuak.SelectedRows[0].Cells[2].Value.ToString();
                    string gela = dgvGailuak.SelectedRows[0].Cells[3].Value.ToString();

                    DateTime data;
                    if (!DateTime.TryParse(dgvGailuak.SelectedRows[0].Cells[4].Value.ToString(), out data))
                        data = DateTime.Now;

                    string ram = dgvGailuak.SelectedRows[0].Cells[6].Value?.ToString() ?? "";
                    string rom = dgvGailuak.SelectedRows[0].Cells[7].Value?.ToString() ?? "";
                    string cpu = dgvGailuak.SelectedRows[0].Cells[8].Value?.ToString() ?? "";
                    string kolore = dgvGailuak.SelectedRows[0].Cells[9].Value?.ToString() ?? "";

                    int? idMintegia = null;
                    if (dgvGailuak.SelectedRows[0].Cells["IdMintegia"].Value != null && dgvGailuak.SelectedRows[0].Cells["IdMintegia"].Value.ToString() != "")
                    {
                        idMintegia = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells["IdMintegia"].Value);
                    }

                    using (FGailua leihoa = new FGailua(mota, marka, gela, data, ram, rom, cpu, kolore, idMintegia, this.erabiltzaileRola, this.erabiltzaileMintegia))
                    {
                        if (leihoa.ShowDialog() == DialogResult.OK)
                        {
                            Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                            bool ondoGordeta = false;

                            if (mota == "Ordenagailua")
                            {
                                INBENT_VISUAL.Entitateak.Ordenagailua pcAldatuta = new INBENT_VISUAL.Entitateak.Ordenagailua();
                                pcAldatuta.IdGailua = idGailua;
                                pcAldatuta.Marka = leihoa.Marka;
                                pcAldatuta.ErosteData = leihoa.ErosteData;
                                pcAldatuta.Gela = leihoa.Gela;
                                pcAldatuta.Ram = leihoa.RAM;
                                pcAldatuta.Rom = leihoa.ROM;
                                pcAldatuta.Cpu = leihoa.CPU;
                                pcAldatuta.IdMintegia = leihoa.IdMintegia;

                                ondoGordeta = kudeatzailea.AldatuOrdenagailua(pcAldatuta);
                            }
                            else if (mota == "Inprimagailua")
                            {
                                INBENT_VISUAL.Entitateak.Inprimagailua inpriAldatuta = new INBENT_VISUAL.Entitateak.Inprimagailua();
                                inpriAldatuta.IdGailua = idGailua;
                                inpriAldatuta.Marka = leihoa.Marka;
                                inpriAldatuta.ErosteData = leihoa.ErosteData;
                                inpriAldatuta.Gela = leihoa.Gela;
                                inpriAldatuta.Koloretakoa = leihoa.Koloretakoa;
                                inpriAldatuta.IdMintegia = leihoa.IdMintegia;

                                ondoGordeta = kudeatzailea.AldatuInprimagailua(inpriAldatuta);
                            }

                            if (ondoGordeta)
                            {
                                MessageBox.Show("Gailua ondo eguneratu da!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KargatuGailuak();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea gailua aldatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aukeratu gailu bat taulan aldatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Hautatutako gailuari baja emateko inprimakia irekitzen du eta 
        /// baja-arrazoia datu-basean gordetzen du.
        /// </summary>
        private void btnBajaGailua_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count > 0)
            {
                int idGailua = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells["ID"].Value);

                using (FBaja leihoa = new FBaja())
                {
                    if (leihoa.ShowDialog() == DialogResult.OK)
                    {
                        Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                        if (kudeatzailea.BajaEman(idGailua, leihoa.Arrazoia))
                        {
                            MessageBox.Show("Gailuari baja eman zaio.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KargatuGailuak();
                            KargatuDashboard();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu gailu bat taulan baja emateko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Gailu baten historiala (matxurak eta konponketak) kontsultatzeko leihoa irekitzen du.
        /// </summary>
        private void btnHistoriala_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count > 0)
            {
                try
                {
                    int idGailua = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells["ID"].Value);
                    string marka = dgvGailuak.SelectedRows[0].Cells["Marka"].Value.ToString();
                    string gela = dgvGailuak.SelectedRows[0].Cells["Gela"].Value.ToString();
                    string egoera = dgvGailuak.SelectedRows[0].Cells["Egoera"].Value?.ToString() ?? "";
                    string gailuInfo = $"{marka} ({gela})";

                    using (FHistoriala leihoa = new FHistoriala(idGailua, gailuInfo, egoera))
                    {
                        leihoa.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea datuak irakurtzean.\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu gailu bat taulan bere historiala ikusteko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region ERABILTZAILEEN KUDEAKETA
        /// <summary>
        /// Erabiltzaile berri bat (Alta) sisteman erregistratzeko interfazea irekitzen du.
        /// </summary>
        private void btnAltaErabiltzailea_Click(object sender, EventArgs e)
        {
            using (FErabiltzailea leihoa = new FErabiltzailea())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                    INBENT_VISUAL.Entitateak.Erabiltzailea erabBerria = new INBENT_VISUAL.Entitateak.Erabiltzailea();
                    erabBerria.Izena = leihoa.Izena;
                    erabBerria.Pasahitza = leihoa.Pasahitza;
                    erabBerria.RolIzena = leihoa.Rola;
                    erabBerria.MintegiIzena = leihoa.Mintegia;

                    if (kudeatzailea.GehituErabiltzailea(erabBerria))
                    {
                        MessageBox.Show("Erabiltzailea ondo gorde da datu-basean!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuErabiltzaileak();
                        KargatuDashboard();
                    }
                }
            }
        }

        /// <summary>
        /// Hautatutako erabiltzailearen informazioa (rola, mintegia, pasahitza) aldatzeko leihoa irekitzen du.
        /// </summary>
        private void btnAldatuErabiltzailea_Click(object sender, EventArgs e)
        {
            if (dgvErabiltzaileak.SelectedRows.Count > 0)
            {
                try
                {
                    int idErabiltzailea = Convert.ToInt32(dgvErabiltzaileak.SelectedRows[0].Cells[0].Value);
                    string izena = dgvErabiltzaileak.SelectedRows[0].Cells[1].Value.ToString();
                    string rola = dgvErabiltzaileak.SelectedRows[0].Cells[2].Value.ToString();
                    string mintegia = dgvErabiltzaileak.SelectedRows[0].Cells[3].Value.ToString();

                    using (FErabiltzailea leihoa = new FErabiltzailea(izena, "", rola, mintegia))
                    {
                        if (leihoa.ShowDialog() == DialogResult.OK)
                        {
                            Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                            INBENT_VISUAL.Entitateak.Erabiltzailea erabAldatuta = new INBENT_VISUAL.Entitateak.Erabiltzailea();
                            erabAldatuta.IdErabiltzailea = idErabiltzailea;
                            erabAldatuta.Izena = leihoa.Izena;
                            erabAldatuta.Pasahitza = leihoa.Pasahitza;
                            erabAldatuta.RolIzena = leihoa.Rola;
                            erabAldatuta.MintegiIzena = leihoa.Mintegia;

                            if (kudeatzailea.AldatuErabiltzailea(erabAldatuta))
                            {
                                MessageBox.Show("Erabiltzailea ondo eguneratu da!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KargatuErabiltzaileak();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea datuak irakurtzean.\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aukeratu erabiltzaile bat aldatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Hautatutako erabiltzailea datu-basetik ezabatzen du bere baieztapena jaso ondoren.
        /// </summary>
        private void btnBajaErabiltzailea_Click(object sender, EventArgs e)
        {
            if (dgvErabiltzaileak.SelectedRows.Count > 0)
            {
                int idErabiltzailea = Convert.ToInt32(dgvErabiltzaileak.SelectedRows[0].Cells["ID"].Value);
                string izena = dgvErabiltzaileak.SelectedRows[0].Cells["Izena"].Value.ToString();

                if (izena == this.erabiltzaileIzena)
                {
                    MessageBox.Show("Segurtasun arrazoiak direla eta, ezin duzu zure burua ezabatu saioa hasita daukazunean.",
                                    "Segurtasun Blokeoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"Ziur zaude '{izena}' erabiltzailea ezabatu nahi duzula?", "Kontuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                    if (kudeatzailea.EzabatuErabiltzailea(idErabiltzailea))
                    {
                        MessageBox.Show("Erabiltzailea ondo ezabatu da.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuErabiltzaileak();
                        KargatuDashboard();
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu erabiltzaile bat ezabatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region MATXUREN KUDEAKETA
        /// <summary>
        /// Gailuen taulan hautatutako gailuari matxura berri bat ezartzen dio eta 
        /// gailuaren egoera 'matxuratua' izatera pasatzen du datu-basean.
        /// </summary>
        private void btnAltaMatxura_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count > 0)
            {
                int idGailua = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells["ID"].Value);
                string marka = dgvGailuak.SelectedRows[0].Cells["Marka"].Value.ToString();
                string gela = dgvGailuak.SelectedRows[0].Cells["Gela"].Value.ToString();
                string egoera = dgvGailuak.SelectedRows[0].Cells["Egoera"].Value.ToString();

                if (egoera == "bajan")
                {
                    MessageBox.Show("Ezin zaio matxura bat sortu 'bajan' dagoen gailu bati.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gailuInfo = $"{idGailua} - {marka} ({gela})";

                using (FMatxura leihoa = new FMatxura(idGailua, gailuInfo))
                {
                    if (leihoa.ShowDialog() == DialogResult.OK)
                    {
                        INBENT_VISUAL.Entitateak.Matxura matxuraBerria = leihoa.MatxuraBerria;
                        Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();

                        if (kudeatzailea.GehituMatxura(matxuraBerria))
                        {
                            MessageBox.Show("Matxura erregistratu da. Gailuaren egoera 'matxuratua' izatera pasa da.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KargatuMatxurak();
                            KargatuGailuak();
                            KargatuDashboard();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu gailu bat taulan matxura sortzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Matxuren taulan hautatutako matxura bati konponketa txostena gehitzen dio, 
        /// eta gailuaren egoera berriro 'aktibo' izatera pasatzen du.
        /// </summary>
        private void btnKonpondu_Click(object sender, EventArgs e)
        {
            if (dgvMatxurak.SelectedRows.Count > 0)
            {
                int idMatxura = Convert.ToInt32(dgvMatxurak.SelectedRows[0].Cells["Matxura_ID"].Value);

                using (FKonponketa leihoa = new FKonponketa())
                {
                    if (leihoa.ShowDialog() == DialogResult.OK)
                    {
                        INBENT_VISUAL.Entitateak.Matxura matxuraKonponduta = new INBENT_VISUAL.Entitateak.Matxura();
                        matxuraKonponduta.IdMatxura = idMatxura;
                        matxuraKonponduta.KonponketaData = leihoa.KonponketaData;
                        matxuraKonponduta.KonponketaDeskribapena = leihoa.Deskribapena;

                        Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();
                        if (kudeatzailea.KonponduMatxura(matxuraKonponduta))
                        {
                            MessageBox.Show("Gailua ondo konpondu da eta historialean gorde da!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KargatuMatxurak();
                            KargatuGailuak();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu matxura bat taulan konpontzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region MINTEGIEN KUDEAKETA
        /// <summary>
        /// Mintegi berri bat sortzeko inprimakia irekitzen du.
        /// </summary>
        private void btnMintegiaSortu_Click(object sender, EventArgs e)
        {
            using (FMintegia leihoa = new FMintegia())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();
                    INBENT_VISUAL.Entitateak.Mintegia mintegiBerria = new INBENT_VISUAL.Entitateak.Mintegia();
                    mintegiBerria.Izena = leihoa.MintegiIzena;

                    if (kudeatzailea.GehituMintegia(mintegiBerria))
                    {
                        MessageBox.Show("Mintegia ondo gorde da datu-basean!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuMintegiak();
                    }
                }
            }
        }

        /// <summary>
        /// Hautatutako mintegia ezabatzeko eta bertako gailu nahiz erabiltzaileak 
        /// beste mintegi batera migratzeko (mugitzeko) prozesua kudeatzen du.
        /// </summary>
        private void btnEzabatuMintegia_Click(object sender, EventArgs e)
        {
            if (dgvMintegiak.SelectedRows.Count > 0)
            {
                int idZaharra = Convert.ToInt32(dgvMintegiak.SelectedRows[0].Cells[0].Value);
                string izena = dgvMintegiak.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show($"Ziur zaude '{izena}' mintegia ezabatu nahi duzula?", "Kontuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (FMintegiAldaketa leihoa = new FMintegiAldaketa(idZaharra, izena))
                    {
                        if (leihoa.ShowDialog() == DialogResult.OK)
                        {
                            Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();

                            if (kudeatzailea.EzabatuEtaMugitu(idZaharra, leihoa.IdMintegiBerria))
                            {
                                MessageBox.Show("Mintegia ezabatu da eta bertako gailu/erabiltzaileak ondo mugitu dira!", "Migrazioa burututa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                KargatuMintegiak();
                                KargatuGailuak();
                                KargatuErabiltzaileak();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu mintegi bat taulan ezabatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region EKINTZA HUTSAK 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelGailuak_Paint(object sender, PaintEventArgs e) { }
        private void dgvGailuak_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblFiltroMintegia_Click(object sender, EventArgs e) { }
        private void lblBilatzailea_Click(object sender, EventArgs e) { }
        #endregion

        #region GOIBURUKOA ETA SAIOA AMAITU (PASO 2)
        /// <summary>
        /// Erabiltzailearen izenean (goiburuan) klik egitean, pasahitza aldatzeko aukera ematen du.
        /// </summary>
        private void label2_Click(object sender, EventArgs e)
        {
            using (FProfila leihoa = new FProfila(this.erabiltzaileIzena, this.erabiltzaileRola, this.erabiltzaileMintegia))
            {
                leihoa.ShowDialog();
            }
        }

        /// <summary>
        /// Saioa amaitzeko botoiaren gertaera. Erabiltzaileari galdetu ondoren, 
        /// aplikazioa berrabiarazten du FLogin pantailara garbi itzultzeko.
        /// </summary>
        private void btnAmaituSaioa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ziur zaude saioa amaitu nahi duzula?", "Saioa Amaitu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        #endregion
    }
}