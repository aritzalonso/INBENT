using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Entitateak
{
    public class Erabiltzailea
    {
        public int IdErabiltzailea { get; set; }
        public string Izena { get; set; }
        public string Pasahitza { get; set; }
        // Guardamos los IDs reales de la base de datos
        public int IdRola { get; set; }
        public int IdMintegia { get; set; }

        // Constructor
        public Erabiltzailea(int id, string izena, string pasahitza, int idRola, int idMintegia)
        {
            this.IdErabiltzailea = id;
            this.Izena = izena;
            this.Pasahitza = pasahitza;
            this.IdRola = idRola;
            this.IdMintegia = idMintegia;
        }
    }
}
