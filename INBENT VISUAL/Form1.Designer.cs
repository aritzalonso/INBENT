namespace INBENT_VISUAL
{
    partial class FHasiera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TBErabiltzailea = new TextBox();
            TBPasahitza = new TextBox();
            BHasiSaioa = new Button();
            LHasiSaioa = new Label();
            LErabiltzailea = new Label();
            lPasahitza = new Label();
            SuspendLayout();
            // 
            // TBErabiltzailea
            // 
            TBErabiltzailea.Location = new Point(122, 181);
            TBErabiltzailea.Name = "TBErabiltzailea";
            TBErabiltzailea.Size = new Size(381, 23);
            TBErabiltzailea.TabIndex = 3;
            // 
            // TBPasahitza
            // 
            TBPasahitza.Location = new Point(122, 296);
            TBPasahitza.Name = "TBPasahitza";
            TBPasahitza.PasswordChar = '*';
            TBPasahitza.Size = new Size(381, 23);
            TBPasahitza.TabIndex = 4;
            // 
            // BHasiSaioa
            // 
            BHasiSaioa.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BHasiSaioa.Location = new Point(180, 381);
            BHasiSaioa.Name = "BHasiSaioa";
            BHasiSaioa.Size = new Size(260, 42);
            BHasiSaioa.TabIndex = 5;
            BHasiSaioa.Text = "HASI SAIOA";
            BHasiSaioa.UseVisualStyleBackColor = true;
            BHasiSaioa.Click += BHasiSaioa_Click;
            // 
            // LHasiSaioa
            // 
            LHasiSaioa.AutoSize = true;
            LHasiSaioa.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LHasiSaioa.Location = new Point(180, 46);
            LHasiSaioa.Name = "LHasiSaioa";
            LHasiSaioa.Size = new Size(260, 45);
            LHasiSaioa.TabIndex = 6;
            LHasiSaioa.Text = "INBENTARIOA";
            LHasiSaioa.Click += label1_Click;
            // 
            // LErabiltzailea
            // 
            LErabiltzailea.AutoSize = true;
            LErabiltzailea.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            LErabiltzailea.Location = new Point(122, 136);
            LErabiltzailea.Name = "LErabiltzailea";
            LErabiltzailea.Size = new Size(144, 23);
            LErabiltzailea.TabIndex = 7;
            LErabiltzailea.Text = "ERABILTZAILEA";
            // 
            // lPasahitza
            // 
            lPasahitza.AutoSize = true;
            lPasahitza.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lPasahitza.Location = new Point(122, 258);
            lPasahitza.Name = "lPasahitza";
            lPasahitza.Size = new Size(109, 23);
            lPasahitza.TabIndex = 8;
            lPasahitza.Text = "PASAHITZA";
            // 
            // FHasiera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(641, 463);
            Controls.Add(lPasahitza);
            Controls.Add(LErabiltzailea);
            Controls.Add(LHasiSaioa);
            Controls.Add(BHasiSaioa);
            Controls.Add(TBPasahitza);
            Controls.Add(TBErabiltzailea);
            Name = "FHasiera";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TBErabiltzailea;
        private TextBox TBPasahitza;
        private Button BHasiSaioa;
        private Label LHasiSaioa;
        private Label LErabiltzailea;
        private Label lPasahitza;
    }
}
