using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;
using INBENT_VISUAL.Kudeatzaileak;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Hautatutako gailu baten matxuren historia osoa erakusten duen leihoa.
    /// Gainera, gailua 'Bajan' badago, horren arrazoia nabarmentzen du.
    /// </summary>
    public partial class FHistoriala : Form
    {
        #region ERAIKITZAILEA
        /// <summary>
        /// Historialaren leihoa abiarazten du gailuaren datuekin.
        /// </summary>
        /// <param name="idGailua">Gailuaren datu-baseko identifikatzailea.</param>
        /// <param name="gailuInfo">Gailuaren marka eta gela (leihoaren tituluan erakusteko).</param>
        /// <param name="egoera">Gailuaren uneko egoera (Aktibo, Bajan, etab.).</param>
        public FHistoriala(int idGailua, string gailuInfo, string egoera)
        {
            InitializeComponent();
            lblTituloa.Text = $"📚 Historiala: {gailuInfo}";

            // Funtzio berria deitzen dugu POO erabiliz
            KargatuHistorialaPOO(idGailua, egoera);
        }
        #endregion

        #region DATUAK KARGATZEKO FUNTZIOAK
        /// <summary>
        /// Aukeratutako gailuaren matxuren historiala datu-basetik ekarri eta DataGridView-an 
        /// erakusten du (LINQ erabiliz formatua emanez). Gailua bajan badago, baja horren arrazoia 
        /// bilatzen du azpititulu gorrian erakusteko.
        /// </summary>
        /// <param name="id">Gailuaren identifikatzailea.</param>
        /// <param name="egoera">Gailuaren egungo egoera (Aktibo, Bajan...).</param>
        private void KargatuHistorialaPOO(int id, string egoera)
        {
            try
            {
                Matxura_kudeatzailea matxuraKudeatzailea = new Matxura_kudeatzailea();
                List<Matxura> historiala = matxuraKudeatzailea.LortuGailuarenHistoriala(id);

                if (historiala.Count > 0)
                {
                    var taulaFormatua = historiala.Select(m => new
                    {
                        Apurtze_Data = m.MatxuraData.ToString("dd/MM/yyyy"),
                        Arazoa = m.Deskribapena,
                        Konponketa_Data = m.KonponketaData.HasValue ? m.KonponketaData.Value.ToString("dd/MM/yyyy") : "Konpondu gabe",
                        Irtenbidea = string.IsNullOrEmpty(m.KonponketaDeskribapena) ? "Konpondu gabe" : m.KonponketaDeskribapena
                    }).ToList();

                    dgvHistoriala.DataSource = taulaFormatua;
                }
                else
                {
                    dgvHistoriala.DataSource = null;
                }

                string egoeraGarbita = egoera.ToLower().Trim();
                if (egoeraGarbita == "bajan" || egoeraGarbita == "baja")
                {
                    Gailu_kudeatzailea gailuKudeatzailea = new Gailu_kudeatzailea();
                    string arrazoia = gailuKudeatzailea.LortuBajaArrazoia(id);
                    lblBajaArrazoia.Text = $"🔴 BAJAN: {arrazoia}";
                    lblBajaArrazoia.Visible = true;
                }
                else
                {
                    lblBajaArrazoia.Visible = false;
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