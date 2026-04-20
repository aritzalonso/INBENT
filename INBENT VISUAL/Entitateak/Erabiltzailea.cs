namespace INBENT_VISUAL.Entitateak
{
    /// <summary>
    /// Sisteman saioa hasi dezaketen pertsonen klasea.
    /// </summary>
    public class Erabiltzailea
    {
        #region PROPIETATEAK
        // Datu-baseko oinarrizko identifikadoreak
        public int IdErabiltzailea { get; set; }
        public string Izena { get; set; }
        public string Pasahitza { get; set; }
        public int IdRola { get; set; }
        public int IdMintegia { get; set; }

        // Kanpoko propietateak (Beste taula batzuetatik datozen testuak, pantailan erakusteko)
        public string RolIzena { get; set; }
        public string MintegiIzena { get; set; }
        #endregion

        #region ERAIKITZAILEAK
        /// <summary>
        /// Eraikitzaile osoa (Datu guztiak jaso eta objektua sortzeko).
        /// </summary>
        public Erabiltzailea(int id, string izena, string pasahitza, int idRola, int idMintegia)
        {
            this.IdErabiltzailea = id;
            this.Izena = izena;
            this.Pasahitza = pasahitza;
            this.IdRola = idRola;
            this.IdMintegia = idMintegia;
        }

        /// <summary>
        /// Eraikitzaile hutsa (Oso erabilgarria objektua sortu eta gero datuak banaka sartzeko).
        /// </summary>
        public Erabiltzailea() { }
        #endregion
    }
}