using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Entitateak
{
    public class Mintegia
    {
        public int IdMintegia { get; set; }
        public string Izena { get; set; }

        // Constructor
        public Mintegia(int id, string izena)
        {
            this.IdMintegia = id;
            this.Izena = izena;
        }
    }
}
