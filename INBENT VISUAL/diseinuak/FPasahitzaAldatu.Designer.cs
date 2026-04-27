namespace INBENT_VISUAL.diseinuak
{
    partial class FPasahitzaAldatu
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
            this.lblTitulua = new System.Windows.Forms.Label();
            this.lblPasahitza = new System.Windows.Forms.Label();
            this.txtPasahitza = new System.Windows.Forms.TextBox();
            this.lblKonfirmatu = new System.Windows.Forms.Label();
            this.txtKonfirmatu = new System.Windows.Forms.TextBox();
            this.btnOnartu = new System.Windows.Forms.Button();
            this.btnEzeztatu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulua
            // 
            this.lblTitulua.AutoSize = true;
            this.lblTitulua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblTitulua.Location = new System.Drawing.Point(30, 20);
            this.lblTitulua.Name = "lblTitulua";
            this.lblTitulua.Size = new System.Drawing.Size(193, 32);
            this.lblTitulua.TabIndex = 0;
            this.lblTitulua.Text = "🔒 Pasahitza Aldatu";
            // 
            // lblPasahitza
            // 
            this.lblPasahitza.AutoSize = true;
            this.lblPasahitza.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasahitza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPasahitza.Location = new System.Drawing.Point(30, 75);
            this.lblPasahitza.Name = "lblPasahitza";
            this.lblPasahitza.Size = new System.Drawing.Size(139, 23);
            this.lblPasahitza.TabIndex = 1;
            this.lblPasahitza.Text = "Pasahitz berria:";
            // 
            // txtPasahitza
            // 
            this.txtPasahitza.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasahitza.Location = new System.Drawing.Point(35, 100);
            this.txtPasahitza.Name = "txtPasahitza";
            this.txtPasahitza.Size = new System.Drawing.Size(310, 32);
            this.txtPasahitza.TabIndex = 2;
            this.txtPasahitza.UseSystemPasswordChar = true;
            // 
            // lblKonfirmatu
            // 
            this.lblKonfirmatu.AutoSize = true;
            this.lblKonfirmatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKonfirmatu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblKonfirmatu.Location = new System.Drawing.Point(30, 145);
            this.lblKonfirmatu.Name = "lblKonfirmatu";
            this.lblKonfirmatu.Size = new System.Drawing.Size(206, 23);
            this.lblKonfirmatu.TabIndex = 3;
            this.lblKonfirmatu.Text = "Konfirmatu pasahitza:";
            // 
            // txtKonfirmatu
            // 
            this.txtKonfirmatu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKonfirmatu.Location = new System.Drawing.Point(35, 170);
            this.txtKonfirmatu.Name = "txtKonfirmatu";
            this.txtKonfirmatu.Size = new System.Drawing.Size(310, 32);
            this.txtKonfirmatu.TabIndex = 4;
            this.txtKonfirmatu.UseSystemPasswordChar = true;
            // 
            // btnOnartu
            // 
            this.btnOnartu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOnartu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnartu.FlatAppearance.BorderSize = 0;
            this.btnOnartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnartu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnartu.ForeColor = System.Drawing.Color.White;
            this.btnOnartu.Location = new System.Drawing.Point(85, 230);
            this.btnOnartu.Name = "btnOnartu";
            this.btnOnartu.Size = new System.Drawing.Size(120, 40);
            this.btnOnartu.TabIndex = 5;
            this.btnOnartu.Text = "✅ Gorde";
            this.btnOnartu.UseVisualStyleBackColor = false;
            this.btnOnartu.Click += new System.EventHandler(this.btnOnartu_Click);
            // 
            // btnEzeztatu
            // 
            this.btnEzeztatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEzeztatu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEzeztatu.FlatAppearance.BorderSize = 0;
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.Location = new System.Drawing.Point(225, 230);
            this.btnEzeztatu.Name = "btnEzeztatu";
            this.btnEzeztatu.Size = new System.Drawing.Size(120, 40);
            this.btnEzeztatu.TabIndex = 6;
            this.btnEzeztatu.Text = "❌ Ezeztatu";
            this.btnEzeztatu.UseVisualStyleBackColor = false;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);
            // 
            // FPasahitzaAldatu
            // 
            this.AcceptButton = this.btnOnartu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnEzeztatu;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.btnEzeztatu);
            this.Controls.Add(this.btnOnartu);
            this.Controls.Add(this.txtKonfirmatu);
            this.Controls.Add(this.lblKonfirmatu);
            this.Controls.Add(this.txtPasahitza);
            this.Controls.Add(this.lblPasahitza);
            this.Controls.Add(this.lblTitulua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPasahitzaAldatu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pasahitza Aldatu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulua;
        private System.Windows.Forms.Label lblPasahitza;
        private System.Windows.Forms.TextBox txtPasahitza;
        private System.Windows.Forms.Label lblKonfirmatu;
        private System.Windows.Forms.TextBox txtKonfirmatu;
        private System.Windows.Forms.Button btnOnartu;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}