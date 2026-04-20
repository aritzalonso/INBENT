using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// ERABILTZAILEA taularen datu-baseko eragiketak (CRUD) kudeatzen dituen klasea.
    /// </summary>
    public class Erabiltzaile_kudeaketa
    {
        #region ALDAGAI OROKORRAK
        // Datu-basearekiko konexioa kudeatzeko objektua
        private DBkonexioa db = new DBkonexioa();
        #endregion

        #region IRAKURRI (READ)
        /// <summary>
        /// Datu-basetik erabiltzaile guztiak irakurri eta objektu zerrenda gisa itzultzen ditu.
        /// </summary>
        /// <returns>Erabiltzailea objektuen zerrenda (List).</returns>
        public List<Erabiltzailea> ErabiltzaileakErakutsiPOO()
        {
            List<Erabiltzailea> lista = new List<Erabiltzailea>();

            // JOIN erabiltzen dugu Rola eta Mintegiaren IZENAK lortzeko, ez bakarrik zenbakiak (ID)
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

        #region GEHITU ETA ALDATU (CREATE & UPDATE)
        /// <summary>
        /// Datu-basean erabiltzaile berri bat sortzen du objektu baten datuak erabiliz.
        /// </summary>
        /// <param name="erabiltzailea">Gordeko den Erabiltzailea objektua.</param>
        /// <returns>Egia (true) ondo gorde bada, bestela Gezurra (false).</returns>
        public bool GehituErabiltzailea(Erabiltzailea erabiltzailea)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // 1. Rolaren ID-a bilatu izenaren arabera
                    int idRola = -1;
                    string queryRol = "SELECT id_rola FROM ROLA WHERE izena = @rolIzena";
                    MySqlCommand cmdRol = new MySqlCommand(queryRol, konexioa);
                    cmdRol.Parameters.AddWithValue("@rolIzena", erabiltzailea.RolIzena);
                    object resultRol = cmdRol.ExecuteScalar();
                    if (resultRol != null) idRola = Convert.ToInt32(resultRol);

                    // 2. Mintegiaren ID-a bilatu izenaren arabera
                    int idMintegi = -1;
                    string queryMintegi = "SELECT id_mintegia FROM MINTEGIA WHERE izena = @mintegiIzena";
                    MySqlCommand cmdMintegi = new MySqlCommand(queryMintegi, konexioa);
                    cmdMintegi.Parameters.AddWithValue("@mintegiIzena", erabiltzailea.MintegiIzena);
                    object resultMintegi = cmdMintegi.ExecuteScalar();
                    if (resultMintegi != null) idMintegi = Convert.ToInt32(resultMintegi);

                    // Balidazioa
                    if (idRola == -1 || idMintegi == -1)
                    {
                        MessageBox.Show("Errorea: Ez da aurkitu Rola edo Mintegia datu-basean.", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Itxi();
                        return false;
                    }

                    // 3. Txertaketa (INSERT) burutu
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
        /// Dauden erabiltzaile baten datuak eguneratzen ditu.
        /// </summary>
        /// <param name="erabiltzailea">Eguneratuko den Erabiltzailea objektua.</param>
        /// <returns>Egia (true) ondo eguneratu bada, bestela Gezurra (false).</returns>
        public bool AldatuErabiltzailea(Erabiltzailea erabiltzailea)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // 1. Rolaren ID-a bilatu
                    int idRola = -1;
                    string queryRol = "SELECT id_rola FROM ROLA WHERE izena = @rolIzena";
                    MySqlCommand cmdRol = new MySqlCommand(queryRol, konexioa);
                    cmdRol.Parameters.AddWithValue("@rolIzena", erabiltzailea.RolIzena);
                    object resultRol = cmdRol.ExecuteScalar();
                    if (resultRol != null) idRola = Convert.ToInt32(resultRol);

                    // 2. Mintegiaren ID-a bilatu
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

                    // 3. Eguneraketa (UPDATE) burutu
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

        #region SEGURTASUNA (LOGIN)
        /// <summary>
        /// Erabiltzailearen kredentzialak (Izena eta Pasahitza) egiaztatzen ditu.
        /// Zuzenak badira, bere rolaren izena itzultzen du sistemara sartzeko.
        /// </summary>
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

                    // Datuak ondo badaude, rolaren izena itzultzen du (adib: "IKT Arduraduna")
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
        #endregion
    }
}