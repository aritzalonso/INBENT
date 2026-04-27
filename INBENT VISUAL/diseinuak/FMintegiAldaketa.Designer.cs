namespace INBENT_VISUAL.diseinuak
{
    partial class FMintegiAldaketa
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
            this.lblInformazioa = new System.Windows.Forms.Label();
            this.cmbMintegiBerria = new System.Windows.Forms.ComboBox();
            this.btnOnartu = new System.Windows.Forms.Button();
            this.btnEzeztatu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformazioa
            // 
            this.lblInformazioa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformazioa.Location = new System.Drawing.Point(20, 20);
            this.lblInformazioa.Name = "lblInformazioa";
            this.lblInformazioa.Size = new System.Drawing.Size(440, 50);
            this.lblInformazioa.TabIndex = 0;
            this.lblInformazioa.Text = "Mintegia ezabatzean, nora eraman nahi dituzu gailuak eta erabiltzaileak?";
            this.lblInformazioa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMintegiBerria
            // 
            this.cmbMintegiBerria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMintegiBerria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMintegiBerria.FormattingEnabled = true;
            this.cmbMintegiBerria.Location = new System.Drawing.Point(80, 80);
            this.cmbMintegiBerria.Name = "cmbMintegiBerria";
            this.cmbMintegiBerria.Size = new System.Drawing.Size(320, 25);
            this.cmbMintegiBerria.TabIndex = 1;
            // 
            // btnOnartu
            // 
            this.btnOnartu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOnartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnartu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnartu.ForeColor = System.Drawing.Color.White;
            this.btnOnartu.Location = new System.Drawing.Point(120, 140);
            this.btnOnartu.Name = "btnOnartu";
            this.btnOnartu.Size = new System.Drawing.Size(100, 35);
            this.btnOnartu.TabIndex = 2;
            this.btnOnartu.Text = "Onartu";
            this.btnOnartu.UseVisualStyleBackColor = false;
            this.btnOnartu.Click += new System.EventHandler(this.btnOnartu_Click);
            // 
            // btnEzeztatu
            // 
            this.btnEzeztatu.BackColor = System.Drawing.Color.IndianRed;
            this.btnEzeztatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzeztatu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEzeztatu.ForeColor = System.Drawing.Color.White;
            this.btnEzeztatu.Location = new System.Drawing.Point(260, 140);
            this.btnEzeztatu.Name = "btnEzeztatu";
            this.btnEzeztatu.Size = new System.Drawing.Size(100, 35);
            this.btnEzeztatu.TabIndex = 3;
            this.btnEzeztatu.Text = "Ezeztatu";
            this.btnEzeztatu.UseVisualStyleBackColor = false;
            this.btnEzeztatu.Click += new System.EventHandler(this.btnEzeztatu_Click);
            // 
            // FMintegiAldaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Controls.Add(this.btnEzeztatu);
            this.Controls.Add(this.btnOnartu);
            this.Controls.Add(this.cmbMintegiBerria);
            this.Controls.Add(this.lblInformazioa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMintegiAldaketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mintegien Migrazioa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInformazioa;
        private System.Windows.Forms.ComboBox cmbMintegiBerria;
        private System.Windows.Forms.Button btnOnartu;
        private System.Windows.Forms.Button btnEzeztatu;
    }
}