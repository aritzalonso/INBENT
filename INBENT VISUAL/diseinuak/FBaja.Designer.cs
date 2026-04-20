namespace INBENT_VISUAL.diseinuak
{
    partial class FBaja
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblTituloa = new System.Windows.Forms.Label();
            this.lblDeskribapena = new System.Windows.Forms.Label();
            this.txtDeskribapena = new System.Windows.Forms.TextBox();
            this.btnGorde = new System.Windows.Forms.Button();
            this.btnEzeztatu = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTituloa
            this.lblTituloa.AutoSize = true;
            this.lblTituloa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloa.Location = new System.Drawing.Point(20, 20);
            this.lblTituloa.Text = "🗑️ Gailuari Baja Eman";

            // lblDeskribapena
            this.lblDeskribapena.AutoSize = true;
            this.lblDeskribapena.Location = new System.Drawing.Point(20, 70);
            this.lblDeskribapena.Text = "Zergatik emango diogu baja gailu honi? (Arrazoia):";

            // txtDeskribapena
            this.txtDeskribapena.Location = new System.Drawing.Point(24, 95);
            this.txtDeskribapena.Multiline = true;
            this.txtDeskribapena.Size = new System.Drawing.Size(330, 100);

            // btnGorde
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.Location = new System.Drawing.Point(24, 220);
            this.btnGorde.Size = new System.Drawing.Size(150, 40);
            this.btnGorde.Text = "💾 Gorde";
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);

            // btnEzeztatu
            this.btnEzeztatu.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.Location = new System.Drawing.Point(204, 220);
            this.btnEzeztatu.Size = new System.Drawing.Size(150, 40);
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);

            // FBaja
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.lblTituloa);
            this.Controls.Add(this.lblDeskribapena);
            this.Controls.Add(this.txtDeskribapena);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.btnEzeztatu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTituloa;
        private System.Windows.Forms.Label lblDeskribapena;
        public System.Windows.Forms.TextBox txtDeskribapena;
        private System.Windows.Forms.Button btnGorde;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}