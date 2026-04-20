using INBENT_VISUAL.Kudeatzaileak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FHasiera : Form
    {
        private string erabiltzaileRola;
        private string erabiltzaileIzena;

        public FHasiera(string izena, string rola)
        {
            InitializeComponent();
            this.erabiltzaileIzena = izena;
            this.erabiltzaileRola = rola;

            // Cambiamos el texto de la cabecera
            label2.Text = $"👤 {erabiltzaileIzena} | 🛡️ {erabiltzaileRola}";

            BaimenakAplikatu();
            KargatuMintegiak();
            KargatuErabiltzaileak();
            KargatuGailuak();
            KargatuMatxurak();
            KargatuMatxurak();
            KargatuDashboard();
            // Seleccionamos "Denak" por defecto
            cmbFiltroMota.SelectedIndex = 0;
            cmbFiltroGailuak.SelectedIndex = 0;
        }

        private void KargatuErabiltzaileak()
        {
            Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
            dgvErabiltzaileak.DataSource = kudeatzailea.ErabiltzaileakErakutsi();
        }

        private void KargatuMintegiak()
        {
            Mintegi_Kudeatzailea mintegiKudeatzailea = new Mintegi_Kudeatzailea();
            dgvMintegiak.DataSource = mintegiKudeatzailea.MintegiakErakutsi();
        }

        private void KargatuGailuak()
        {
            Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
            dgvGailuak.DataSource = kudeatzailea.GailuakErakutsi();
        }
        private void KargatuDashboard()
        {
            Estatistikak_kudeatzailea estatistikak = new Estatistikak_kudeatzailea();

            // Llamamos a las 3 funciones y escribimos el resultado en las etiquetas grandes
            lblGailuKop.Text = estatistikak.LortuGailuKopurua().ToString();
            lblErabiltzaileKop.Text = estatistikak.LortuErabiltzaileKopurua().ToString();
            lblMatxuraKop.Text = estatistikak.LortuMatxuraKopurua().ToString();
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

                    // 1. Extraemos también el estado de la tabla (Asegúrate de que la columna se llama "Egoera")
                    string egoera = dgvGailuak.SelectedRows[0].Cells["Egoera"].Value?.ToString() ?? "";

                    string gailuInfo = $"{marka} ({gela})";

                    // 2. Le pasamos el estado (egoera) a la ventana nueva
                    using (FHistoriala leihoa = new FHistoriala(idGailua, gailuInfo, egoera))
                    {
                        leihoa.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorea datuak irakurtzean. Ziurtatu zutabeak ondo daudela.\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu gailu bat taulan bere historiala ikusteko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KargatuMatxurak()
        {
            Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();
            dgvMatxurak.DataSource = kudeatzailea.MatxurakErakutsi();
        }

        private void FiltratuGailuak(object sender, EventArgs e)
        {
            if (dgvGailuak.DataSource != null && dgvGailuak.DataSource is DataTable dt)
            {
                string motaAukera = cmbFiltroMota.SelectedItem?.ToString() ?? "Denak";
                string egoeraAukera = cmbFiltroGailuak.SelectedItem?.ToString() ?? "Denak";

                List<string> filtroak = new List<string>();

                if (motaAukera != "Denak")
                    filtroak.Add($"Mota = '{motaAukera}'");

                if (egoeraAukera == "Aktiboak") filtroak.Add("Egoera = 'aktibo'");
                else if (egoeraAukera == "Matxuratuak") filtroak.Add("Egoera = 'matxuratua'");
                else if (egoeraAukera == "Bajan") filtroak.Add("Egoera = 'bajan'");

                if (filtroak.Count > 0)
                {
                    dt.DefaultView.RowFilter = string.Join(" AND ", filtroak);
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
        }

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

        private void btnGailuak_Click(object sender, EventArgs e) { panelGailuak.BringToFront(); }
        private void btnHasiera_Click(object sender, EventArgs e) { panelHasiera.BringToFront(); }
        private void btnMatxurak_Click(object sender, EventArgs e) { panelMatxurak.BringToFront(); }
        private void btnErabiltzaileak_Click(object sender, EventArgs e) { panelErabiltzaileak.BringToFront(); }
        private void btnMintegiak_Click(object sender, EventArgs e) { panelMintegiak.BringToFront(); }

        private void btnAltaGailua_Click(object sender, EventArgs e)
        {
            using (FGailua leihoa = new FGailua())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                    bool ondoGordeta = false;

                    string mota = leihoa.Mota;
                    string marka = leihoa.Marka;
                    string gela = leihoa.Gela;
                    DateTime data = leihoa.dtpErosteData.Value;
                    string egoera = "aktibo";

                    if (mota == "Ordenagailua")
                    {
                        ondoGordeta = kudeatzailea.GehituOrdenagailua(marka, data, gela, egoera, leihoa.RAM, leihoa.ROM, leihoa.CPU);
                    }
                    else if (mota == "Inprimagailua")
                    {
                        ondoGordeta = kudeatzailea.GehituInprimagailua(marka, data, gela, egoera, leihoa.Koloretakoa);
                    }

                    if (ondoGordeta)
                    {
                        MessageBox.Show($"{mota} ondo gorde da datu-basean!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuGailuak();
                    }
                }
            }
        }

        private void btnMintegiaSortu_Click(object sender, EventArgs e)
        {
            using (FMintegia leihoa = new FMintegia())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();
                    if (kudeatzailea.GehituMintegia(leihoa.MintegiIzena))
                    {
                        MessageBox.Show("Mintegia ondo gorde da datu-basean!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuMintegiak();
                    }
                }
            }
        }

        private void btnAltaErabiltzailea_Click(object sender, EventArgs e)
        {
            using (FErabiltzailea leihoa = new FErabiltzailea())
            {
                if (leihoa.ShowDialog() == DialogResult.OK)
                {
                    Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                    if (kudeatzailea.GehituErabiltzailea(leihoa.Izena, leihoa.Pasahitza, leihoa.Rola, leihoa.Mintegia))
                    {
                        MessageBox.Show("Erabiltzailea ondo gorde da datu-basean!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuErabiltzaileak();
                    }
                }
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
                        Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();
                        if (kudeatzailea.KonponduMatxura(idMatxura, leihoa.KonponketaData, leihoa.Deskribapena))
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
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu gailu bat taulan baja emateko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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
                        Matxura_kudeatzailea kudeatzailea = new Matxura_kudeatzailea();
                        if (kudeatzailea.GehituMatxura(idGailua, leihoa.MatxuraData, leihoa.Deskribapena))
                        {
                            MessageBox.Show("Matxura erregistratu da. Gailuaren egoera automatikoki 'matxuratua' izatera pasa da.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KargatuMatxurak();
                            KargatuGailuak();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu gailu bat taulan matxura sortzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Eventos de click vacíos que estaban causando problemas si se borraban
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelGailuak_Paint(object sender, PaintEventArgs e) { }
        private void dgvGailuak_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnBajaErabiltzailea_Click(object sender, EventArgs e)
        {
            // 1. Comprobamos que hay un usuario seleccionado
            if (dgvErabiltzaileak.SelectedRows.Count > 0)
            {
                // 2. Cogemos su ID y su Nombre (Asegúrate de que las columnas se llaman así en tu BBDD)
                int idErabiltzailea = Convert.ToInt32(dgvErabiltzaileak.SelectedRows[0].Cells["ID"].Value);
                string izena = dgvErabiltzaileak.SelectedRows[0].Cells["Izena"].Value.ToString();

                // 3. Preguntamos por seguridad
                DialogResult erantzuna = MessageBox.Show($"Ziur zaude '{izena}' erabiltzailea ezabatu nahi duzula? Ekintza hau ezin da desegin.", "Kontuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (erantzuna == DialogResult.Yes)
                {
                    // 4. Llamamos a tu motor para borrarlo
                    Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                    if (kudeatzailea.EzabatuErabiltzailea(idErabiltzailea))
                    {
                        MessageBox.Show("Erabiltzailea ondo ezabatu da.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuErabiltzaileak(); // Refrescamos la tabla
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu erabiltzaile bat taulan ezabatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEzabatuMintegia_Click(object sender, EventArgs e)
        {
            if (dgvMintegiak.SelectedRows.Count > 0)
            {
                // Asumiendo que el ID del mintegi está en la primera columna
                int idMintegia = Convert.ToInt32(dgvMintegiak.SelectedRows[0].Cells[0].Value);

                // Cogemos la celda [1] (la segunda columna) para el Nombre
                string izena = dgvMintegiak.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult erantzuna = MessageBox.Show($"Ziur zaude '{izena}' mintegia ezabatu nahi duzula?", "Kontuz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (erantzuna == DialogResult.Yes)
                {
                    Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();
                    if (kudeatzailea.EzabatuMintegia(idMintegia))
                    {
                        MessageBox.Show("Mintegia ondo ezabatu da.", "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KargatuMintegiak(); // Refrescamos la tabla
                    }
                }
            }
            else
            {
                MessageBox.Show("Aukeratu mintegi bat taulan ezabatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAldatuErabiltzailea_Click(object sender, EventArgs e)
        {
            // 1. Comprobamos que hay alguien seleccionado
            if (dgvErabiltzaileak.SelectedRows.Count > 0)
            {
                try
                {
                    // 2. Extraemos SOLO los datos que vemos en tu tabla
                    int idErabiltzailea = Convert.ToInt32(dgvErabiltzaileak.SelectedRows[0].Cells[0].Value);
                    string izena = dgvErabiltzaileak.SelectedRows[0].Cells[1].Value.ToString();
                    string rola = dgvErabiltzaileak.SelectedRows[0].Cells[2].Value.ToString();
                    string mintegia = dgvErabiltzaileak.SelectedRows[0].Cells[3].Value.ToString();

                    // La contraseña no está en la tabla, así que la pasamos vacía por defecto
                    string pasahitza = "";

                    // 3. Abrimos la ventana en Modo "ALDATU" (pasándole los datos)
                    using (FErabiltzailea leihoa = new FErabiltzailea(izena, pasahitza, rola, mintegia))
                    {
                        if (leihoa.ShowDialog() == DialogResult.OK)
                        {
                            // 4. Si el usuario guarda, le pasamos los datos NUEVOS al motor para actualizar
                            Erabiltzaile_kudeaketa kudeatzailea = new Erabiltzaile_kudeaketa();
                            if (kudeatzailea.AldatuErabiltzailea(idErabiltzailea, leihoa.Izena, leihoa.Pasahitza, leihoa.Rola, leihoa.Mintegia))
                            {
                                MessageBox.Show("Erabiltzailea ondo eguneratu da!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KargatuErabiltzaileak(); // Refrescamos la tabla
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
                MessageBox.Show("Mesedez, aukeratu erabiltzaile bat taulan aldatzeko.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAldatuGailua_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count > 0)
            {
                try
                {
                    // Leemos la tabla por posiciones para evitar los errores de "Unknown column"
                    int idGailua = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells[0].Value);
                    string mota = dgvGailuak.SelectedRows[0].Cells[1].Value.ToString();
                    string marka = dgvGailuak.SelectedRows[0].Cells[2].Value.ToString();
                    string gela = dgvGailuak.SelectedRows[0].Cells[3].Value.ToString();

                    // La fecha requiere un poco de cuidado al leerla
                    DateTime data;
                    if (!DateTime.TryParse(dgvGailuak.SelectedRows[0].Cells[4].Value.ToString(), out data))
                    {
                        data = DateTime.Now;
                    }

                    // Los campos que pueden estar vacíos llevan un ? para que no den error
                    string ram = dgvGailuak.SelectedRows[0].Cells[6].Value?.ToString() ?? "";
                    string rom = dgvGailuak.SelectedRows[0].Cells[7].Value?.ToString() ?? "";
                    string cpu = dgvGailuak.SelectedRows[0].Cells[8].Value?.ToString() ?? "";
                    string kolore = dgvGailuak.SelectedRows[0].Cells[9].Value?.ToString() ?? "";

                    // Abrimos tu nueva ventana mágica y le pasamos todo
                    using (FGailua leihoa = new FGailua(mota, marka, gela, data, ram, rom, cpu, kolore))
                    {
                        if (leihoa.ShowDialog() == DialogResult.OK)
                        {
                            Gailu_kudeatzailea kudeatzailea = new Gailu_kudeatzailea();
                            bool ondoGordeta = false;

                            // Decidimos a qué función de Update llamar
                            if (mota == "Ordenagailua")
                            {
                                ondoGordeta = kudeatzailea.AldatuOrdenagailua(idGailua, leihoa.Marka, leihoa.ErosteData, leihoa.Gela, leihoa.RAM, leihoa.ROM, leihoa.CPU);
                            }
                            else if (mota == "Inprimagailua")
                            {
                                ondoGordeta = kudeatzailea.AldatuInprimagailua(idGailua, leihoa.Marka, leihoa.ErosteData, leihoa.Gela, leihoa.Koloretakoa);
                            }

                            if (ondoGordeta)
                            {
                                MessageBox.Show("Gailua ondo eguneratu da!", "Zorionak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                KargatuGailuak(); // Refrescamos la tabla
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
    }
}
