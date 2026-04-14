using System.Drawing;
using System.Windows.Forms;

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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(896, 733);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(BIrten);
            panelLogin.Controls.Add(BSaioa);
            panelLogin.Controls.Add(TPasahitza);
            panelLogin.Controls.Add(LPasahitza);
            panelLogin.Controls.Add(TErabiltzailea);
            panelLogin.Controls.Add(LErabiltzailea);
            panelLogin.Controls.Add(LTitle);
            panelLogin.Location = new Point(185, 155);
            panelLogin.Margin = new Padding(0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(524, 421);
            panelLogin.TabIndex = 0;
            // 
            // BIrten
            // 
            BIrten.BackColor = Color.White;
            BIrten.FlatAppearance.BorderSize = 0;
            BIrten.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            BIrten.FlatStyle = FlatStyle.Flat;
            BIrten.Font = new Font("Segoe UI", 11F);
            BIrten.ForeColor = Color.FromArgb(120, 120, 120);
            BIrten.Location = new Point(240, 333);
            BIrten.Margin = new Padding(3, 4, 3, 4);
            BIrten.Name = "BIrten";
            BIrten.Size = new Size(183, 53);
            BIrten.TabIndex = 6;
            BIrten.Text = "Irten";
            BIrten.UseVisualStyleBackColor = false;
            // 
            // BSaioa
            // 
            BSaioa.BackColor = Color.FromArgb(119, 141, 169);
            BSaioa.FlatAppearance.BorderSize = 0;
            BSaioa.FlatStyle = FlatStyle.Flat;
            BSaioa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BSaioa.ForeColor = Color.White;
            BSaioa.Location = new Point(34, 333);
            BSaioa.Margin = new Padding(3, 4, 3, 4);
            BSaioa.Name = "BSaioa";
            BSaioa.Size = new Size(183, 53);
            BSaioa.TabIndex = 5;
            BSaioa.Text = "Sartu";
            BSaioa.UseVisualStyleBackColor = false;
            // 
            // TPasahitza
            // 
            TPasahitza.BackColor = Color.FromArgb(245, 247, 250);
            TPasahitza.Font = new Font("Segoe UI", 13F);
            TPasahitza.Location = new Point(34, 243);
            TPasahitza.Margin = new Padding(10);
            TPasahitza.Name = "TPasahitza";
            TPasahitza.PlaceholderText = "  Sartu zure pasahitza";
            TPasahitza.Size = new Size(388, 36);
            TPasahitza.TabIndex = 4;
            TPasahitza.UseSystemPasswordChar = true;
            // 
            // LPasahitza
            // 
            LPasahitza.AutoSize = true;
            LPasahitza.Font = new Font("Segoe UI", 10F);
            LPasahitza.ForeColor = Color.FromArgb(100, 100, 100);
            LPasahitza.Location = new Point(30, 213);
            LPasahitza.Name = "LPasahitza";
            LPasahitza.Size = new Size(81, 23);
            LPasahitza.TabIndex = 3;
            LPasahitza.Text = "Pasahitza";
            // 
            // TErabiltzailea
            // 
            TErabiltzailea.BackColor = Color.FromArgb(245, 247, 250);
            TErabiltzailea.Font = new Font("Segoe UI", 13F);
            TErabiltzailea.Location = new Point(34, 143);
            TErabiltzailea.Margin = new Padding(10);
            TErabiltzailea.Name = "TErabiltzailea";
            TErabiltzailea.PlaceholderText = "  Sartu zure erabiltzailea";
            TErabiltzailea.Size = new Size(388, 36);
            TErabiltzailea.TabIndex = 2;
            // 
            // LErabiltzailea
            // 
            LErabiltzailea.AutoSize = true;
            LErabiltzailea.Font = new Font("Segoe UI", 10F);
            LErabiltzailea.ForeColor = Color.FromArgb(100, 100, 100);
            LErabiltzailea.Location = new Point(30, 113);
            LErabiltzailea.Name = "LErabiltzailea";
            LErabiltzailea.Size = new Size(101, 23);
            LErabiltzailea.TabIndex = 1;
            LErabiltzailea.Text = "Erabiltzailea";
            // 
            // LTitle
            // 
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LTitle.ForeColor = Color.FromArgb(60, 60, 60);
            LTitle.Location = new Point(30, 41);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(197, 46);
            LTitle.TabIndex = 0;
            LTitle.Text = "Ongi etorri";
            LTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(375, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FHasiera
            // 
            AcceptButton = BSaioa;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = BIrten;
            ClientSize = new Size(896, 733);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FHasiera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saioa hasi";
            Load += FHasiera_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}