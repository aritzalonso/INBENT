using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace INBENT_VISUAL.Kudeatzaileak
{
    /// <summary>
    /// Datu-basearekin konexioa kudeatzen duen klase nagusia.
    /// Aplikazioko beste edozein kudeatzailek klase hau erabiliko du MySQL-ra konektatzeko.
    /// </summary>
    internal class DBkonexioa
    {
        #region KONEXIOAREN PARAMETROAK
        // Zerbitzariaren eta datu-basearen datuak (Enkapsulatuta, pribatuak direlako)
        private string zerbitzaria = "localhost";
        private string datuBasea = "INBENT";
        private string erabiltzailea = "root";
        private string pasahitza = "1234";
        private string portua = "3306";

        // MySQL-rekin hitz egiteko objektua
        private MySqlConnection konexioa;
        #endregion

        #region ERAIKITZAILEA
        /// <summary>
        /// Konexio-katea (ConnectionString) sortu eta konexio objektua hasieratzen du.
        /// </summary>
        public DBkonexioa()
        {
            string konexioKatea = $"server={zerbitzaria};port={portua};user id={erabiltzailea};password={pasahitza};database={datuBasea};";
            konexioa = new MySqlConnection(konexioKatea);
        }
        #endregion

        #region KONEXIO METODOAK
        /// <summary>
        /// Datu-basearekin konexioa irekitzen du, itxita badago.
        /// </summary>
        /// <returns>Irekitako MySqlConnection objektua, edo null erroreren bat egon bada.</returns>
        public MySqlConnection Ireki()
        {
            try
            {
                if (konexioa.State == System.Data.ConnectionState.Closed)
                {
                    konexioa.Open();
                }
                return konexioa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea datu-basearekin konektatzean:\n" + ex.Message, "Konexio Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Datu-basearekin konexioa ixten du, irekita badago. (Baliabideak askatzeko beharrezkoa).
        /// </summary>
        public void Itxi()
        {
            if (konexioa.State == System.Data.ConnectionState.Open)
            {
                konexioa.Close();
            }
        }
        #endregion
    }
}