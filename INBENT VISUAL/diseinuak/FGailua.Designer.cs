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

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.panelHeader.Controls.Add(this.lblTituloa);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(420, 50);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTituloa
            // 
            this.lblTituloa.AutoSize = true;
            this.lblTituloa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloa.ForeColor = System.Drawing.Color.White;
            this.lblTituloa.Location = new System.Drawing.Point(12, 11);
            this.lblTituloa.Name = "lblTituloa";
            this.lblTituloa.Size = new System.Drawing.Size(206, 28);
            this.lblTituloa.TabIndex = 1;
            this.lblTituloa.Text = "Gailuaren Kudeaketa";

            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Location = new System.Drawing.Point(30, 70);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(76, 16);
            this.lblMota.TabIndex = 2;
            this.lblMota.Text = "Gailu Mota:";

            // 
            // cmbMota
            // 
            this.cmbMota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMota.FormattingEnabled = true;
            this.cmbMota.Items.AddRange(new object[] {
            "Ordenagailua",
            "Inprimagailua"});
            this.cmbMota.Location = new System.Drawing.Point(34, 95);
            this.cmbMota.Name = "cmbMota";
            this.cmbMota.Size = new System.Drawing.Size(350, 24);
            this.cmbMota.TabIndex = 3;
            this.cmbMota.SelectedIndexChanged += new System.EventHandler(this.cmbMota_SelectedIndexChanged);

            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(30, 135);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(48, 16);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Marka:";

            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(34, 160);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(165, 22);
            this.txtMarka.TabIndex = 5;

            // 
            // lblGela
            // 
            this.lblGela.AutoSize = true;
            this.lblGela.Location = new System.Drawing.Point(215, 135);
            this.lblGela.Name = "lblGela";
            this.lblGela.Size = new System.Drawing.Size(39, 16);
            this.lblGela.TabIndex = 6;
            this.lblGela.Text = "Gela:";

            // 
            // txtGela
            // 
            this.txtGela.Location = new System.Drawing.Point(219, 160);
            this.txtGela.Name = "txtGela";
            this.txtGela.Size = new System.Drawing.Size(165, 22);
            this.txtGela.TabIndex = 7;

            // 
            // pnlOrdenagailua
            // 
            this.pnlOrdenagailua.Controls.Add(this.lblRAM);
            this.pnlOrdenagailua.Controls.Add(this.txtRAM);
            this.pnlOrdenagailua.Controls.Add(this.lblROM);
            this.pnlOrdenagailua.Controls.Add(this.txtROM);
            this.pnlOrdenagailua.Controls.Add(this.lblCPU);
            this.pnlOrdenagailua.Controls.Add(this.txtCPU);
            this.pnlOrdenagailua.Location = new System.Drawing.Point(30, 200);
            this.pnlOrdenagailua.Name = "pnlOrdenagailua";
            this.pnlOrdenagailua.Size = new System.Drawing.Size(360, 130);
            this.pnlOrdenagailua.TabIndex = 8;
            this.pnlOrdenagailua.Visible = false;

            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(0, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(40, 16);
            this.lblRAM.TabIndex = 0;
            this.lblRAM.Text = "RAM:";

            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(4, 25);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(165, 22);
            this.txtRAM.TabIndex = 1;

            // 
            // lblROM
            // 
            this.lblROM.AutoSize = true;
            this.lblROM.Location = new System.Drawing.Point(185, 0);
            this.lblROM.Name = "lblROM";
            this.lblROM.Size = new System.Drawing.Size(41, 16);
            this.lblROM.TabIndex = 2;
            this.lblROM.Text = "ROM:";

            // 
            // txtROM
            // 
            this.txtROM.Location = new System.Drawing.Point(189, 25);
            this.txtROM.Name = "txtROM";
            this.txtROM.Size = new System.Drawing.Size(165, 22);
            this.txtROM.TabIndex = 3;

            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(0, 65);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(38, 16);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "CPU:";

            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(4, 90);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(350, 22);
            this.txtCPU.TabIndex = 5;

            // 
            // pnlInprimagailua
            // 
            this.pnlInprimagailua.Controls.Add(this.lblKoloretakoa);
            this.pnlInprimagailua.Controls.Add(this.cmbKoloretakoa);
            this.pnlInprimagailua.Location = new System.Drawing.Point(30, 200);
            this.pnlInprimagailua.Name = "pnlInprimagailua";
            this.pnlInprimagailua.Size = new System.Drawing.Size(360, 80);
            this.pnlInprimagailua.TabIndex = 9;
            this.pnlInprimagailua.Visible = false;

            // 
            // lblKoloretakoa
            // 
            this.lblKoloretakoa.AutoSize = true;
            this.lblKoloretakoa.Location = new System.Drawing.Point(0, 0);
            this.lblKoloretakoa.Name = "lblKoloretakoa";
            this.lblKoloretakoa.Size = new System.Drawing.Size(107, 16);
            this.lblKoloretakoa.TabIndex = 0;
            this.lblKoloretakoa.Text = "Koloretakoa da?";

            // 
            // cmbKoloretakoa
            // 
            this.cmbKoloretakoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoloretakoa.FormattingEnabled = true;
            this.cmbKoloretakoa.Items.AddRange(new object[] {
            "Bai",
            "Ez"});
            this.cmbKoloretakoa.Location = new System.Drawing.Point(4, 25);
            this.cmbKoloretakoa.Name = "cmbKoloretakoa";
            this.cmbKoloretakoa.Size = new System.Drawing.Size(350, 24);
            this.cmbKoloretakoa.TabIndex = 1;

            // 
            // lblErosteData
            // 
            this.lblErosteData.AutoSize = true;
            this.lblErosteData.Location = new System.Drawing.Point(30, 340);
            this.lblErosteData.Name = "lblErosteData";
            this.lblErosteData.Size = new System.Drawing.Size(81, 16);
            this.lblErosteData.TabIndex = 10;
            this.lblErosteData.Text = "Eroste Data:";

            // 
            // dtpErosteData
            // 
            this.dtpErosteData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpErosteData.Location = new System.Drawing.Point(34, 365);
            this.dtpErosteData.Name = "dtpErosteData";
            this.dtpErosteData.Size = new System.Drawing.Size(350, 22);
            this.dtpErosteData.TabIndex = 11;

            // 
            // btnGorde
            // 
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.Location = new System.Drawing.Point(40, 420);
            this.btnGorde.Name = "btnGorde";
            this.btnGorde.Size = new System.Drawing.Size(150, 40);
            this.btnGorde.TabIndex = 12;
            this.btnGorde.Text = "💾 Gorde";
            this.btnGorde.UseVisualStyleBackColor = false;
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);

            // 
            // btnEzeztatu
            // 
            this.btnEzeztatu.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.Location = new System.Drawing.Point(230, 420);
            this.btnEzeztatu.Name = "btnEzeztatu";
            this.btnEzeztatu.Size = new System.Drawing.Size(150, 40);
            this.btnEzeztatu.TabIndex = 13;
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.UseVisualStyleBackColor = false;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);

            // 
            // FGailua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 490);
            this.Controls.Add(this.btnEzeztatu);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.dtpErosteData);
            this.Controls.Add(this.lblErosteData);
            this.Controls.Add(this.pnlInprimagailua);
            this.Controls.Add(this.pnlOrdenagailua);
            this.Controls.Add(this.txtGela);
            this.Controls.Add(this.lblGela);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.cmbMota);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGailua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FGailua";
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