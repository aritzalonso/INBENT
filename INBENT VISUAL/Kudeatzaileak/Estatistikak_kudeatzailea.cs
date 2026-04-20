using MySql.Data.MySqlClient;
using System;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// Aplikazioaren hasierako pantailan (Dashboard) erakusten diren 
    /// datu estatistikoak lortzeko arduraduna.
    /// </summary>
    public class Estatistikak_kudeatzailea
    {
        #region ALDAGAI OROKORRAK
        // Datu-basearekiko konexioa kudeatzeko objektua (Behin bakarrik sortzen dugu memoria aurrezteko)
        private DBkonexioa db = new DBkonexioa();
        #endregion

        #region KOPURUAK LORTZEKO FUNTZIOAK (ESTATISTIKAK)

        /// <summary>
        /// Datu-basean dauden gailu guztien kopuru totala itzultzen du.
        /// </summary>
        public int LortuGailuKopurua()
        {
            int kopurua = 0;
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // ExecuteScalar ezin hobea da zenbaki bakarra (COUNT) lortzeko
                    string query = "SELECT COUNT(*) FROM GAILUA";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    kopurua = Convert.ToInt32(cmd.ExecuteScalar());
                    db.Itxi();
                }
            }
            catch (Exception) { /* Errorea badago, 0 itzuliko du aplikazioa ez apurtzeko */ }
            return kopurua;
        }

        /// <summary>
        /// Datu-basean erregistratuta dauden erabiltzaileen kopuru totala itzultzen du.
        /// </summary>
        public int LortuErabiltzaileKopurua()
        {
            int kopurua = 0;
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = "SELECT COUNT(*) FROM ERABILTZAILEA";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    kopurua = Convert.ToInt32(cmd.ExecuteScalar());
                    db.Itxi();
                }
            }
            catch (Exception) { }
            return kopurua;
        }

        /// <summary>
        /// Erregistratutako matxura guztien kopuru totala itzultzen du.
        /// </summary>
        public int LortuMatxuraKopurua()
        {
            int kopurua = 0;
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = "SELECT COUNT(*) FROM MATXURA";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    kopurua = Convert.ToInt32(cmd.ExecuteScalar());
                    db.Itxi();
                }
            }
            catch (Exception) { }
            return kopurua;
        }

        #endregion
    }
}