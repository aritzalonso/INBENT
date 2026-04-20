namespace INBENT_VISUAL.Entitateak
{
    /// <summary>
    /// Gailua klasearen azpiklasea. 
    /// Ordenagailuen hardware ezaugarri zehatzak gordetzen ditu.
    /// </summary>
    public class Ordenagailua : Gailua
    {
        #region PROPIETATE ESPEZIFIKOAK
        public string Ram { get; set; }
        public string Rom { get; set; }
        public string Cpu { get; set; }
        #endregion

        #region ERAIKITZAILEA
        /// <summary>
        /// Ordenagailu berri bat sortzen du, oinarrizko Gailuaren propietateak heredatuz.
        /// </summary>
        public Ordenagailua() : base() { }
        #endregion
    }
}