namespace INBENT_VISUAL.diseinuak
{
    partial class FGailua
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTituloa = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.cmbMota = new System.Windows.Forms.ComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblGela = new System.Windows.Forms.Label();
            this.txtGela = new System.Windows.Forms.TextBox();

            // Paneles
            this.pnlOrdenagailua = new System.Windows.Forms.Panel();
            this.lblRAM = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.lblROM = new System.Windows.Forms.Label();
            this.txtROM = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();

            this.pnlInprimagailua = new System.Windows.Forms.Panel();
            this.lblKoloretakoa = new System.Windows.Forms.Label();
            this.cmbKoloretakoa = new System.Windows.Forms.ComboBox();

            this.lblErosteData = new System.Windows.Forms.Label();
            this.dtpErosteData = new System.Windows.Forms.DateTimePicker();

            this.btnGorde = new System.Windows.Forms.Button();
            this.btnEzeztatu = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.pnlOrdenagailua.SuspendLayout();
            this.pnlInprimagailua.SuspendLayout();
            this.SuspendLayout();

            // Cabecera
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.panelHeader.Controls.Add(this.lblTituloa);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(420, 50);

            // Título corregido (AutoSize = true)
            this.lblTituloa.AutoSize = true;
            this.lblTituloa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloa.ForeColor = System.Drawing.Color.White;
            this.lblTituloa.Text = "Gailuaren Kudeaketa";
            this.lblTituloa.Location = new System.Drawing.Point(12, 11);

            // Selector de Tipo
            this.lblMota.AutoSize = true;
            this.lblMota.Text = "Gailu Mota:";
            this.lblMota.Location = new System.Drawing.Point(30, 70);
            this.cmbMota.Items.AddRange(new object[] { "Ordenagailua", "Inprimagailua" });
            this.cmbMota.Location = new System.Drawing.Point(34, 95);
            this.cmbMota.Size = new System.Drawing.Size(350, 28);
            this.cmbMota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMota.SelectedIndexChanged += new System.EventHandler(this.cmbMota_SelectedIndexChanged);

            // Datos Comunes
            this.lblMarka.AutoSize = true;
            this.lblMarka.Text = "Marka:";
            this.lblMarka.Location = new System.Drawing.Point(30, 135);
            this.txtMarka.Location = new System.Drawing.Point(34, 160);
            this.txtMarka.Size = new System.Drawing.Size(165, 27);

            this.lblGela.AutoSize = true;
            this.lblGela.Text = "Gela:";
            this.lblGela.Location = new System.Drawing.Point(215, 135);
            this.txtGela.Location = new System.Drawing.Point(219, 160);
            this.txtGela.Size = new System.Drawing.Size(165, 27);

            // ==========================================
            // PANEL ORDENADOR
            // ==========================================
            this.pnlOrdenagailua.Location = new System.Drawing.Point(30, 200);
            this.pnlOrdenagailua.Size = new System.Drawing.Size(360, 130);
            this.pnlOrdenagailua.Visible = false;

            // RAM
            this.lblRAM.AutoSize = true;
            this.lblRAM.Text = "RAM:";
            this.lblRAM.Location = new System.Drawing.Point(0, 0);
            this.txtRAM.Location = new System.Drawing.Point(4, 25);
            this.txtRAM.Size = new System.Drawing.Size(165, 27);

            // ROM
            this.lblROM.AutoSize = true;
            this.lblROM.Text = "ROM:";
            this.lblROM.Location = new System.Drawing.Point(185, 0);
            this.txtROM.Location = new System.Drawing.Point(189, 25);
            this.txtROM.Size = new System.Drawing.Size(165, 27);

            // CPU
            this.lblCPU.AutoSize = true;
            this.lblCPU.Text = "CPU:";
            this.lblCPU.Location = new System.Drawing.Point(0, 65);
            this.txtCPU.Location = new System.Drawing.Point(4, 90);
            this.txtCPU.Size = new System.Drawing.Size(350, 27);

            this.pnlOrdenagailua.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblRAM, this.txtRAM, this.lblROM, this.txtROM, this.lblCPU, this.txtCPU });

            // ==========================================
            // PANEL IMPRESORA
            // ==========================================
            this.pnlInprimagailua.Location = new System.Drawing.Point(30, 200);
            this.pnlInprimagailua.Size = new System.Drawing.Size(360, 80);
            this.pnlInprimagailua.Visible = false;
            this.lblKoloretakoa.AutoSize = true;
            this.lblKoloretakoa.Text = "Koloretakoa da?";
            this.lblKoloretakoa.Location = new System.Drawing.Point(0, 0);
            this.cmbKoloretakoa.Items.AddRange(new object[] { "Bai", "Ez" });
            this.cmbKoloretakoa.Location = new System.Drawing.Point(4, 25);
            this.cmbKoloretakoa.Size = new System.Drawing.Size(350, 28);
            this.cmbKoloretakoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pnlInprimagailua.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblKoloretakoa, this.cmbKoloretakoa });

            // Resto de campos
            this.lblErosteData.AutoSize = true;
            this.lblErosteData.Text = "Eroste Data:";
            this.lblErosteData.Location = new System.Drawing.Point(30, 340);
            this.dtpErosteData.Location = new System.Drawing.Point(34, 365);
            this.dtpErosteData.Size = new System.Drawing.Size(350, 27);
            this.dtpErosteData.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Botones (Subidos un poco al quitar el estado)
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnGorde.Text = "💾 Gorde";
            this.btnGorde.Location = new System.Drawing.Point(40, 420);
            this.btnGorde.Size = new System.Drawing.Size(150, 40);
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);

            this.btnEzeztatu.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.Location = new System.Drawing.Point(230, 420);
            this.btnEzeztatu.Size = new System.Drawing.Size(150, 40);
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);

            // Form (Más corto ahora)
            this.ClientSize = new System.Drawing.Size(420, 490);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.panelHeader, this.lblMota, this.cmbMota, this.lblMarka, this.txtMarka, this.lblGela, this.txtGela, this.pnlOrdenagailua, this.pnlInprimagailua, this.lblErosteData, this.dtpErosteData, this.btnGorde, this.btnEzeztatu });

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pnlOrdenagailua.ResumeLayout(false);
            this.pnlOrdenagailua.PerformLayout();
            this.pnlInprimagailua.ResumeLayout(false);
            this.pnlInprimagailua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTituloa;
        private System.Windows.Forms.Label lblMota;
        public System.Windows.Forms.ComboBox cmbMota;
        private System.Windows.Forms.Label lblMarka;
        public System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblGela;
        public System.Windows.Forms.TextBox txtGela;
        private System.Windows.Forms.Panel pnlOrdenagailua;
        public System.Windows.Forms.TextBox txtRAM;
        public System.Windows.Forms.TextBox txtROM;
        public System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblROM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Panel pnlInprimagailua;
        public System.Windows.Forms.ComboBox cmbKoloretakoa;
        private System.Windows.Forms.Label lblKoloretakoa;
        private System.Windows.Forms.Label lblErosteData;
        public System.Windows.Forms.DateTimePicker dtpErosteData;
        private System.Windows.Forms.Button btnGorde;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}