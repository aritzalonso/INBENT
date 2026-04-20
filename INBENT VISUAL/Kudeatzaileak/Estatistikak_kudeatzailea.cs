using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Kudeatzaileak
{
    public class Estatistikak_kudeatzailea
    {
        // 1. Contar Dispositivos
        public int LortuGailuKopurua()
        {
            int kopurua = 0;
            try
            {
                DBkonexioa db = new DBkonexioa();
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // La consulta mágica de SQL para contar: COUNT(*)
                    string query = "SELECT COUNT(*) FROM GAILUA";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    kopurua = Convert.ToInt32(cmd.ExecuteScalar());
                    db.Itxi();
                }
            }
            catch (Exception) { }
            return kopurua;
        }

        // 2. Contar Usuarios
        public int LortuErabiltzaileKopurua()
        {
            int kopurua = 0;
            try
            {
                DBkonexioa db = new DBkonexioa();
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

        // 3. Contar Averías (Matxurak)
        // Nota: Asegúrate de que tu tabla se llama MATXURA, si es en plural pon MATXURAK
        public int LortuMatxuraKopurua()
        {
            int kopurua = 0;
            try
            {
                DBkonexioa db = new DBkonexioa();
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
    }
}
