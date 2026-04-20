namespace INBENT_VISUAL.diseinuak
{
    partial class FMatxura
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
            this.lblGailua = new System.Windows.Forms.Label();
            this.cmbGailua = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDeskribapena = new System.Windows.Forms.Label();
            this.txtDeskribapena = new System.Windows.Forms.TextBox();
            this.btnGorde = new System.Windows.Forms.Button();
            this.btnEzeztatu = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.panelHeader.Controls.Add(this.lblTituloa);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTituloa
            // 
            this.lblTituloa.AutoSize = true;
            this.lblTituloa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloa.ForeColor = System.Drawing.Color.White;
            this.lblTituloa.Location = new System.Drawing.Point(12, 11);
            this.lblTituloa.Name = "lblTituloa";
            this.lblTituloa.Size = new System.Drawing.Size(193, 28);
            this.lblTituloa.TabIndex = 0;
            this.lblTituloa.Text = "Matxuraren Datuak";
            // 
            // lblGailua
            // 
            this.lblGailua.AutoSize = true;
            this.lblGailua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGailua.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblGailua.Location = new System.Drawing.Point(30, 70);
            this.lblGailua.Name = "lblGailua";
            this.lblGailua.Size = new System.Drawing.Size(183, 23);
            this.lblGailua.TabIndex = 1;
            this.lblGailua.Text = "Matxuratutako Gailua:";
            // 
            // cmbGailua
            // 
            this.cmbGailua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGailua.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGailua.FormattingEnabled = true;
            this.cmbGailua.Location = new System.Drawing.Point(34, 100);
            this.cmbGailua.Name = "cmbGailua";
            this.cmbGailua.Size = new System.Drawing.Size(330, 33);
            this.cmbGailua.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblData.Location = new System.Drawing.Point(30, 150);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(117, 23);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Matxura Data:";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(34, 180);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(330, 32);
            this.dtpData.TabIndex = 4;
            // 
            // lblDeskribapena
            // 
            this.lblDeskribapena.AutoSize = true;
            this.lblDeskribapena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeskribapena.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblDeskribapena.Location = new System.Drawing.Point(30, 230);
            this.lblDeskribapena.Name = "lblDeskribapena";
            this.lblDeskribapena.Size = new System.Drawing.Size(119, 23);
            this.lblDeskribapena.TabIndex = 5;
            this.lblDeskribapena.Text = "Deskribapena:";
            // 
            // txtDeskribapena
            // 
            this.txtDeskribapena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDeskribapena.Location = new System.Drawing.Point(34, 260);
            this.txtDeskribapena.Multiline = true; // Permite escribir varias líneas
            this.txtDeskribapena.Name = "txtDeskribapena";
            this.txtDeskribapena.Size = new System.Drawing.Size(330, 80); // Caja más grande
            this.txtDeskribapena.TabIndex = 6;
            // 
            // btnGorde
            // 
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnGorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGorde.FlatAppearance.BorderSize = 0;
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.Location = new System.Drawing.Point(34, 360);
            this.btnGorde.Name = "btnGorde";
            this.btnGorde.Size = new System.Drawing.Size(150, 40);
            this.btnGorde.TabIndex = 7;
            this.btnGorde.Text = "💾 Gorde";
            this.btnGorde.UseVisualStyleBackColor = false;
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);
            // 
            // btnEzeztatu
            // 
            this.btnEzeztatu.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEzeztatu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEzeztatu.FlatAppearance.BorderSize = 0;
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.Location = new System.Drawing.Point(214, 360);
            this.btnEzeztatu.Name = "btnEzeztatu";
            this.btnEzeztatu.Size = new System.Drawing.Size(150, 40);
            this.btnEzeztatu.TabIndex = 8;
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.UseVisualStyleBackColor = false;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);
            // 
            // FMatxura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.btnEzeztatu);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.txtDeskribapena);
            this.Controls.Add(this.lblDeskribapena);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmbGailua);
            this.Controls.Add(this.lblGailua);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMatxura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matxura";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTituloa;
        private System.Windows.Forms.Label lblGailua;
        public System.Windows.Forms.ComboBox cmbGailua;
        private System.Windows.Forms.Label lblData;
        public System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDeskribapena;
        public System.Windows.Forms.TextBox txtDeskribapena;
        private System.Windows.Forms.Button btnGorde;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}