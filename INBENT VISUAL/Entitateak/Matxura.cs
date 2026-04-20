using System;

namespace INBENT_VISUAL.Entitateak
{
    /// <summary>
    /// Gailu batek izan dezakeen matxura edo arazoa adierazten duen klasea.
    /// </summary>
    public class Matxura
    {
        #region PROPIETATEAK
        public int IdMatxura { get; set; }
        public DateTime MatxuraData { get; set; }
        public string Deskribapena { get; set; }
        public int IdGailua { get; set; }

        // Konponketari buruzko datuak (Nulua izan daiteke oraindik konpondu ez bada)
        public DateTime? KonponketaData { get; set; }
        public string KonponketaDeskribapena { get; set; }

        // Laguntza propietatea: Taula bisualetan gailuaren infoa erakusteko (adib: "HP (Gela 101)")
        public string GailuInfo { get; set; }
        #endregion

        #region ERAIKITZAILEAK
        public Matxura() { }

        public Matxura(int id, DateTime data, string deskribapena, int idGailua)
        {
            this.IdMatxura = id;
            this.MatxuraData = data;
            this.Deskribapena = deskribapena;
            this.IdGailua = idGailua;
        }
        #endregion
    }
}