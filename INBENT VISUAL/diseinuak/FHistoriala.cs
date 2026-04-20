using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;
using INBENT_VISUAL.Kudeatzaileak;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FHistoriala : Form
    {
        #region ERAIKITZAILEA
        public FHistoriala(int idGailua, string gailuInfo, string egoera)
        {
            InitializeComponent();
            lblTituloa.Text = $"📚 Historiala: {gailuInfo}";

            // Funtzio berria deitzen dugu POO erabiliz
            KargatuHistorialaPOO(idGailua, egoera);
        }
        #endregion

        #region DATUAK KARGATZEA (POO)
        /// <summary>
        /// Kudeatzaileei objektu zerrendak eskatzen dizkie SQL zuzenean erabili gabe.
        /// </summary>
        private void KargatuHistorialaPOO(int id, string egoera)
        {
            try
            {
                // 1. Matxuren motorrari historiala (objektu zerrenda) eskatzen diogu
                Matxura_kudeatzailea matxuraKudeatzailea = new Matxura_kudeatzailea();
                List<Matxura> historiala = matxuraKudeatzailea.LortuGailuarenHistoriala(id);

                if (historiala.Count > 0)
                {
                    // Zerrenda badago, formatua ematen diogu taulan ondo ikusteko
                    var taulaFormatua = historiala.Select(m => new
                    {
                        Apurtze_Data = m.MatxuraData.ToString("dd/MM/yyyy"),
                        Arazoa = m.Deskribapena,
                        Konponketa_Data = m.KonponketaData.HasValue ? m.KonponketaData.Value.ToString("dd/MM/yyyy") : "Pendiente",
                        Irtenbidea = string.IsNullOrEmpty(m.KonponketaDeskribapena) ? "Pendiente" : m.KonponketaDeskribapena
                    }).ToList();

                    dgvHistoriala.DataSource = taulaFormatua;
                }
                else
                {
                    dgvHistoriala.DataSource = null;

                    // Si no tiene historial y NO está de baja, damos el mensaje de que todo va bien.
                    string egoeraBehinBihineko = egoera.ToLower().Trim();
                    if (egoeraBehinBihineko != "bajan" && egoeraBehinBihineko != "baja")
                    {
                        MessageBox.Show("Gailu honek ez du matxurarik eduki inoiz. Ezin hobeto dabil!",
                                        "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // 2. BUG-A KONPONDUTA: Gailua bajan badago, arrazoia eskatzen diogu Gailuen motorrari. BETI.
                string egoeraGarbita = egoera.ToLower().Trim();
                if (egoeraGarbita == "bajan" || egoeraGarbita == "baja")
                {
                    Gailu_kudeatzailea gailuKudeatzailea = new Gailu_kudeatzailea();
                    string arrazoia = gailuKudeatzailea.LortuBajaArrazoia(id);

                    // Mezua erakutsi (Matxurarik ez bazuen jada erakutsi dugula edo ez garrantzirik gabe, argi geratzeko)
                    if (historiala.Count == 0)
                    {
                        MessageBox.Show($"Gailu honek ez du inoiz matxurarik izan, baina gaur egun BAJAN dago.\n\nBaja arrazoia: {arrazoia}",
                                       "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Azpititulu berrian gehituko dugu testua, modu dotorean eta moztu gabe
                    lblBajaArrazoia.Text = $"🔴 BAJAN: {arrazoia}";
                    lblBajaArrazoia.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea historiala kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BOTOIEN EKINTZAK
        private void btnItxi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}