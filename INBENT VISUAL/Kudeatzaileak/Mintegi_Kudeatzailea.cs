using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using INBENT_VISUAL.Entitateak;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// MINTEGIA taularen datu-baseko eragiketak (CRUD) kudeatzen dituen klasea.
    /// </summary>
    public class Mintegi_Kudeatzailea
    {
        #region ALDAGAI OROKORRAK
        // Datu-basearekiko konexioa kudeatzeko objektua
        private DBkonexioa db = new DBkonexioa();
        #endregion

        #region IRAKURRI (READ)
        /// <summary>
        /// Datu-basetik mintegi guztiak irakurri eta objektu zerrenda gisa itzultzen ditu.
        /// </summary>
        /// <returns>Mintegia objektuen zerrenda (List).</returns>
        public List<Mintegia> MintegiakErakutsiPOO()
        {
            List<Mintegia> lista = new List<Mintegia>();
            string query = "SELECT id_mintegia, izena FROM MINTEGIA";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // POO: Objektua sortu eta betetzen dugu
                        Mintegia m = new Mintegia();
                        m.IdMintegia = reader.GetInt32("id_mintegia");
                        m.Izena = reader.GetString("izena");

                        lista.Add(m);
                    }
                    reader.Close();
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea mintegiak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        #endregion

        #region GEHITU (CREATE)
        /// <summary>
        /// Mintegi berri bat gordetzen du datu-basean.
        /// </summary>
        /// <param name="mintegia">Gordeko den Mintegia objektua.</param>
        /// <returns>Egia (true) ondo gorde bada, bestela Gezurra (false).</returns>
        public bool GehituMintegia(Mintegia mintegia)
        {
            string query = "INSERT INTO MINTEGIA (izena) VALUES (@izena)";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    // Objektuaren propietatea (Izena) erabiltzen dugu
                    cmd.Parameters.AddWithValue("@izena", mintegia.Izena);

                    int lerroak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea mintegia sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #region EZABATU ETA MUGITU (DELETE & REASSIGN)
        /// <summary>
        /// Mintegi bat ezabatzen du. Ezabatu aurretik gailuak/erabiltzaileak beste mintegi batera mugitzen ditu, 
        /// edo "Esleitu gabe" (NULL) uzten ditu idBerria 0 bada.
        /// </summary>
        /// <param name="idZaharra">Ezabatu nahi den mintegiaren ID-a.</param>
        /// <param name="idBerria">Mintegi berriaren ID-a (edo 0 "esleitu gabe" uzteko).</param>
        /// <returns>Egia (true) prozesu osoa ondo burutu bada.</returns>
        public bool EzabatuEtaMugitu(int idZaharra, int idBerria)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // idBerria 0 bada datu-basearentzat NULL izango da, bestela ID arrunta
                    object balioBerria = idBerria == 0 ? (object)DBNull.Value : idBerria;

                    // 1. Gailuak mintegi berrira pasa (edo NULL utzi)
                    string queryGailuak = "UPDATE GAILUA SET id_mintegia = @idBerria WHERE id_mintegia = @idZaharra";
                    MySqlCommand cmdGailuak = new MySqlCommand(queryGailuak, konexioa);
                    cmdGailuak.Parameters.AddWithValue("@idBerria", balioBerria);
                    cmdGailuak.Parameters.AddWithValue("@idZaharra", idZaharra);
                    cmdGailuak.ExecuteNonQuery();

                    // 2. Erabiltzaileak mintegi berrira pasa (edo NULL utzi)
                    string queryErabiltzaileak = "UPDATE ERABILTZAILEA SET id_mintegia = @idBerria WHERE id_mintegia = @idZaharra";
                    MySqlCommand cmdErabiltzaileak = new MySqlCommand(queryErabiltzaileak, konexioa);
                    cmdErabiltzaileak.Parameters.AddWithValue("@idBerria", balioBerria);
                    cmdErabiltzaileak.Parameters.AddWithValue("@idZaharra", idZaharra);
                    cmdErabiltzaileak.ExecuteNonQuery();

                    // 3. Mintegi zaharra ezabatu
                    string queryMintegia = "DELETE FROM MINTEGIA WHERE id_mintegia = @idZaharra";
                    MySqlCommand cmdMintegia = new MySqlCommand(queryMintegia, konexioa);
                    cmdMintegia.Parameters.AddWithValue("@idZaharra", idZaharra);

                    int errenkadak = cmdMintegia.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea mintegiaren migrazioan: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #region EZABATU (DELETE)
        /// <summary>
        /// Mintegi bat datu-basetik ezabatzen du bere ID-aren bidez.
        /// Funtzio honek mintegi horretako gailuak ETA erabiltzaileak "umezurtz" uzten ditu (id_mintegia = NULL) 
        /// ezabaketa egin aurretik, datu-baseko erregistroak ez apurtzeko.
        /// </summary>
        /// <param name="idMintegia">Ezabatu nahi den mintegiaren identifikadorea.</param>
        /// <returns>Egia (true) ondo ezabatu bada, bestela Gezurra (false).</returns>
        public bool EzabatuMintegia(int idMintegia)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // 1. URRATSA: Mintegi honetako gailuak "Esleitu gabe" utzi (id_mintegia = NULL)
                    string queryGailuak = "UPDATE GAILUA SET id_mintegia = NULL WHERE id_mintegia = @id";
                    MySqlCommand cmdGailuak = new MySqlCommand(queryGailuak, konexioa);
                    cmdGailuak.Parameters.AddWithValue("@id", idMintegia);
                    cmdGailuak.ExecuteNonQuery(); // Gailuak askatu ditugu

                    // 2. URRATSA: Mintegi honetako erabiltzaileak ere "Esleitu gabe" utzi (id_mintegia = NULL)
                    string queryErabiltzaileak = "UPDATE ERABILTZAILEA SET id_mintegia = NULL WHERE id_mintegia = @id";
                    MySqlCommand cmdErabiltzaileak = new MySqlCommand(queryErabiltzaileak, konexioa);
                    cmdErabiltzaileak.Parameters.AddWithValue("@id", idMintegia);
                    cmdErabiltzaileak.ExecuteNonQuery(); // Erabiltzaileak askatu ditugu

                    // 3. URRATSA: Orain bai, mintegia arazorik gabe ezabatu dezakegu
                    string queryMintegia = "DELETE FROM MINTEGIA WHERE id_mintegia = @id";
                    MySqlCommand cmdMintegia = new MySqlCommand(queryMintegia, konexioa);
                    cmdMintegia.Parameters.AddWithValue("@id", idMintegia);

                    int errenkadak = cmdMintegia.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ustekabeko errorea mintegia ezabatzean.\n\nXehetasunak: " + ex.Message,
                                "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}