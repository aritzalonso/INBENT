using System;

namespace INBENT_VISUAL.Entitateak
{
    /// <summary>
    /// Gailu baten matxura irudikatzen duen entitate klasea.
    /// Datu-baseko MATXURA taularen ispilua da objektuetara bideratutako programazioan (POO).
    /// </summary>
    public class Matxura
    {
        #region PROPIETATEAK
        public int IdMatxura { get; set; }
        public DateTime MatxuraData { get; set; }
        public string Deskribapena { get; set; }
        public int IdGailua { get; set; }

        public DateTime? KonponketaData { get; set; }
        public string KonponketaDeskribapena { get; set; }

        public string GailuInfo { get; set; }
        public string MintegiIzena { get; set; }
        #endregion

        #region ERAIKITZAILEAK
        public Matxura() { }

        /// <summary>
        /// Matxura berri bat sortzeko eraikitzailea, datu-basean sartu aurretik 
        /// oinarrizko informazioa (data, azalpena eta gailuaren ID-a) hasieratzeko.
        /// </summary>
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