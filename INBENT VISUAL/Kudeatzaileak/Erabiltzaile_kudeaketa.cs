using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Kudeatzaileak
{
    public class Erabiltzaile_kudeaketa
    {
        private DBkonexioa db = new DBkonexioa();

        // Función para guardar un usuario (Traduce los textos a IDs automáticamente)
        public DataTable ErabiltzaileakErakutsi()
        {
            DataTable taula = new DataTable();

            // Hacemos un JOIN para que salga el NOMBRE del rol y mintegi, no sus IDs (números)
            // Usamos 'AS' para ponerle un título bonito a las columnas de la tabla visual
            string query = @"SELECT e.id_erabiltzailea AS 'ID',
                            e.izena AS 'Izena',
                            r.izena AS 'Rola',
                            m.izena AS 'Mintegia'
                     FROM ERABILTZAILEA e
                     JOIN ROLA r ON e.id_rola = r.id_rola
                     JOIN MINTEGIA m ON e.id_mintegia = m.id_mintegia";

            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    // El Adapter es un "camión" que coge los datos de MySQL y los vuelca en nuestro DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(taula);

                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzaileak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return taula;
        }
        public bool AldatuErabiltzailea(int id_erabiltzailea, string izena, string pasahitza, string rolaIzena, string mintegiIzena)
        {
            try
            {
                DBkonexioa db = new DBkonexioa();
                MySql.Data.MySqlClient.MySqlConnection konexioa = db.Ireki();

                if (konexioa != null)
                {
                    // 1. Buscar el ID del Rol (Igual que en Alta)
                    int idRola = -1;
                    string queryRol = "SELECT id_rola FROM ROLA WHERE izena = @rolIzena";
                    MySql.Data.MySqlClient.MySqlCommand cmdRol = new MySql.Data.MySqlClient.MySqlCommand(queryRol, konexioa);
                    cmdRol.Parameters.AddWithValue("@rolIzena", rolaIzena);
                    object resultRol = cmdRol.ExecuteScalar();
                    if (resultRol != null) idRola = Convert.ToInt32(resultRol);

                    // 2. Buscar el ID del Mintegi (Igual que en Alta)
                    int idMintegi = -1;
                    string queryMintegi = "SELECT id_mintegia FROM MINTEGIA WHERE izena = @mintegiIzena";
                    MySql.Data.MySqlClient.MySqlCommand cmdMintegi = new MySql.Data.MySqlClient.MySqlCommand(queryMintegi, konexioa);
                    cmdMintegi.Parameters.AddWithValue("@mintegiIzena", mintegiIzena);
                    object resultMintegi = cmdMintegi.ExecuteScalar();
                    if (resultMintegi != null) idMintegi = Convert.ToInt32(resultMintegi);

                    // Seguridad: Si no encuentra el rol o el mintegi, paramos
                    if (idRola == -1 || idMintegi == -1)
                    {
                        System.Windows.Forms.MessageBox.Show("Errorea: Ez da aurkitu Rola edo Mintegia datu-basean.", "Errorea", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        db.Itxi();
                        return false;
                    }

                    // 3. Hacer el UPDATE real usando los números (IDs) que hemos encontrado
                    // OJO: He puesto 'IdErabiltzailea' basándome en cómo lo arreglaste antes. Si tu columna es otra, cámbiala.
                    string queryUpdate = "UPDATE ERABILTZAILEA SET izena = @izena, pasahitza = @pasahitza, id_rola = @idRola, id_mintegia = @idMintegi WHERE Id_erabiltzailea = @id";

                    MySql.Data.MySqlClient.MySqlCommand cmdUpdate = new MySql.Data.MySqlClient.MySqlCommand(queryUpdate, konexioa);
                    cmdUpdate.Parameters.AddWithValue("@izena", izena);
                    cmdUpdate.Parameters.AddWithValue("@pasahitza", pasahitza);
                    cmdUpdate.Parameters.AddWithValue("@idRola", idRola);
                    cmdUpdate.Parameters.AddWithValue("@idMintegi", idMintegi);
                    cmdUpdate.Parameters.AddWithValue("@id", id_erabiltzailea);

                    int lerroak = cmdUpdate.ExecuteNonQuery();
                    db.Itxi();

                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Errorea erabiltzailea aldatzean:\n" + ex.Message, "Errorea", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        public string EgiaztatuLogin(string izena, string pasahitza)
        {
            try
            {
                DBkonexioa db = new DBkonexioa();
                MySql.Data.MySqlClient.MySqlConnection konexioa = db.Ireki();

                if (konexioa != null)
                {
                    // ¡Magia Relacional! Hacemos un JOIN para que nos devuelva el texto del Rol ("IKT Arduraduna") en lugar del número
                    string query = "SELECT r.izena FROM ERABILTZAILEA e INNER JOIN ROLA r ON e.id_rola = r.id_rola WHERE e.izena = @izena AND e.pasahitza = @pasahitza";

                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@izena", izena);
                    cmd.Parameters.AddWithValue("@pasahitza", pasahitza);

                    // ExecuteScalar devuelve la primera columna de la primera fila (en este caso, el nombre del rol)
                    object result = cmd.ExecuteScalar();
                    db.Itxi();

                    if (result != null)
                    {
                        return result.ToString(); // Credenciales OK: Devuelve el rol
                    }
                }
                return null; // Credenciales incorrectas: Devuelve null
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Errorea datu-basearekin konektatzean:\n" + ex.Message, "Errorea", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }
        public bool EzabatuErabiltzailea(int id_erabiltzailea)
        {
            // OJO: Asegúrate de que el nombre de tu tabla sea ERABILTZAILEA y la columna id
            // Pon IdErabiltzailea (o id_erabiltzailea si en tu base de datos tiene guion bajo)
            string query = "DELETE FROM ERABILTZAILEA WHERE id_erabiltzailea = @id";

            try
            {
                DBkonexioa db = new DBkonexioa();
                MySql.Data.MySqlClient.MySqlConnection konexioa = db.Ireki();

                if (konexioa != null)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", id_erabiltzailea);

                    int errenkadak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return errenkadak > 0; // Devuelve true si ha conseguido borrarlo
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Errorea erabiltzailea ezabatzean:\n" + ex.Message, "Errorea", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GehituErabiltzailea(string izena, string pasahitza, string rolaIzena, string mintegiIzena)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // 1. Buscar el ID del Rol
                    int idRola = -1;
                    string queryRol = "SELECT id_rola FROM ROLA WHERE izena = @rolIzena";
                    MySqlCommand cmdRol = new MySqlCommand(queryRol, konexioa);
                    cmdRol.Parameters.AddWithValue("@rolIzena", rolaIzena);
                    object resultRol = cmdRol.ExecuteScalar(); // Coge un solo dato
                    if (resultRol != null) idRola = Convert.ToInt32(resultRol);

                    // 2. Buscar el ID del Mintegi
                    int idMintegi = -1;
                    string queryMintegi = "SELECT id_mintegia FROM MINTEGIA WHERE izena = @mintegiIzena";
                    MySqlCommand cmdMintegi = new MySqlCommand(queryMintegi, konexioa);
                    cmdMintegi.Parameters.AddWithValue("@mintegiIzena", mintegiIzena);
                    object resultMintegi = cmdMintegi.ExecuteScalar();
                    if (resultMintegi != null) idMintegi = Convert.ToInt32(resultMintegi);

                    // Seguridad: Si no encuentra el rol o el mintegi, paramos
                    if (idRola == -1 || idMintegi == -1)
                    {
                        MessageBox.Show("Errorea: Ez da aurkitu Rola edo Mintegia datu-basean.", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Itxi();
                        return false;
                    }

                    // 3. Hacer el INSERT real del Erabiltzailea
                    string queryInsert = "INSERT INTO ERABILTZAILEA (izena, pasahitza, id_rola, id_mintegia) VALUES (@izena, @pasahitza, @idRola, @idMintegi)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert, konexioa);
                    cmdInsert.Parameters.AddWithValue("@izena", izena);
                    cmdInsert.Parameters.AddWithValue("@pasahitza", pasahitza);
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
    }
}
