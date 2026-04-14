using System.Drawing.Drawing2D;

namespace INBENT_VISUAL
{
    partial class FHasiera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHasiera));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelLogin = new Panel();
            BIrten = new Button();
            BSaioa = new Button();
            TPasahitza = new TextBox();
            LPasahitza = new Label();
            TErabiltzailea = new TextBox();
            LErabiltzailea = new Label();
            LTitle = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panelLogin, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(784, 550);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(BIrten);
            panelLogin.Controls.Add(BSaioa);
            panelLogin.Controls.Add(TPasahitza);
            panelLogin.Controls.Add(LPasahitza);
            panelLogin.Controls.Add(TErabiltzailea);
            panelLogin.Controls.Add(LErabiltzailea);
            panelLogin.Controls.Add(LTitle);
            panelLogin.Location = new Point(161, 117);
            panelLogin.Margin = new Padding(0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(459, 316);
            panelLogin.TabIndex = 0;
            // 
            // BIrten
            // 
            BIrten.BackColor = Color.FromArgb(220, 220, 220);
            BIrten.FlatAppearance.BorderSize = 0;
            BIrten.FlatStyle = FlatStyle.Flat;
            BIrten.Font = new Font("Segoe UI", 11F);
            BIrten.ForeColor = Color.FromArgb(80, 80, 80);
            BIrten.Location = new Point(210, 250);
            BIrten.Name = "BIrten";
            BIrten.Size = new Size(160, 40);
            BIrten.TabIndex = 6;
            BIrten.Text = "Irten";
            BIrten.UseVisualStyleBackColor = false;
            BIrten.Click += BIrten_Click;
            // 
            // BSaioa
            // 
            BSaioa.BackColor = Color.FromArgb(70, 150, 200);
            BSaioa.FlatAppearance.BorderSize = 0;
            BSaioa.FlatStyle = FlatStyle.Flat;
            BSaioa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BSaioa.ForeColor = Color.White;
            BSaioa.Location = new Point(30, 250);
            BSaioa.Name = "BSaioa";
            BSaioa.Size = new Size(160, 40);
            BSaioa.TabIndex = 5;
            BSaioa.Text = "Sartu";
            BSaioa.UseVisualStyleBackColor = false;
            BSaioa.Click += BSaioa_Click;
            // 
            // TPasahitza
            // 
            TPasahitza.BorderStyle = BorderStyle.FixedSingle;
            TPasahitza.Font = new Font("Segoe UI", 11F);
            TPasahitza.Location = new Point(30, 182);
            TPasahitza.Name = "TPasahitza";
            TPasahitza.PlaceholderText = "Sartu zure pasahitza";
            TPasahitza.Size = new Size(340, 27);
            TPasahitza.TabIndex = 4;
            TPasahitza.UseSystemPasswordChar = true;
            // 
            // LPasahitza
            // 
            LPasahitza.AutoSize = true;
            LPasahitza.Font = new Font("Segoe UI", 10F);
            LPasahitza.ForeColor = Color.FromArgb(100, 100, 100);
            LPasahitza.Location = new Point(30, 160);
            LPasahitza.Name = "LPasahitza";
            LPasahitza.Size = new Size(66, 19);
            LPasahitza.TabIndex = 3;
            LPasahitza.Text = "Pasahitza";
            // 
            // TErabiltzailea
            // 
            TErabiltzailea.BorderStyle = BorderStyle.FixedSingle;
            TErabiltzailea.Font = new Font("Segoe UI", 11F);
            TErabiltzailea.Location = new Point(30, 107);
            TErabiltzailea.Name = "TErabiltzailea";
            TErabiltzailea.PlaceholderText = "Sartu zure erabiltzailea";
            TErabiltzailea.Size = new Size(340, 27);
            TErabiltzailea.TabIndex = 2;
            // 
            // LErabiltzailea
            // 
            LErabiltzailea.AutoSize = true;
            LErabiltzailea.Font = new Font("Segoe UI", 10F);
            LErabiltzailea.ForeColor = Color.FromArgb(100, 100, 100);
            LErabiltzailea.Location = new Point(30, 85);
            LErabiltzailea.Name = "LErabiltzailea";
            LErabiltzailea.Size = new Size(80, 19);
            LErabiltzailea.TabIndex = 1;
            LErabiltzailea.Text = "Erabiltzailea";
            // 
            // LTitle
            // 
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LTitle.ForeColor = Color.FromArgb(50, 50, 50);
            LTitle.Location = new Point(30, 31);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(140, 32);
            LTitle.TabIndex = 0;
            LTitle.Text = "Ongi etorri";
            LTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // FHasiera
            // 
            AcceptButton = BSaioa;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = BIrten;
            ClientSize = new Size(784, 550);
            Controls.Add(tableLayoutPanel1);
            Name = "FHasiera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saioa hasi";
            tableLayoutPanel1.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLogin;
        private Label LTitle;
        private Label LErabiltzailea;
        private TextBox TErabiltzailea;
        private Label LPasahitza;
        private TextBox TPasahitza;
        private Button BSaioa;
        private Button BIrten;
    }
}