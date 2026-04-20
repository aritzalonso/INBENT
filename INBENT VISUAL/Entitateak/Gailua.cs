using System;

namespace INBENT_VISUAL.Entitateak
{
    /// <summary>
    /// Inbentarioko gailu guztien oinarrizko klasea. 
    /// Hemen gordetzen dira gailu guztiek dituzten ezaugarri amankomunak.
    /// </summary>
    public class Gailua
    {
        #region PROPIETATE OROKORRAK
        public int IdGailua { get; set; }
        public string Marka { get; set; }
        public DateTime ErosteData { get; set; }
        public string Gela { get; set; }
        public string Egoera { get; set; } // 'aktibo', 'matxuratua' edo 'bajan'
        public string BajaArrazoia { get; set; } // Soilik gailua bajan badago erabiltzen da
        #endregion

        #region ERAIKITZAILEA
        public Gailua() { }
        #endregion
    }
}