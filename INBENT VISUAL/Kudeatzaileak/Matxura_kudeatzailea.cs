using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Kudeatzaileak
{
    public class Matxura_kudeatzailea
    {
        private DBkonexioa db = new DBkonexioa();

        // 1. ERAKUTSI: Mostrar la lista de averías en la tabla
        public DataTable MatxurakErakutsi()
        {
            DataTable taula = new DataTable();

            // Magia: Añadimos WHERE konponketa_data IS NULL para que sea una "To-Do List" real
            string query = @"SELECT m.id_matxura AS 'ID',
                                    m.matxura_data AS 'Data',
                                    g.marka AS 'Gailua',
                                    g.gela AS 'Gela',
                                    m.deskribapena AS 'Deskribapena'
                             FROM MATXURA m
                             JOIN GAILUA g ON m.id_gailua = g.id_gailua
                             WHERE m.konponketa_data IS NULL";
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(taula);
                    db.Itxi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxurak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return taula;
        }

        // 2. KONPONDU: Guardar historial en lugar de borrar
        public bool KonponduMatxura(int idMatxura, DateTime konponketaData, string konponketaDeskribapena)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // A) Guardamos los datos de la reparación en el historial
                    string queryMatxura = "UPDATE MATXURA SET konponketa_data = @data, konponketa_deskribapena = @desc WHERE id_matxura = @idMatxura";
                    MySqlCommand cmdMatxura = new MySqlCommand(queryMatxura, konexioa);
                    cmdMatxura.Parameters.AddWithValue("@data", konponketaData.ToString("yyyy-MM-dd"));
                    cmdMatxura.Parameters.AddWithValue("@desc", konponketaDeskribapena);
                    cmdMatxura.Parameters.AddWithValue("@idMatxura", idMatxura);
                    cmdMatxura.ExecuteNonQuery();

                    // B) Devolvemos el ordenador al estado 'aktibo'
                    string queryEgoera = "UPDATE GAILUA SET egoera = 'aktibo' WHERE id_gailua = (SELECT id_gailua FROM MATXURA WHERE id_matxura = @idMatxura)";
                    MySqlCommand cmdEgoera = new MySqlCommand(queryEgoera, konexioa);
                    cmdEgoera.Parameters.AddWithValue("@idMatxura", idMatxura);
                    cmdEgoera.ExecuteNonQuery();

                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxura konpontzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 2. GEHITU: Registrar avería y actualizar el estado del dispositivo
        public bool GehituMatxura(int idGailua, DateTime data, string deskribapena)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // A) Insertar la avería en la tabla MATXURA
                    string queryMatxura = "INSERT INTO MATXURA (matxura_data, deskribapena, id_gailua) VALUES (@data, @deskribapena, @idGailua)";
                    MySqlCommand cmdMatxura = new MySqlCommand(queryMatxura, konexioa);
                    cmdMatxura.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd"));
                    cmdMatxura.Parameters.AddWithValue("@deskribapena", deskribapena);
                    cmdMatxura.Parameters.AddWithValue("@idGailua", idGailua);

                    cmdMatxura.ExecuteNonQuery();

                    // B) Cambiar el estado del dispositivo a 'matxuratua'
                    string queryEgoera = "UPDATE GAILUA SET egoera = 'matxuratua' WHERE id_gailua = @idGailua";
                    MySqlCommand cmdEgoera = new MySqlCommand(queryEgoera, konexioa);
                    cmdEgoera.Parameters.AddWithValue("@idGailua", idGailua);

                    cmdEgoera.ExecuteNonQuery();

                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxura sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Función para ARREGLAR el dispositivo
        public bool KonponduMatxura(int idMatxura)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // 1. Primero, le decimos al ordenador que vuelva a estar 'aktibo'
                    string queryEgoera = "UPDATE GAILUA SET egoera = 'aktibo' WHERE id_gailua = (SELECT id_gailua FROM MATXURA WHERE id_matxura = @idMatxura)";
                    MySqlCommand cmdEgoera = new MySqlCommand(queryEgoera, konexioa);
                    cmdEgoera.Parameters.AddWithValue("@idMatxura", idMatxura);
                    cmdEgoera.ExecuteNonQuery();

                    // 2. Luego, borramos la avería de la tabla porque ya está solucionada
                    string queryEzabatu = "DELETE FROM MATXURA WHERE id_matxura = @idMatxura";
                    MySqlCommand cmdEzabatu = new MySqlCommand(queryEzabatu, konexioa);
                    cmdEzabatu.Parameters.AddWithValue("@idMatxura", idMatxura);
                    cmdEzabatu.ExecuteNonQuery();

                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea matxura konpontzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
