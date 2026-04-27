using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// MATXURA taularen datu-baseko eragiketak (CRUD) kudeatzen dituen klasea.
    /// Gailuen matxurak sortu, irakurri eta konpontzeaz arduratzen da, 
    /// gailuen egoera automatikoki eguneratuz transakzio logikoen bidez.
    /// </summary>
    public class Matxura_kudeatzailea
    {
        #region ALDAGAI OROKORRAK
        private DBkonexioa db = new DBkonexioa();
        #endregion

        #region IRAKURRI (READ)

        /// <summary>
        /// Oraindik konpondu gabe dauden matxuren zerrenda lortzen du datu-basetik.
        /// JOIN bidez gailuaren eta mintegiaren informazioa ere ekartzen du interfazean erakusteko.
        /// </summary>
        /// <returns>Konpondu gabeko Matxura objektuen zerrenda.</returns>
        public List<Matxura> MatxurakErakutsiPOO()
        {
            List<Matxura> lista = new List<Matxura>();

            string query = @"SELECT m.id_matxura, 
                                    m.matxura_data, 
                                    m.deskribapena, 
                                    m.id_gailua,
                                    g.marka, 
                                    g.gela,
                                    min.izena AS mintegi_izena
                             FROM MATXURA m
                             JOIN GAILUA g ON m.id_gailua = g.id_gailua
                             LEFT JOIN MINTEGIA min ON g.id_mintegia = min.id_mintegia
                             WHERE m.konponketa_data IS NULL";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Matxura matx = new Matxura();
                        matx.IdMatxura = Convert.ToInt32(reader["id_matxura"]);
                        matx.MatxuraData = Convert.ToDateTime(reader["matxura_data"]);
                        matx.Deskribapena = reader["deskribapena"].ToString();
                        matx.IdGailua = Convert.ToInt32(reader["id_gailua"]);

                        matx.GailuInfo = $"{reader["marka"]} ({reader["gela"]})";
                        matx.MintegiIzena = reader.IsDBNull(reader.GetOrdinal("mintegi_izena")) ? "Esleitu gabe" : reader["mintegi_izena"].ToString();

                        lista.Add(matx);
                    }
                    reader.Close();
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxurak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }

        /// <summary>
        /// Gailu zehatz baten matxuren historia osoa (konponduak eta konpondu gabeak) lortzen du, 
        /// dataren arabera ordenatuta (berriena lehenengo).
        /// </summary>
        /// <param name="idGailua">Historiala ikusi nahi den gailuaren identifikatzailea.</param>
        /// <returns>Gailu horren Matxura objektuen zerrenda.</returns>
        public List<Matxura> LortuGailuarenHistoriala(int idGailua)
        {
            List<Matxura> lista = new List<Matxura>();
            string query = @"SELECT matxura_data, deskribapena, konponketa_data, konponketa_deskribapena
                             FROM MATXURA
                             WHERE id_gailua = @id
                             ORDER BY matxura_data DESC";
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", idGailua);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Matxura m = new Matxura();
                        m.MatxuraData = Convert.ToDateTime(reader["matxura_data"]);
                        m.Deskribapena = reader["deskribapena"].ToString();

                        if (reader["konponketa_data"] != DBNull.Value)
                            m.KonponketaData = Convert.ToDateTime(reader["konponketa_data"]);
                        else
                            m.KonponketaData = null;

                        if (reader["konponketa_deskribapena"] != DBNull.Value)
                            m.KonponketaDeskribapena = reader["konponketa_deskribapena"].ToString();
                        else
                            m.KonponketaDeskribapena = "";

                        lista.Add(m);
                    }
                    reader.Close();
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea historiala irakurtzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        #endregion

        #region GEHITU ETA KONPONDU (CREATE & UPDATE)

        /// <summary>
        /// Matxura berri bat erregistratzen du (INSERT) eta aldi berean lotutako gailuaren 
        /// egoera 'matxuratua' izatera pasatzen du (UPDATE).
        /// </summary>
        /// <param name="matxura">Datu-basean gordeko den Matxura objektua.</param>
        /// <returns>Egia (true) ondo gorde bada, bestela Gezurra (false).</returns>
        public bool GehituMatxura(Matxura matxura)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string queryMatxura = "INSERT INTO MATXURA (matxura_data, deskribapena, id_gailua) VALUES (@data, @deskribapena, @idGailua)";
                    MySqlCommand cmdMatxura = new MySqlCommand(queryMatxura, konexioa);
                    cmdMatxura.Parameters.AddWithValue("@data", matxura.MatxuraData.ToString("yyyy-MM-dd"));
                    cmdMatxura.Parameters.AddWithValue("@deskribapena", matxura.Deskribapena);
                    cmdMatxura.Parameters.AddWithValue("@idGailua", matxura.IdGailua);

                    cmdMatxura.ExecuteNonQuery();

                    string queryEgoera = "UPDATE GAILUA SET egoera = 'matxuratua' WHERE id_gailua = @idGailua";
                    MySqlCommand cmdEgoera = new MySqlCommand(queryEgoera, konexioa);
                    cmdEgoera.Parameters.AddWithValue("@idGailua", matxura.IdGailua);

                    cmdEgoera.ExecuteNonQuery();

                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxura sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Existitzen den matxura bati konponketa-datuak (data eta azalpena) gehitzen dizkio (UPDATE) 
        /// eta gailua berriro 'aktibo' egoeran jartzen du.
        /// </summary>
        /// <param name="matxura">Konponketaren datuak dituen Matxura objektua.</param>
        /// <returns>Egia (true) ondo eguneratu bada, bestela Gezurra (false).</returns>
        public bool KonponduMatxura(Matxura matxura)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string queryMatxura = "UPDATE MATXURA SET konponketa_data = @data, konponketa_deskribapena = @desc WHERE id_matxura = @idMatxura";
                    MySqlCommand cmdMatxura = new MySqlCommand(queryMatxura, konexioa);

                    if (matxura.KonponketaData.HasValue)
                    {
                        cmdMatxura.Parameters.AddWithValue("@data", matxura.KonponketaData.Value.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        cmdMatxura.Parameters.AddWithValue("@data", DBNull.Value);
                    }

                    cmdMatxura.Parameters.AddWithValue("@desc", matxura.KonponketaDeskribapena);
                    cmdMatxura.Parameters.AddWithValue("@idMatxura", matxura.IdMatxura);
                    cmdMatxura.ExecuteNonQuery();

                    string queryEgoera = "UPDATE GAILUA SET egoera = 'aktibo' WHERE id_gailua = (SELECT id_gailua FROM MATXURA WHERE id_matxura = @idMatxura)";
                    MySqlCommand cmdEgoera = new MySqlCommand(queryEgoera, konexioa);
                    cmdEgoera.Parameters.AddWithValue("@idMatxura", matxura.IdMatxura);
                    cmdEgoera.ExecuteNonQuery();

                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxura konpontzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}