namespace INBENT_VISUAL.diseinuak
{
    partial class FMintegia
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
            this.lblIzena = new System.Windows.Forms.Label();
            this.txtIzena = new System.Windows.Forms.TextBox();
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
            this.lblTituloa.Size = new System.Drawing.Size(183, 28);
            this.lblTituloa.TabIndex = 0;
            this.lblTituloa.Text = "Mintegiaren Datuak";
            // 
            // lblIzena
            // 
            this.lblIzena.AutoSize = true;
            this.lblIzena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIzena.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblIzena.Location = new System.Drawing.Point(30, 80);
            this.lblIzena.Name = "lblIzena";
            this.lblIzena.Size = new System.Drawing.Size(147, 23);
            this.lblIzena.TabIndex = 1;
            this.lblIzena.Text = "Mintegiaren Izena:";
            // 
            // txtIzena
            // 
            this.txtIzena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtIzena.Location = new System.Drawing.Point(34, 110);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(330, 32);
            this.txtIzena.TabIndex = 2;
            // 
            // btnGorde
            // 
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnGorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGorde.FlatAppearance.BorderSize = 0;
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.Location = new System.Drawing.Point(34, 170);
            this.btnGorde.Name = "btnGorde";
            this.btnGorde.Size = new System.Drawing.Size(150, 40);
            this.btnGorde.TabIndex = 3;
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
            this.btnEzeztatu.Location = new System.Drawing.Point(214, 170);
            this.btnEzeztatu.Name = "btnEzeztatu";
            this.btnEzeztatu.Size = new System.Drawing.Size(150, 40);
            this.btnEzeztatu.TabIndex = 4;
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.UseVisualStyleBackColor = false;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);
            // 
            // FMintegia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.btnEzeztatu);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.lblIzena);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMintegia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mintegia";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTituloa;
        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.Button btnGorde;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}