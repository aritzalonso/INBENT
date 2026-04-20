using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INBENT_VISUAL.Entitateak
{
    public class Matxura
    {
        public int IdMatxura { get; set; }
        public DateTime MatxuraData { get; set; }
        public string Deskribapena { get; set; }
        public int IdGailua { get; set; }

        public Matxura(int id, DateTime data, string deskribapena, int idGailua)
        {
            this.IdMatxura = id;
            this.MatxuraData = data;
            this.Deskribapena = deskribapena;
            this.IdGailua = idGailua;
        }
    }
}
