using System.Drawing;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    partial class FLogin : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BIrten = new System.Windows.Forms.Button();
            this.BSaioa = new System.Windows.Forms.Button();
            this.txtPasahitza = new System.Windows.Forms.TextBox();
            this.LPasahitza = new System.Windows.Forms.Label();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.LErabiltzailea = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();

            this.tableLayoutPanel1.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelLogin, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 733);
            this.tableLayoutPanel1.TabIndex = 0;

            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.BIrten);
            this.panelLogin.Controls.Add(this.BSaioa);
            this.panelLogin.Controls.Add(this.txtPasahitza);
            this.panelLogin.Controls.Add(this.LPasahitza);
            this.panelLogin.Controls.Add(this.txtIzena);
            this.panelLogin.Controls.Add(this.LErabiltzailea);
            this.panelLogin.Controls.Add(this.LTitle);
            this.panelLogin.Location = new System.Drawing.Point(185, 155);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(524, 421);
            this.panelLogin.TabIndex = 0;

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(375, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;

            // 
            // BIrten
            // 
            this.BIrten.BackColor = System.Drawing.Color.White;
            this.BIrten.FlatAppearance.BorderSize = 0;
            this.BIrten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.BIrten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIrten.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BIrten.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.BIrten.Location = new System.Drawing.Point(240, 333);
            this.BIrten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BIrten.Name = "BIrten";
            this.BIrten.Size = new System.Drawing.Size(183, 53);
            this.BIrten.TabIndex = 6;
            this.BIrten.Text = "Irten";
            this.BIrten.UseVisualStyleBackColor = false;
            this.BIrten.Click += new System.EventHandler(this.BIrten_Click);

            // 
            // BSaioa
            // 
            this.BSaioa.BackColor = System.Drawing.Color.FromArgb(119, 141, 169);
            this.BSaioa.FlatAppearance.BorderSize = 0;
            this.BSaioa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSaioa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BSaioa.ForeColor = System.Drawing.Color.White;
            this.BSaioa.Location = new System.Drawing.Point(34, 333);
            this.BSaioa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BSaioa.Name = "BSaioa";
            this.BSaioa.Size = new System.Drawing.Size(183, 53);
            this.BSaioa.TabIndex = 5;
            this.BSaioa.Text = "Sartu";
            this.BSaioa.UseVisualStyleBackColor = false;
            this.BSaioa.Click += new System.EventHandler(this.BSaioa_Click_1);

            // 
            // txtPasahitza
            // 
            this.txtPasahitza.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtPasahitza.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPasahitza.Location = new System.Drawing.Point(34, 243);
            this.txtPasahitza.Margin = new System.Windows.Forms.Padding(10);
            this.txtPasahitza.Name = "txtPasahitza";
            this.txtPasahitza.PlaceholderText = "  Sartu zure pasahitza";
            this.txtPasahitza.Size = new System.Drawing.Size(388, 36);
            this.txtPasahitza.TabIndex = 4;
            this.txtPasahitza.UseSystemPasswordChar = true;

            // 
            // LPasahitza
            // 
            this.LPasahitza.AutoSize = true;
            this.LPasahitza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LPasahitza.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.LPasahitza.Location = new System.Drawing.Point(30, 213);
            this.LPasahitza.Name = "LPasahitza";
            this.LPasahitza.Size = new System.Drawing.Size(81, 23);
            this.LPasahitza.TabIndex = 3;
            this.LPasahitza.Text = "Pasahitza";

            // 
            // txtIzena
            // 
            this.txtIzena.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txtIzena.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtIzena.Location = new System.Drawing.Point(34, 143);
            this.txtIzena.Margin = new System.Windows.Forms.Padding(10);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.PlaceholderText = "  Sartu zure erabiltzailea";
            this.txtIzena.Size = new System.Drawing.Size(388, 36);
            this.txtIzena.TabIndex = 2;

            // 
            // LErabiltzailea
            // 
            this.LErabiltzailea.AutoSize = true;
            this.LErabiltzailea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LErabiltzailea.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.LErabiltzailea.Location = new System.Drawing.Point(30, 113);
            this.LErabiltzailea.Name = "LErabiltzailea";
            this.LErabiltzailea.Size = new System.Drawing.Size(101, 23);
            this.LErabiltzailea.TabIndex = 1;
            this.LErabiltzailea.Text = "Erabiltzailea";

            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.LTitle.Location = new System.Drawing.Point(30, 41);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(197, 46);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Ongi etorri";
            this.LTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // FLogin
            // 
            this.AcceptButton = this.BSaioa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.CancelButton = this.BIrten;
            this.ClientSize = new System.Drawing.Size(896, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saioa hasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LErabiltzailea;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.Label LPasahitza;
        private System.Windows.Forms.TextBox txtPasahitza;
        private System.Windows.Forms.Button BSaioa;
        private System.Windows.Forms.Button BIrten;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}