using System;
using System.Windows.Forms;
using INBENT_VISUAL.diseinuak;

namespace INBENT_VISUAL
{
    internal static class Program
    {
        #region APLIKAZIOAREN ABIAPUNTUA (PUNTO DE ENTRADA)
        /// <summary>
        /// Aplikazioaren sarrera-puntu nagusia (Main).
        /// Hemen konfiguratzen da eta abiarazten da lehenengo leihoa.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Aplikazioaren oinarrizko konfigurazioa (DPI, letra-tipoak, etab.)
            ApplicationConfiguration.Initialize();

            // POO / Arkitektura: Gure aplikazioa BETI Login leihoarekin hasiko da
            Application.Run(new FLogin());
        }
        #endregion
    }
}