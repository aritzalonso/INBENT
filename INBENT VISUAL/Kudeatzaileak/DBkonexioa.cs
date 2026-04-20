using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INBENT_VISUAL.Kudeatzaileak
{
    internal class DBkonexioa
    {
        // DATOS DE TU SERVIDOR
        private string zerbitzaria = "localhost";
        private string datuBasea = "INBENT"; // <-- ¡Nombre actualizado!
        private string erabiltzailea = "root";
        private string pasahitza = "1234";
        private string portua = "3306";

        private MySqlConnection konexioa;

        public DBkonexioa()
        {
            // Construimos la llave para entrar
            string konexioKatea = $"server={zerbitzaria};port={portua};user id={erabiltzailea};password={pasahitza};database={datuBasea};";
            konexioa = new MySqlConnection(konexioKatea);
        }

        // Método para ABRIR la conexión


        // Método para CERRAR la conexión


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
        public void Itxi()
        {
            if (konexioa.State == System.Data.ConnectionState.Open)
            {
                konexioa.Close();
            }
        }

    }
}
