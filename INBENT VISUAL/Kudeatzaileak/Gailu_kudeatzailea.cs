using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// GAILUA, ORDENAGAILUA eta INPRIMAGAILUA taulen eragiketak (CRUD) kudeatzen dituen klasea.
    /// Herentzia eta Polimorfismoa kudeatzen ditu datu-basearen mailan.
    /// </summary>
    public class Gailu_kudeatzailea
    {
        #region ALDAGAI OROKORRAK
        private DBkonexioa db = new DBkonexioa();
        #endregion

        #region IRAKURRI (READ)
        /// <summary>
        /// Gailu guztiak datu-basetik irakurri eta haien motaren arabera (Ordenagailua/Inprimagailua) objektu zerrenda bat itzultzen du (Polimorfismoa).
        /// </summary>
        public List<Gailua> GailuakErakutsiPOO()
        {
            List<Gailua> inbentarioa = new List<Gailua>();

            // Gailu guztiak ekartzen ditugu, beraien taula espezifikoekin (LEFT JOIN) lotuz
            string query = @"SELECT g.id_gailua, g.marka, g.gela, g.eroste_data, g.egoera, g.baja_arrazoia,
                                    o.id_gailua as pc_id, o.ram, o.rom, o.cpu,
                                    i.id_gailua as inp_id, i.koloretakoa
                             FROM GAILUA g
                             LEFT JOIN ORDENAGAILUA o ON g.id_gailua = o.id_gailua
                             LEFT JOIN INPRIMAGAILUA i ON g.id_gailua = i.id_gailua";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // 1. ORDENAGAILUA den egiaztatzen dugu
                        if (!reader.IsDBNull(reader.GetOrdinal("pc_id")))
                        {
                            Ordenagailua pc = new Ordenagailua();
                            pc.IdGailua = Convert.ToInt32(reader["id_gailua"]);
                            pc.Marka = reader["marka"].ToString();
                            pc.Gela = reader["gela"].ToString();
                            pc.ErosteData = Convert.ToDateTime(reader["eroste_data"]);
                            pc.Egoera = reader["egoera"].ToString();
                            pc.BajaArrazoia = reader["baja_arrazoia"]?.ToString() ?? "";
                            pc.Ram = reader["ram"].ToString();
                            pc.Rom = reader["rom"].ToString();
                            pc.Cpu = reader["cpu"].ToString();

                            inbentarioa.Add(pc); // Zerrenda orokorrera gehitu
                        }
                        // 2. INPRIMAGAILUA den egiaztatzen dugu
                        else if (!reader.IsDBNull(reader.GetOrdinal("inp_id")))
                        {
                            Inprimagailua inp = new Inprimagailua();
                            inp.IdGailua = Convert.ToInt32(reader["id_gailua"]);
                            inp.Marka = reader["marka"].ToString();
                            inp.Gela = reader["gela"].ToString();
                            inp.ErosteData = Convert.ToDateTime(reader["eroste_data"]);
                            inp.Egoera = reader["egoera"].ToString();
                            inp.BajaArrazoia = reader["baja_arrazoia"]?.ToString() ?? "";
                            inp.Koloretakoa = reader["koloretakoa"].ToString();

                            inbentarioa.Add(inp); // Zerrenda orokorrera gehitu
                        }
                    }
                    reader.Close();
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gailuak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return inbentarioa;
        }

        /// <summary>
        /// Gailu aktiboak soilik itzultzen ditu (Matxurak sortzeko desplegablean erabiltzeko).
        /// </summary>
        public DataTable GailuAktiboakErakutsi()
        {
            DataTable taula = new DataTable();
            string query = "SELECT id_gailua, CONCAT(id_gailua, ' - ', marka, ' (', gela, ')') AS info FROM GAILUA WHERE egoera = 'aktibo'";
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(taula);
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gailu aktiboak kargatzean: " + ex.Message);
            }
            return taula;
        }

        /// <summary>
        /// Baja egoeran dagoen gailu baten bajaren arrazoia lortzen du.
        /// </summary>
        public string LortuBajaArrazoia(int idGailua)
        {
            string arrazoia = "Ez da zehaztu";
            string query = "SELECT baja_arrazoia FROM GAILUA WHERE id_gailua = @id";
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", idGailua);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value && !string.IsNullOrWhiteSpace(result.ToString()))
                    {
                        arrazoia = result.ToString();
                    }
                    db.Itxi();
                }
            }
            catch { }
            return arrazoia;
        }
        #endregion

        #region GEHITU (CREATE)
        /// <summary>
        /// Ordenagailu berri bat datu-basean gordetzen du (GAILUA eta ORDENAGAILUA taulak eguneratuz).
        /// </summary>
        public bool GehituOrdenagailua(Ordenagailua pc)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // 1. Gailu orokorra sortu eta bere ID-a lortu
                    string queryComun = "INSERT INTO GAILUA (mota, marka, eroste_data, gela, egoera) VALUES ('Ordenagailua', @marka, @data, @gela, 'aktibo'); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd1 = new MySqlCommand(queryComun, konexioa);
                    cmd1.Parameters.AddWithValue("@marka", pc.Marka);
                    cmd1.Parameters.AddWithValue("@data", pc.ErosteData);
                    cmd1.Parameters.AddWithValue("@gela", pc.Gela);

                    int nireId = Convert.ToInt32(cmd1.ExecuteScalar());

                    // 2. Hardware datuak taula espezifikoan gorde lortutako ID-arekin
                    string queryTecnica = "INSERT INTO ORDENAGAILUA (id_gailua, ram, rom, cpu) VALUES (@id, @ram, @rom, @cpu)";
                    MySqlCommand cmd2 = new MySqlCommand(queryTecnica, konexioa);
                    cmd2.Parameters.AddWithValue("@id", nireId);
                    cmd2.Parameters.AddWithValue("@ram", pc.Ram);
                    cmd2.Parameters.AddWithValue("@rom", pc.Rom);
                    cmd2.Parameters.AddWithValue("@cpu", pc.Cpu);

                    cmd2.ExecuteNonQuery();
                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gehitzerakoan: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Inprimagailu berri bat datu-basean gordetzen du.
        /// </summary>
        public bool GehituInprimagailua(Inprimagailua inprimagailua)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string queryGailua = "INSERT INTO GAILUA (mota, marka, eroste_data, gela, egoera) VALUES ('Inprimagailua', @marka, @data, @gela, 'aktibo'); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdGailua = new MySqlCommand(queryGailua, konexioa);
                    cmdGailua.Parameters.AddWithValue("@marka", inprimagailua.Marka);
                    cmdGailua.Parameters.AddWithValue("@data", inprimagailua.ErosteData.ToString("yyyy-MM-dd"));
                    cmdGailua.Parameters.AddWithValue("@gela", inprimagailua.Gela);

                    int idGailuBerria = Convert.ToInt32(cmdGailua.ExecuteScalar());

                    string queryInp = "INSERT INTO INPRIMAGAILUA (id_gailua, koloretakoa) VALUES (@id, @kolorea)";
                    MySqlCommand cmdInp = new MySqlCommand(queryInp, konexioa);
                    cmdInp.Parameters.AddWithValue("@id", idGailuBerria);
                    cmdInp.Parameters.AddWithValue("@kolorea", inprimagailua.Koloretakoa);

                    cmdInp.ExecuteNonQuery();
                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea inprimagailua sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region ALDATU (UPDATE)
        /// <summary>
        /// Dauden ordenagailu baten datuak eguneratzen ditu (Bi taulak).
        /// </summary>
        public bool AldatuOrdenagailua(Ordenagailua pc)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string queryComun = "UPDATE GAILUA SET marka = @marka, eroste_data = @data, gela = @gela WHERE id_gailua = @id";
                    MySqlCommand cmd1 = new MySqlCommand(queryComun, konexioa);
                    cmd1.Parameters.AddWithValue("@marka", pc.Marka);
                    cmd1.Parameters.AddWithValue("@data", pc.ErosteData);
                    cmd1.Parameters.AddWithValue("@gela", pc.Gela);
                    cmd1.Parameters.AddWithValue("@id", pc.IdGailua);
                    cmd1.ExecuteNonQuery();

                    string queryTecnica = "UPDATE ORDENAGAILUA SET ram = @ram, rom = @rom, cpu = @cpu WHERE id_gailua = @id";
                    MySqlCommand cmd2 = new MySqlCommand(queryTecnica, konexioa);
                    cmd2.Parameters.AddWithValue("@ram", pc.Ram);
                    cmd2.Parameters.AddWithValue("@rom", pc.Rom);
                    cmd2.Parameters.AddWithValue("@cpu", pc.Cpu);
                    cmd2.Parameters.AddWithValue("@id", pc.IdGailua);

                    int lerroak = cmd2.ExecuteNonQuery();
                    db.Itxi();
                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea ordenagailua aldatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Dauden inprimagailu baten datuak eguneratzen ditu.
        /// </summary>
        public bool AldatuInprimagailua(Inprimagailua inprimagailua)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string queryComun = "UPDATE GAILUA SET marka = @marka, eroste_data = @data, gela = @gela WHERE id_gailua = @id";
                    MySqlCommand cmd1 = new MySqlCommand(queryComun, konexioa);
                    cmd1.Parameters.AddWithValue("@marka", inprimagailua.Marka);
                    cmd1.Parameters.AddWithValue("@data", inprimagailua.ErosteData);
                    cmd1.Parameters.AddWithValue("@gela", inprimagailua.Gela);
                    cmd1.Parameters.AddWithValue("@id", inprimagailua.IdGailua);
                    cmd1.ExecuteNonQuery();

                    string queryTecnica = "UPDATE INPRIMAGAILUA SET koloretakoa = @kolore WHERE id_gailua = @id";
                    MySqlCommand cmd2 = new MySqlCommand(queryTecnica, konexioa);
                    cmd2.Parameters.AddWithValue("@kolore", inprimagailua.Koloretakoa);
                    cmd2.Parameters.AddWithValue("@id", inprimagailua.IdGailua);

                    int lerroak = cmd2.ExecuteNonQuery();
                    db.Itxi();
                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea inprimagailua aldatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region BAJA EMAN (SOFT DELETE)
        /// <summary>
        /// Gailu baten egoera 'bajan' bezala jartzen du eta arrazoia gordetzen du.
        /// Ez da datu-basetik ezabatzen, historiala ez galtzeko.
        /// </summary>
        public bool BajaEman(int idGailua, string arrazoia)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = "UPDATE GAILUA SET egoera = 'bajan', baja_arrazoia = @arrazoia WHERE id_gailua = @id";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", idGailua);
                    cmd.Parameters.AddWithValue("@arrazoia", arrazoia);

                    int lerroak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gailuari baja ematean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}