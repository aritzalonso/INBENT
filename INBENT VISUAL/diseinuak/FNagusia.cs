using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FNagusia : Form
    {
        private string erabiltzaileRola;
        private string erabiltzaileIzena;

        // 🌟 BERRIA: Gailu guztiak memorian gordetzeko zerrenda (Bilatzaile azkarrerako)
        private List<INBENT_VISUAL.Entitateak.Gailua> gailuGuztiakOsoa = new List<INBENT_VISUAL.Entitateak.Gailua>();

        public FNagusia(string izena, string rola)
        {
            InitializeComponent();
            this.erabiltzaileIzena = izena;
            this.erabiltzaileRola = rola;

            // Goiburuko testua eguneratzen dugu erabiltzailearen datuekin
            label2.Text = $"👤 {erabiltzaileIzena} | 🛡️ {erabiltzaileRola}";

            BaimenakAplikatu();

            // Datuak kargatzen ditugu hasieran
            KargatuMintegiak();
            KargatuErabiltzaileak();
            KargatuGailuak();
            KargatuMatxurak();
            KargatuDashboard();

            // Filtroak modu lehenetsian "Denak" aukeran jartzen ditugu
            cmbFiltroMota.SelectedIndex = 0;
            cmbFiltroGailuak.SelectedIndex = 0;
        }

        #region HASIERATZEA ETA BAIMENAK
        /// <summary>
        /// Erabiltzailearen rolaren arabera, pantailako botoi batzuk ezkutatzen ditu segurtasuna bermatzeko.
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
            }
            else if (erabiltzaileRola == "Mintegi burua")
            {
                btnErabiltzaileak.Visible = false;
                btnMintegiak.Visible = false;
                btnBajaGailua.Visible = false;
            }
        }
        #endregion

        #region NABIGAZIOA (EZKERREKO MENUA)
        // Panelak bistaratzeko funtzioak
        private void btnHasiera_Click(object sender, EventArgs e) { panelHasiera.BringToFront(); }
        private void btnGailuak_Click(object sender, EventArgs e) { panelGailuak.BringToFront(); }
        private void btnMatxurak_Click(object sender, EventArgs e) { panelMatxurak.BringToFront(); }
        private void btnErabiltzaileak_Click(object sender, EventArgs e) { panelErabiltzaileak.BringToFront(); }
        private void btnMintegiak_Click(object sender, EventArgs e) { panelMintegiak.BringToFront(); }
        #endregion

        #region DATUAK KARGATZEKO FUNTZIOAK (POO)
        /// <summary>
        /// Gailuen zerrenda objektu gisa ekarri, memorian gorde eta iragazkitik pasatzen du.
        /// </summary>
        private void KargatuGailuak()
        {
            try
            {
                Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();

                // 🌟 BERRIA: Datuak memorian gordetzen ditugu abiadura lortzeko
                gailuGuztiakOsoa = kudeatzailea.GailuakErakutsiPOO();

                // Zuzenean iragazki funtziora bidaltzen dugu taula margotzeko
                FiltratuGailuak();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea taula kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Matxuren zerrenda objektu gisa kargatzen du.
        /// </summary>
        private void KargatuMatxurak()
        {
            try
            {
                Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();
                List<INBENT_VISUAL.Entitateak.Matxura> listaObj = kudeatzailea.MatxurakErakutsiPOO();

                var taulaFormatua = System.Linq.Enumerable.Select(listaObj, m => new
                {
                    ID = m.IdMatxura,
                    Data = m.MatxuraData.ToString("dd/MM/yyyy"),
                    Gailua = m.GailuInfo,
                    Deskribapena = m.Deskribapena
                }).ToList();

                dgvMatxurak.DataSource = taulaFormatua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxurak kargatzean: " + ex.Message);
            }
        }

        /// <summary>
        /// Erabiltzaileen zerrenda objektu gisa kargatzen du.
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
        /// Mintegien zerrenda objektu gisa kargatzen du.
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
        /// Hasierako pantailako estatistikak kargatzen ditu.
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

        // 🌟 BERRIA: Bilatzaile adimenduna LINQ erabiliz
        private void FiltratuGailuak(object sender = null, EventArgs e = null)
        {
            if (gailuGuztiakOsoa == null || gailuGuztiakOsoa.Count == 0) return;

            // 1. Irakurri iragazkiak (Buscador + Desplegables)
            // '?' jartzen dugu hasieratzean kontrolak oraindik existitzen ez badira errorerik ez emateko
            string bilaketa = txtBilatzailea?.Text.ToLower().Trim() ?? "";
            string motaAukera = cmbFiltroMota.SelectedItem?.ToString() ?? "Denak";
            string egoeraAukera = cmbFiltroGailuak.SelectedItem?.ToString() ?? "Denak";

            // 2. LINQ Magia: Objektuen zerrenda iragazi
            var iragazita = System.Linq.Enumerable.Where(gailuGuztiakOsoa, g =>
                // A) Bilatzailea: Marka edo Gela bat etortzea
                (string.IsNullOrEmpty(bilaketa) || g.Marka.ToLower().Contains(bilaketa) || g.Gela.ToLower().Contains(bilaketa))
                &&
                // B) Mota Desplegablea (Polimorfismoa erabiliz 'is' bidez)
                (motaAukera == "Denak" ||
                (motaAukera == "Ordenagailua" && g is INBENT_VISUAL.Entitateak.Ordenagailua) ||
                (motaAukera == "Inprimagailua" && g is INBENT_VISUAL.Entitateak.Inprimagailua))
                &&
                // C) Egoera Desplegablea
                (egoeraAukera == "Denak" ||
                (egoeraAukera == "Aktiboak" && g.Egoera.ToLower() == "aktibo") ||
                (egoeraAukera == "Matxuratuak" && g.Egoera.ToLower() == "matxuratua") ||
                (egoeraAukera == "Bajan" && g.Egoera.ToLower() == "bajan"))
            ).ToList();

            // 3. Emaitza prestatu eta taulan erakutsi
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
                Koloretakoa = (g is INBENT_VISUAL.Entitateak.Inprimagailua inp) ? inp.Koloretakoa : ""
            }).ToList();

            dgvGailuak.DataSource = taulaFormatua;
        }

        // 🌟 BERRIA: Ekintza hau exekutatuko da TextBox-ean letra bat tekleatzen den bakoitzean
        public void txtBilatzailea_TextChanged(object sender, EventArgs e)
        {
            FiltratuGailuak();
        }

        private void btnAltaGailua_Click(object sender, EventArgs e)
        {
            using (FGailua leihoa = new FGailua())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                    bool ondoGordeta = false;

                    if (leihoa.Mota == "Ordenagailua")
                    {
                        INBENT_VISUAL.Entitateak.Ordenagailua pcBerria = new INBENT_VISUAL.Entitateak.Ordenagailua();
                        pcBerria.Marka = leihoa.Marka;
                        pcBerria.ErosteData = leihoa.dtpErosteData.Value;
                        pcBerria.Gela = leihoa.Gela;
                        pcBerria.Egoera = "aktibo";
                        pcBerria.Ram = leihoa.RAM;
                        pcBerria.Rom = leihoa.ROM;
                        pcBerria.Cpu = leihoa.CPU;

                        ondoGordeta = kudeatzailea.GehituOrdenagailua(pcBerria);
                    }
                    else if (leihoa.Mota == "Inprimagailua")
                    {
                        INBENT_VISUAL.Entitateak.Inprimagailua inpriBerria = new INBENT_VISUAL.Entitateak.Inprimagailua();
                        inpriBerria.Marka = leihoa.Marka;
                        inpriBerria.ErosteData = leihoa.dtpErosteData.Value;
                        inpriBerria.Gela = leihoa.Gela;
                        inpriBerria.Egoera = "aktibo";
                        inpriBerria.Koloretakoa = leihoa.Koloretakoa;

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

        private void btnAldatuGailua_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count > 0)
            {
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

                    using (FGailua leihoa = new FGailua(mota, marka, gela, data, ram, rom, cpu, kolore))
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
                    MessageBox.Show("Errorea datuak irakurtzean taulatik.\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu gailu bat taulan aldatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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

        private void btnBajaErabiltzailea_Click(object sender, EventArgs e)
        {
            if (dgvErabiltzaileak.SelectedRows.Count > 0)
            {
                int idErabiltzailea = Convert.ToInt32(dgvErabiltzaileak.SelectedRows[0].Cells["ID"].Value);
                string izena = dgvErabiltzaileak.SelectedRows[0].Cells["Izena"].Value.ToString();

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

        private void btnKonpondu_Click(object sender, EventArgs e)
        {
            if (dgvMatxurak.SelectedRows.Count > 0)
            {
                int idMatxura = Convert.ToInt32(dgvMatxurak.SelectedRows[0].Cells["ID"].Value);

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

        private void btnEzabatuMintegia_Click(object sender, EventArgs e)
        {
            if (dgvMintegiak.SelectedRows.Count > 0)
            {
                int idMintegia = Convert.ToInt32(dgvMintegiak.SelectedRows[0].Cells[0].Value);
                string izena = dgvMintegiak.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show($"Ziur zaude '{izena}' mintegia ezabatu nahi duzula?", "Kontuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();
                    if (kudeatzailea.EzabatuMintegia(idMintegia))
                    {
                        MessageBox.Show("Mintegia ondo ezabatu da.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuMintegiak();
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
        #endregion
    }
}