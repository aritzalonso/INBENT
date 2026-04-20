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

        #region EZABATU (DELETE)
        /// <summary>
        /// Mintegi bat datu-basetik ezabatzen du bere ID-aren bidez.
        /// </summary>
        /// <param name="idMintegia">Ezabatu nahi den mintegiaren identifikadorea.</param>
        /// <returns>Egia (true) ondo ezabatu bada, bestela Gezurra (false).</returns>
        public bool EzabatuMintegia(int idMintegia)
        {
            string query = "DELETE FROM MINTEGIA WHERE id_mintegia = @id";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", idMintegia);

                    int errenkadak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                // SQL Segurtasun kontrola: Ezin da mintegi bat ezabatu erabiltzaileak edo gailuak baditu barnean
                MessageBox.Show("Ezin izan da mintegia ezabatu. Ziurtatu ez dagoela erabiltzailerik edo gailurik mintegi honetara lotuta.\n\nXehetasunak: " + ex.Message,
                                "Segurtasun Blokeoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        #endregion
    }
}