using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using INBENT_VISUAL.Kudeatzaileak;

namespace INBENT_VISUAL.diseinuak
{
    /// <summary>
    /// Mintegi bat ezabatzerakoan agertzen den trantsizio-leihoa. 
    /// Erabiltzaileari galdetzen dio nora transferitu nahi dituen ezabatuko den 
    /// mintegiko gailu eta erabiltzaileak.
    /// </summary>
    public partial class FMintegiAldaketa : Form
    {
        #region PROPIETATEAK
        /// <summary>
        /// Desplegablean (ComboBox) aukeratutako mintegi berriaren ID-a itzultzen du.
        /// FNagusia-k irakurri ahal izateko.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdMintegiBerria
        {
            get { return Convert.ToInt32(cmbMintegiBerria.SelectedValue); }
        }
        #endregion

        #region ERAIKITZAILEA
        /// <summary>
        /// Leihoa hasieratzen du, ezabatuko den mintegia baztertuz (ezin dugulako gailua ezabatuko den leku berdinera bidali).
        /// </summary>
        /// <param name="idZaharra">Ezabatuko den mintegiaren ID-a.</param>
        /// <param name="izenZaharra">Ezabatuko den mintegiaren izena (mezurako).</param>
        public FMintegiAldaketa(int idZaharra, string izenZaharra)
        {
            InitializeComponent();

            // Mezu pertsonalizatua
            lblInformazioa.Text = $"'{izenZaharra}' ezabatzean, nora eraman nahi dituzu gailuak eta erabiltzaileak?";

            KargatuMintegiHautagarriak(idZaharra);
        }
        #endregion
        #region DATUAK KARGATZEA
        private void KargatuMintegiHautagarriak(int idZaharra)
        {
            Mintegi_Kudeatzailea kudeatzailea = new Mintegi_Kudeatzailea();
            var mintegiGuztiak = kudeatzailea.MintegiakErakutsiPOO();

            var hautagarriak = System.Linq.Enumerable.Where(mintegiGuztiak, m => m.IdMintegia != idZaharra).ToList();
            INBENT_VISUAL.Entitateak.Mintegia esleituGabe = new INBENT_VISUAL.Entitateak.Mintegia();
            esleituGabe.IdMintegia = 0;
            esleituGabe.Izena = "-- Esleitu gabe utzi --";
            hautagarriak.Insert(0, esleituGabe);

            cmbMintegiBerria.DataSource = hautagarriak;
            cmbMintegiBerria.DisplayMember = "Izena";
            cmbMintegiBerria.ValueMember = "IdMintegia";
            cmbMintegiBerria.SelectedIndex = 0;
        }
        #endregion

        #region BOTOIEN EKINTZAK
        /// <summary>
        /// Mintegi berri bat aukeratu dela balidatzen du eta DialogResult.OK bidaltzen du.
        /// </summary>
        private void btnOnartu_Click(object sender, EventArgs e)
        {
            if (cmbMintegiBerria.SelectedIndex == -1)
            {
                MessageBox.Show("Mesedez, aukeratu mintegi berri bat zerrendatik.", "Arreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}