namespace INBENT_VISUAL.Entitateak
{
    /// <summary>
    /// Gailua klasearen azpiklasea. 
    /// Inprimagailuen ezaugarri espezifikoak kudeatzen ditu.
    /// </summary>
    public class Inprimagailua : Gailua
    {
        #region PROPIETATE ESPEZIFIKOAK
        public string Koloretakoa { get; set; } // Adibidez: "Bai" edo "Ez"
        #endregion

        #region ERAIKITZAILEA
        /// <summary>
        /// Inprimagailu bat sortzen du, oinarrizko Gailuaren ezaugarriak heredatuz.
        /// </summary>
        public Inprimagailua() : base() { }
        #endregion
    }
}