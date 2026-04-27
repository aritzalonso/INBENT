using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// ERABILTZAILEA taularen datu-baseko eragiketak (CRUD) eta segurtasuna (Login) kudeatzen dituen klasea.
    /// Datu-basearen arkitektura (Backend) eta interfazearen (Frontend) arteko POO zubi-lana egiten du.
    /// </summary>
    public class Erabiltzaile_kudeaketa
    {
        #region ALDAGAI OROKORRAK
        private DBkonexioa db = new DBkonexioa();
        #endregion

        #region IRAKURRI (READ)
        /// <summary>
        /// Datu-basetik erabiltzaile guztiak irakurri eta objektu zerrenda gisa itzultzen ditu (JOIN bidez rol eta mintegi izenak lortuz).
        /// </summary>
        /// <returns>Erabiltzailea objektuen zerrenda (List).</returns>
        public List<Erabiltzailea> ErabiltzaileakErakutsiPOO()
        {
            List<Erabiltzailea> lista = new List<Erabiltzailea>();

            string query = @"SELECT e.id_erabiltzailea, e.izena, e.pasahitza, 
                                    r.izena AS 'Rola', m.izena AS 'Mintegia'
                             FROM ERABILTZAILEA e
                             JOIN ROLA r ON e.id_rola = r.id_rola
                             JOIN MINTEGIA m ON e.id_mintegia = m.id_mintegia";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Erabiltzailea erab = new Erabiltzailea();
                        erab.IdErabiltzailea = Convert.ToInt32(reader["id_erabiltzailea"]);
                        erab.Izena = reader["izena"].ToString();
                        erab.Pasahitza = reader["pasahitza"].ToString();
                        erab.RolIzena = reader["Rola"].ToString();
                        erab.MintegiIzena = reader["Mintegia"].ToString();

                        lista.Add(erab);
                    }
                    reader.Close();
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzaileak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }
        #endregion

        #region BALIDAZIOAK (POO)
        /// <summary>
        /// Egiaztatzen du ea mintegi batek jada "Mintegi burua" rolarekin erabiltzaile bat duen (Backend ID bidezko balidazioa).
        /// </summary>
        /// <param name="idMintegi">Mintegiaren datu-baseko ID-a.</param>
        /// <param name="saihestuIdErabiltzailea">Aldaketetan, erabiltzailea bera ez kontatzeko ID-a (lehenetsita -1).</param>
        /// <returns>Egia (true) jada burua existitzen bada.</returns>
        public bool MintegiakBuruaDauka(int idMintegi, int saihestuIdErabiltzailea = -1)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = @"SELECT COUNT(*) FROM ERABILTZAILEA e 
                                     INNER JOIN ROLA r ON e.id_rola = r.id_rola 
                                     WHERE e.id_mintegia = @idMintegi 
                                     AND r.izena = 'Mintegi burua' 
                                     AND e.id_erabiltzailea != @idSaihestu";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@idMintegi", idMintegi);
                    cmd.Parameters.AddWithValue("@idSaihestu", saihestuIdErabiltzailea);

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

        /// <summary>
        /// Interfazearentzako balidazioa (Frontend). Izenak jasota egiaztatzen du ea mintegiak baduen buru bat jada.
        /// </summary>
        /// <param name="mintegiIzena">Aukeratutako mintegiaren izena.</param>
        /// <param name="jatorrizkoErabiltzaileIzena">Editatzen ari den erabiltzailearen jatorrizko izena (bere burua ez kontatzeko).</param>
        /// <returns>Egia (true) mintegiak jada burua badu.</returns>
        public bool MintegiakBaduBuruaIzenekin(string mintegiIzena, string jatorrizkoErabiltzaileIzena)
        {
            try
            {
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
        #endregion

        #region GEHITU ETA ALDATU (CREATE & UPDATE)
        /// <summary>
        /// Datu-basean erabiltzaile berri bat sortzen du. Aurretik rol eta mintegi bikoiztuen balidazioak egiten ditu.
        /// </summary>
        /// <param name="erabiltzailea">Gordeko den Erabiltzailea objektua.</param>
        /// <returns>Egia (true) ondo gorde bada.</returns>
        public bool GehituErabiltzailea(Erabiltzailea erabiltzailea)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    int idRola = -1;
                    string queryRol = "SELECT id_rola FROM ROLA WHERE izena = @rolIzena";
                    MySqlCommand cmdRol = new MySqlCommand(queryRol, konexioa);
                    cmdRol.Parameters.AddWithValue("@rolIzena", erabiltzailea.RolIzena);
                    object resultRol = cmdRol.ExecuteScalar();
                    if (resultRol != null) idRola = Convert.ToInt32(resultRol);

                    int idMintegi = -1;
                    string queryMintegi = "SELECT id_mintegia FROM MINTEGIA WHERE izena = @mintegiIzena";
                    MySqlCommand cmdMintegi = new MySqlCommand(queryMintegi, konexioa);
                    cmdMintegi.Parameters.AddWithValue("@mintegiIzena", erabiltzailea.MintegiIzena);
                    object resultMintegi = cmdMintegi.ExecuteScalar();
                    if (resultMintegi != null) idMintegi = Convert.ToInt32(resultMintegi);

                    if (idRola == -1 || idMintegi == -1)
                    {
                        MessageBox.Show("Errorea: Ez da aurkitu Rola edo Mintegia datu-basean.", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Itxi();
                        return false;
                    }

                    if (erabiltzailea.RolIzena == "Mintegi burua")
                    {
                        if (MintegiakBuruaDauka(idMintegi))
                        {
                            MessageBox.Show($"'{erabiltzailea.MintegiIzena}' mintegiak badauka jada Mintegi buru bat. Ezin dira bi egon.", "Muga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            db.Itxi();
                            return false;
                        }
                    }

                    string queryInsert = "INSERT INTO ERABILTZAILEA (izena, pasahitza, id_rola, id_mintegia) VALUES (@izena, @pasahitza, @idRola, @idMintegi)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert, konexioa);
                    cmdInsert.Parameters.AddWithValue("@izena", erabiltzailea.Izena);
                    cmdInsert.Parameters.AddWithValue("@pasahitza", erabiltzailea.Pasahitza);
                    cmdInsert.Parameters.AddWithValue("@idRola", idRola);
                    cmdInsert.Parameters.AddWithValue("@idMintegi", idMintegi);

                    int lerroak = cmdInsert.ExecuteNonQuery();
                    db.Itxi();

                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Existitzen den erabiltzaile baten datuak eguneratzen ditu (UPDATE).
        /// </summary>
        /// <param name="erabiltzailea">Aldatuko den Erabiltzailea objektua.</param>
        /// <returns>Egia (true) eguneraketa arrakastatsua izan bada.</returns>
        public bool AldatuErabiltzailea(Erabiltzailea erabiltzailea)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    int idRola = -1;
                    string queryRol = "SELECT id_rola FROM ROLA WHERE izena = @rolIzena";
                    MySqlCommand cmdRol = new MySqlCommand(queryRol, konexioa);
                    cmdRol.Parameters.AddWithValue("@rolIzena", erabiltzailea.RolIzena);
                    object resultRol = cmdRol.ExecuteScalar();
                    if (resultRol != null) idRola = Convert.ToInt32(resultRol);

                    int idMintegi = -1;
                    string queryMintegi = "SELECT id_mintegia FROM MINTEGIA WHERE izena = @mintegiIzena";
                    MySqlCommand cmdMintegi = new MySqlCommand(queryMintegi, konexioa);
                    cmdMintegi.Parameters.AddWithValue("@mintegiIzena", erabiltzailea.MintegiIzena);
                    object resultMintegi = cmdMintegi.ExecuteScalar();
                    if (resultMintegi != null) idMintegi = Convert.ToInt32(resultMintegi);

                    if (idRola == -1 || idMintegi == -1)
                    {
                        MessageBox.Show("Errorea: Ez da aurkitu Rola edo Mintegia datu-basean.", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Itxi();
                        return false;
                    }

                    if (erabiltzailea.RolIzena == "Mintegi burua")
                    {
                        if (MintegiakBuruaDauka(idMintegi, erabiltzailea.IdErabiltzailea))
                        {
                            MessageBox.Show($"'{erabiltzailea.MintegiIzena}' mintegiak badauka jada Mintegi buru bat.", "Muga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            db.Itxi();
                            return false;
                        }
                    }

                    string queryUpdate = "UPDATE ERABILTZAILEA SET izena = @izena, pasahitza = @pasahitza, id_rola = @idRola, id_mintegia = @idMintegi WHERE id_erabiltzailea = @id";
                    MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, konexioa);
                    cmdUpdate.Parameters.AddWithValue("@izena", erabiltzailea.Izena);
                    cmdUpdate.Parameters.AddWithValue("@pasahitza", erabiltzailea.Pasahitza);
                    cmdUpdate.Parameters.AddWithValue("@idRola", idRola);
                    cmdUpdate.Parameters.AddWithValue("@idMintegi", idMintegi);
                    cmdUpdate.Parameters.AddWithValue("@id", erabiltzailea.IdErabiltzailea);

                    int lerroak = cmdUpdate.ExecuteNonQuery();
                    db.Itxi();

                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea aldatzean:\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region EZABATU (DELETE)
        /// <summary>
        /// Erabiltzaile bat datu-basetik ezabatzen du bere ID-aren bidez.
        /// </summary>
        /// <param name="id_erabiltzailea">Ezabatu nahi den erabiltzailearen azaleratzailea.</param>
        /// <returns>Egia (true) ondo ezabatu bada.</returns>
        public bool EzabatuErabiltzailea(int id_erabiltzailea)
        {
            string query = "DELETE FROM ERABILTZAILEA WHERE id_erabiltzailea = @id";
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", id_erabiltzailea);

                    int errenkadak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea ezabatzean:\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region SEGURTASUNA (LOGIN ETA PASAHITZA)
        /// <summary>
        /// Erabiltzailearen kredentzialak (Izena eta Pasahitza) egiaztatzen ditu.
        /// </summary>
        /// <param name="izena">Erabiltzailearen izena.</param>
        /// <param name="pasahitza">Sartutako pasahitza.</param>
        /// <returns>Zuzena bada, rolaren izena itzultzen du. Bestela null.</returns>
        public string EgiaztatuLogin(string izena, string pasahitza)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = "SELECT r.izena FROM ERABILTZAILEA e INNER JOIN ROLA r ON e.id_rola = r.id_rola WHERE e.izena = @izena AND e.pasahitza = @pasahitza";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@izena", izena);
                    cmd.Parameters.AddWithValue("@pasahitza", pasahitza);

                    object result = cmd.ExecuteScalar();
                    db.Itxi();

                    if (result != null) return result.ToString();
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea datu-basearekin konektatzean:\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Erabiltzaile jakin baten pasahitza aldatzen du datu-basean.
        /// </summary>
        /// <param name="izena">Pasahitza aldatu nahi duen erabiltzailearen izena.</param>
        /// <param name="pasahitzaBerria">Ezarri nahi den pasahitz berria.</param>
        /// <returns>Egia (true) ondo eguneratu bada.</returns>
        public bool AldatuPasahitza(string izena, string pasahitzaBerria)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = "UPDATE ERABILTZAILEA SET pasahitza = @pasahitza WHERE izena = @izena";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@pasahitza", pasahitzaBerria);
                    cmd.Parameters.AddWithValue("@izena", izena);

                    int errenkadak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea pasahitza aldatzean:\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Erabiltzaile baten izena emanda, zein mintegikoa den itzultzen du.
        /// </summary>
        /// <param name="izena">Erabiltzailearen izena.</param>
        /// <returns>Mintegiaren izena.</returns>
        public string LortuMintegia(string izena)
        {
            string mintegiIzena = "Esleitu gabe";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = @"SELECT m.izena 
                                     FROM ERABILTZAILEA e 
                                     LEFT JOIN MINTEGIA m ON e.id_mintegia = m.id_mintegia 
                                     WHERE e.izena = @izena";

                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@izena", izena);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        mintegiIzena = result.ToString();
                    }

                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorea mintegia lortzean: " + ex.Message);
            }

            return mintegiIzena;
        }
    }
}