using INBENT_VISUAL.Entitateak;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Kudeatzaileak
{
    public class Mintegi_Kudeatzailea
    {
        // Instanciamos el puente a la BD
        private DBkonexioa db = new DBkonexioa();

        // Función para LEER de la Base de Datos (SELECT)
        public List<Mintegia> MintegiakErakutsi()
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
                        int id = reader.GetInt32("id_mintegia");
                        string izena = reader.GetString("izena");
                        lista.Add(new Mintegia(id, izena));
                    }
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea mintegiak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }

        // Función para GUARDAR en la Base de Datos (INSERT)
        public bool GehituMintegia(string izenaBerria)
        {
            string query = "INSERT INTO MINTEGIA (izena) VALUES (@izena)";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@izena", izenaBerria);

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
        public bool EzabatuMintegia(int idMintegia)
        {
            // OJO: Asegúrate de que el nombre de la tabla sea MINTEGIA y la columna id
            string query = "DELETE FROM MINTEGIA WHERE id_mintegia = @id";

            try
            {
                DBkonexioa db = new DBkonexioa();
                MySql.Data.MySqlClient.MySqlConnection konexioa = db.Ireki();

                if (konexioa != null)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", idMintegia);

                    int errenkadak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Este mensaje es importante: MySQL no te dejará borrar un Mintegi si hay profesores o equipos dentro de él (por seguridad).
                System.Windows.Forms.MessageBox.Show("Ezin izan da mintegia ezabatu. Ziurtatu ez dagoela erabiltzailerik edo gailurik mintegi honetara lotuta.\n\nXehetasunak: " + ex.Message, "Segurtasun Blokeoa", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
