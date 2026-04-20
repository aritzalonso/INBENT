using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using INBENT_VISUAL.Kudeatzaileak;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FHistoriala : Form
    {
        DBkonexioa db = new DBkonexioa();

        // 1. Añadimos el nuevo parámetro "egoera" al constructor
        public FHistoriala(int idGailua, string gailuInfo, string egoera)
        {
            InitializeComponent();
            lblTituloa.Text = $"📚 Historiala: {gailuInfo}";

            // 2. Le pasamos el estado a la función que busca en la base de datos
            KargatuHistoriala(idGailua, egoera);
        }

        // 3. Modificamos la función para que reciba el estado
        private void KargatuHistoriala(int id, string egoera)
        {
            DataTable taula = new DataTable();

            // Buscamos TODAS las averías de este ID
            string query = @"SELECT 
                                matxura_data AS 'Apurtze Data',
                                deskribapena AS 'Arazoa',
                                IFNULL(konponketa_data, 'Pendiente') AS 'Konponketa Data',
                                IFNULL(konponketa_deskribapena, 'Pendiente') AS 'Irtenbidea'
                             FROM MATXURA 
                             WHERE id_gailua = @id
                             ORDER BY matxura_data DESC";
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(taula);
                    db.Itxi();

                    dgvHistoriala.DataSource = taula;

                    // 4. Aquí hacemos la magia inteligente con el mensaje
                    if (taula.Rows.Count == 0)
                    {
                        string egoeraGarbita = egoera.ToLower().Trim();

                        if (egoeraGarbita == "bajan" || egoeraGarbita == "baja")
                        {
                            string arrazoia = "Ez da zehaztu"; // Texto por defecto por si el campo está vacío (NULL)

                            // Hacemos una consulta rápida a la tabla GAILUA para leer el motivo
                            try
                            {
                                MySqlConnection konexioaArrazoia = db.Ireki();
                                if (konexioaArrazoia != null)
                                {
                                    string queryArrazoia = "SELECT baja_arrazoia FROM GAILUA WHERE id_gailua = @id";
                                    MySqlCommand cmdArrazoia = new MySqlCommand(queryArrazoia, konexioaArrazoia);
                                    cmdArrazoia.Parameters.AddWithValue("@id", id);

                                    object result = cmdArrazoia.ExecuteScalar();

                                    // Si el resultado no es nulo y tiene texto, lo guardamos
                                    if (result != null && result != DBNull.Value && !string.IsNullOrWhiteSpace(result.ToString()))
                                    {
                                        arrazoia = result.ToString();
                                    }
                                    db.Itxi();
                                }
                            }
                            catch { /* Si hay algún error, simplemente usamos el texto por defecto */ }

                            // Mostramos el mensaje con el salto de línea (\n\n) y el motivo
                            MessageBox.Show($"Gailu honek ez du inoiz matxurarik izan, baina gaur egun BAJAN dago.\n\nBaja arrazoia: {arrazoia}",
                                            "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gailu honek ez du matxurarik eduki inoiz. Ezin hobeto dabil!",
                                            "Informazioa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea historiala kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}