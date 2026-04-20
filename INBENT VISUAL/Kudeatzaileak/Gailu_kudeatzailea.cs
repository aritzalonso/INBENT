using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Kudeatzaileak
{
    public class Gailu_kudeatzailea
    {
        private DBkonexioa db = new DBkonexioa();

        // 1. ERAKUTSI (Muestra todos los dispositivos en una sola tabla)
        public DataTable GailuakErakutsi()
        {
            DataTable taula = new DataTable();

            // Magia SQL: Unimos las 3 tablas (Gailua, Ordenagailua e Inprimagailua)
            // Si tiene CPU diremos que es Ordenador, si no, Impresora.
            string query = @"SELECT g.id_gailua AS 'ID',
                                    IF(o.id_gailua IS NOT NULL, 'Ordenagailua', 'Inprimagailua') AS 'Mota',
                                    g.marka AS 'Marka',
                                    g.gela AS 'Gela',
                                    g.eroste_data AS 'Eroste Data',
                                    g.egoera AS 'Egoera',
                                    o.ram AS 'RAM',
                                    o.rom AS 'ROM',
                                    o.cpu AS 'CPU',
                                    i.koloretakoa AS 'Koloretakoa'
                             FROM GAILUA g
                             LEFT JOIN ORDENAGAILUA o ON g.id_gailua = o.id_gailua
                             LEFT JOIN INPRIMAGAILUA i ON g.id_gailua = i.id_gailua";

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
                MessageBox.Show("Errorea gailuak kargatzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return taula;
        }

        // 2. GEHITU ORDENAGAILUA
        public bool GehituOrdenagailua(string marka, DateTime erosteData, string gela, string egoera, string ram, string rom, string cpu)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // A) Guardamos en la tabla padre (GAILUA) y pedimos el ID que le ha tocado
                    string queryGailua = "INSERT INTO GAILUA (marka, eroste_data, gela, egoera) VALUES (@marka, @data, @gela, @egoera); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdGailua = new MySqlCommand(queryGailua, konexioa);
                    cmdGailua.Parameters.AddWithValue("@marka", marka);
                    cmdGailua.Parameters.AddWithValue("@data", erosteData.ToString("yyyy-MM-dd"));
                    cmdGailua.Parameters.AddWithValue("@gela", gela);
                    cmdGailua.Parameters.AddWithValue("@egoera", egoera);

                    // ExecuteScalar ejecuta el INSERT y nos devuelve el SELECT LAST_INSERT_ID()
                    int idGailuBerria = Convert.ToInt32(cmdGailua.ExecuteScalar());

                    // B) Guardamos en la tabla hija (ORDENAGAILUA) usando ese mismo ID
                    string queryOrd = "INSERT INTO ORDENAGAILUA (id_gailua, ram, rom, cpu) VALUES (@id, @ram, @rom, @cpu)";
                    MySqlCommand cmdOrd = new MySqlCommand(queryOrd, konexioa);
                    cmdOrd.Parameters.AddWithValue("@id", idGailuBerria);
                    cmdOrd.Parameters.AddWithValue("@ram", ram);
                    cmdOrd.Parameters.AddWithValue("@rom", rom);
                    cmdOrd.Parameters.AddWithValue("@cpu", cpu);

                    cmdOrd.ExecuteNonQuery();
                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea ordenagailua sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool AldatuOrdenagailua(int idGailua, string marka, DateTime data, string gela, string ram, string rom, string cpu)
        {
            try
            {
                DBkonexioa db = new DBkonexioa();
                MySql.Data.MySqlClient.MySqlConnection konexioa = db.Ireki();

                if (konexioa != null)
                {
                    // 1. Actualizamos los datos comunes en GAILUA
                    string queryComun = "UPDATE GAILUA SET marka = @marka, eroste_data = @data, gela = @gela WHERE id_gailua = @id";
                    MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(queryComun, konexioa);
                    cmd1.Parameters.AddWithValue("@marka", marka);
                    cmd1.Parameters.AddWithValue("@data", data);
                    cmd1.Parameters.AddWithValue("@gela", gela);
                    cmd1.Parameters.AddWithValue("@id", idGailua);
                    cmd1.ExecuteNonQuery();

                    // 2. Actualizamos los datos técnicos en ORDENAGAILUA (con ram, rom, cpu en minúscula)
                    string queryTecnica = "UPDATE ORDENAGAILUA SET ram = @ram, rom = @rom, cpu = @cpu WHERE id_gailua = @id";
                    MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(queryTecnica, konexioa);
                    cmd2.Parameters.AddWithValue("@ram", ram);
                    cmd2.Parameters.AddWithValue("@rom", rom);
                    cmd2.Parameters.AddWithValue("@cpu", cpu);
                    cmd2.Parameters.AddWithValue("@id", idGailua);

                    int lerroak = cmd2.ExecuteNonQuery();
                    db.Itxi();
                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Errorea ordenagailua aldatzean: " + ex.Message, "Errorea", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AldatuInprimagailua(int idGailua, string marka, DateTime data, string gela, string koloretakoa)
        {
            try
            {
                DBkonexioa db = new DBkonexioa();
                MySql.Data.MySqlClient.MySqlConnection konexioa = db.Ireki();

                if (konexioa != null)
                {
                    // 1. Actualizamos los datos comunes en GAILUA
                    string queryComun = "UPDATE GAILUA SET marka = @marka, eroste_data = @data, gela = @gela WHERE id_gailua = @id";
                    MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(queryComun, konexioa);
                    cmd1.Parameters.AddWithValue("@marka", marka);
                    cmd1.Parameters.AddWithValue("@data", data);
                    cmd1.Parameters.AddWithValue("@gela", gela);
                    cmd1.Parameters.AddWithValue("@id", idGailua);
                    cmd1.ExecuteNonQuery();

                    // 2. Actualizamos el detalle en INPRIMAGAILUA
                    string queryTecnica = "UPDATE INPRIMAGAILUA SET koloretakoa = @kolore WHERE id_gailua = @id";
                    MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(queryTecnica, konexioa);
                    cmd2.Parameters.AddWithValue("@kolore", koloretakoa);
                    cmd2.Parameters.AddWithValue("@id", idGailua);

                    int lerroak = cmd2.ExecuteNonQuery();
                    db.Itxi();
                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Errorea inprimagailua aldatzean: " + ex.Message, "Errorea", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
        // 3. GEHITU INPRIMAGAILUA
        public bool GehituInprimagailua(string marka, DateTime erosteData, string gela, string egoera, string koloretakoa)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    // A) Guardamos en la tabla padre (GAILUA)
                    string queryGailua = "INSERT INTO GAILUA (marka, eroste_data, gela, egoera) VALUES (@marka, @data, @gela, @egoera); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdGailua = new MySqlCommand(queryGailua, konexioa);
                    cmdGailua.Parameters.AddWithValue("@marka", marka);
                    cmdGailua.Parameters.AddWithValue("@data", erosteData.ToString("yyyy-MM-dd"));
                    cmdGailua.Parameters.AddWithValue("@gela", gela);
                    cmdGailua.Parameters.AddWithValue("@egoera", egoera);

                    int idGailuBerria = Convert.ToInt32(cmdGailua.ExecuteScalar());

                    // B) Guardamos en la tabla hija (INPRIMAGAILUA)
                    string queryInp = "INSERT INTO INPRIMAGAILUA (id_gailua, koloretakoa) VALUES (@id, @kolorea)";
                    MySqlCommand cmdInp = new MySqlCommand(queryInp, konexioa);
                    cmdInp.Parameters.AddWithValue("@id", idGailuBerria);
                    cmdInp.Parameters.AddWithValue("@kolorea", koloretakoa);

                    cmdInp.ExecuteNonQuery();
                    db.Itxi();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea inprimagailua sortzean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable GailuAktiboakErakutsi()
        {
            DataTable taula = new DataTable();
            // Juntamos el ID, la marca y la gela para que el usuario sepa cuál elige exactamente
            string query = "SELECT id_gailua, CONCAT(id_gailua, ' - ', marka, ' (', gela, ')') AS info FROM GAILUA WHERE egoera = 'aktibo'";
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
                MessageBox.Show("Errorea gailu aktiboak kargatzean: " + ex.Message);
            }
            return taula;
        }
        // Función para dar de BAJA y guardar el motivo
        public bool BajaEman(int idGailua, string arrazoia)
        {
            try
            {
                MySqlConnection konexioa = db.Ireki();
                if (konexioa != null)
                {
                    string query = "UPDATE GAILUA SET egoera = 'bajan', baja_arrazoia = @arrazoia WHERE id_gailua = @id";
                    MySqlCommand cmd = new MySqlCommand(query, konexioa);
                    cmd.Parameters.AddWithValue("@id", idGailua);
                    cmd.Parameters.AddWithValue("@arrazoia", arrazoia); // Guardamos el texto

                    int lerroak = cmd.ExecuteNonQuery();
                    db.Itxi();

                    return lerroak > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea gailuari baja ematean: " + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
