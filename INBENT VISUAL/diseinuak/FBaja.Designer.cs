namespace INBENT_VISUAL.diseinuak
{
    partial class FBaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloa = new System.Windows.Forms.Label();
            this.lblDeskribapena = new System.Windows.Forms.Label();
            this.txtDeskribapena = new System.Windows.Forms.TextBox();
            this.btnGorde = new System.Windows.Forms.Button();
            this.btnEzeztatu = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTituloa
            // 
            this.lblTituloa.AutoSize = true;
            this.lblTituloa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloa.Location = new System.Drawing.Point(20, 20);
            this.lblTituloa.Name = "lblTituloa";
            this.lblTituloa.Size = new System.Drawing.Size(200, 28);
            this.lblTituloa.TabIndex = 0;
            this.lblTituloa.Text = "🗑️ Gailuari Baja Eman";

            // 
            // lblDeskribapena
            // 
            this.lblDeskribapena.AutoSize = true;
            this.lblDeskribapena.Location = new System.Drawing.Point(20, 70);
            this.lblDeskribapena.Name = "lblDeskribapena";
            this.lblDeskribapena.Size = new System.Drawing.Size(280, 16);
            this.lblDeskribapena.TabIndex = 1;
            this.lblDeskribapena.Text = "Zergatik emango diogu baja gailu honi? (Arrazoia):";

            // 
            // txtDeskribapena
            // 
            this.txtDeskribapena.Location = new System.Drawing.Point(24, 95);
            this.txtDeskribapena.Multiline = true;
            this.txtDeskribapena.Name = "txtDeskribapena";
            this.txtDeskribapena.Size = new System.Drawing.Size(330, 100);
            this.txtDeskribapena.TabIndex = 2;

            // 
            // btnGorde
            // 
            this.btnGorde.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnGorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorde.ForeColor = System.Drawing.Color.White;
            this.btnGorde.Location = new System.Drawing.Point(24, 220);
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
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.Location = new System.Drawing.Point(204, 220);
            this.btnEzeztatu.Name = "btnEzeztatu";
            this.btnEzeztatu.Size = new System.Drawing.Size(150, 40);
            this.btnEzeztatu.TabIndex = 4;
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.UseVisualStyleBackColor = false;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);

            // 
            // FBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.btnEzeztatu);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.txtDeskribapena);
            this.Controls.Add(this.lblDeskribapena);
            this.Controls.Add(this.lblTituloa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Baja Eman";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloa;
        private System.Windows.Forms.Label lblDeskribapena;
        public System.Windows.Forms.TextBox txtDeskribapena;
        private System.Windows.Forms.Button btnGorde;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}