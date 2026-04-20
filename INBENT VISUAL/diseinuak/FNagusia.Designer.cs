using System.Drawing;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    partial class FNagusia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMintegiak = new System.Windows.Forms.Button();
            this.btnErabiltzaileak = new System.Windows.Forms.Button();
            this.btnMatxurak = new System.Windows.Forms.Button();
            this.btnGailuak = new System.Windows.Forms.Button();
            this.btnHasiera = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelGailuak = new System.Windows.Forms.Panel();

            // BERRIA: Bilatzailearen elementuak
            this.lblBilatzailea = new System.Windows.Forms.Label();
            this.txtBilatzailea = new System.Windows.Forms.TextBox();

            this.lblFiltroMota = new System.Windows.Forms.Label();
            this.cmbFiltroMota = new System.Windows.Forms.ComboBox();
            this.lblFiltroGailuak = new System.Windows.Forms.Label();
            this.cmbFiltroGailuak = new System.Windows.Forms.ComboBox();
            this.btnHistoriala = new System.Windows.Forms.Button();
            this.btnAltaMatxura = new System.Windows.Forms.Button();
            this.btnBajaGailua = new System.Windows.Forms.Button();
            this.btnAldatuGailua = new System.Windows.Forms.Button();
            this.btnAltaGailua = new System.Windows.Forms.Button();
            this.dgvGailuak = new System.Windows.Forms.DataGridView();
            this.panelHasiera = new System.Windows.Forms.Panel();
            this.lblAzalpena = new System.Windows.Forms.Label();
            this.lblOngiEtorri = new System.Windows.Forms.Label();
            this.panelContenedorTarjetas = new System.Windows.Forms.Panel();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblGailuKop = new System.Windows.Forms.Label();
            this.lblTituloGailuak = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblErabiltzaileKop = new System.Windows.Forms.Label();
            this.lblTituloErabiltzaileak = new System.Windows.Forms.Label();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblMatxuraKop = new System.Windows.Forms.Label();
            this.lblTituloMatxurak = new System.Windows.Forms.Label();
            this.panelErabiltzaileak = new System.Windows.Forms.Panel();
            this.dgvErabiltzaileak = new System.Windows.Forms.DataGridView();
            this.btnBajaErabiltzailea = new System.Windows.Forms.Button();
            this.btnAldatuErabiltzailea = new System.Windows.Forms.Button();
            this.btnAltaErabiltzailea = new System.Windows.Forms.Button();
            this.panelMintegiak = new System.Windows.Forms.Panel();
            this.btnEzabatuMintegia = new System.Windows.Forms.Button();
            this.btnMintegiaSortu = new System.Windows.Forms.Button();
            this.dgvMintegiak = new System.Windows.Forms.DataGridView();
            this.panelMatxurak = new System.Windows.Forms.Panel();
            this.btnKonpondu = new System.Windows.Forms.Button();
            this.dgvMatxurak = new System.Windows.Forms.DataGridView();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelGailuak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGailuak)).BeginInit();
            this.panelHasiera.SuspendLayout();
            this.panelContenedorTarjetas.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.panelErabiltzaileak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErabiltzaileak)).BeginInit();
            this.panelMintegiak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMintegiak)).BeginInit();
            this.panelMatxurak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatxurak)).BeginInit();
            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.panel1.Controls.Add(this.btnMintegiak);
            this.panel1.Controls.Add(this.btnErabiltzaileak);
            this.panel1.Controls.Add(this.btnMatxurak);
            this.panel1.Controls.Add(this.btnGailuak);
            this.panel1.Controls.Add(this.btnHasiera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 768);
            this.panel1.TabIndex = 0;

            // 
            // btnMintegiak
            // 
            this.btnMintegiak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMintegiak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMintegiak.FlatAppearance.BorderSize = 0;
            this.btnMintegiak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMintegiak.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMintegiak.ForeColor = System.Drawing.Color.White;
            this.btnMintegiak.Location = new System.Drawing.Point(0, 210);
            this.btnMintegiak.Name = "btnMintegiak";
            this.btnMintegiak.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMintegiak.Size = new System.Drawing.Size(250, 38);
            this.btnMintegiak.TabIndex = 0;
            this.btnMintegiak.Text = "📁  Mintegiak Kudeatu";
            this.btnMintegiak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMintegiak.Click += new System.EventHandler(this.btnMintegiak_Click);

            // 
            // btnErabiltzaileak
            // 
            this.btnErabiltzaileak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErabiltzaileak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnErabiltzaileak.FlatAppearance.BorderSize = 0;
            this.btnErabiltzaileak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErabiltzaileak.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnErabiltzaileak.ForeColor = System.Drawing.Color.White;
            this.btnErabiltzaileak.Location = new System.Drawing.Point(0, 162);
            this.btnErabiltzaileak.Name = "btnErabiltzaileak";
            this.btnErabiltzaileak.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnErabiltzaileak.Size = new System.Drawing.Size(250, 48);
            this.btnErabiltzaileak.TabIndex = 1;
            this.btnErabiltzaileak.Text = "👥  Erabiltzaileak Kudeatu";
            this.btnErabiltzaileak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErabiltzaileak.Click += new System.EventHandler(this.btnErabiltzaileak_Click);

            // 
            // btnMatxurak
            // 
            this.btnMatxurak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatxurak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatxurak.FlatAppearance.BorderSize = 0;
            this.btnMatxurak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatxurak.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMatxurak.ForeColor = System.Drawing.Color.White;
            this.btnMatxurak.Location = new System.Drawing.Point(0, 108);
            this.btnMatxurak.Name = "btnMatxurak";
            this.btnMatxurak.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMatxurak.Size = new System.Drawing.Size(250, 54);
            this.btnMatxurak.TabIndex = 2;
            this.btnMatxurak.Text = "🔧  Matxurak";
            this.btnMatxurak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatxurak.Click += new System.EventHandler(this.btnMatxurak_Click);

            // 
            // btnGailuak
            // 
            this.btnGailuak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGailuak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGailuak.FlatAppearance.BorderSize = 0;
            this.btnGailuak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGailuak.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGailuak.ForeColor = System.Drawing.Color.White;
            this.btnGailuak.Location = new System.Drawing.Point(0, 60);
            this.btnGailuak.Name = "btnGailuak";
            this.btnGailuak.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGailuak.Size = new System.Drawing.Size(250, 48);
            this.btnGailuak.TabIndex = 3;
            this.btnGailuak.Text = "💻  Gailuak";
            this.btnGailuak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGailuak.Click += new System.EventHandler(this.btnGailuak_Click);

            // 
            // btnHasiera
            // 
            this.btnHasiera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHasiera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasiera.FlatAppearance.BorderSize = 0;
            this.btnHasiera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasiera.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHasiera.ForeColor = System.Drawing.Color.White;
            this.btnHasiera.Location = new System.Drawing.Point(0, 0);
            this.btnHasiera.Name = "btnHasiera";
            this.btnHasiera.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHasiera.Size = new System.Drawing.Size(250, 60);
            this.btnHasiera.TabIndex = 4;
            this.btnHasiera.Text = "🏠  Hasiera";
            this.btnHasiera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasiera.Click += new System.EventHandler(this.btnHasiera_Click);

            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 65);
            this.panel2.TabIndex = 1;

            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.label2.Location = new System.Drawing.Point(520, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Erabiltzailea / Rola";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izarraitz LHII Inbentarioa";

            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panel3.Controls.Add(this.panelGailuak);
            this.panel3.Controls.Add(this.panelHasiera);
            this.panel3.Controls.Add(this.panelErabiltzaileak);
            this.panel3.Controls.Add(this.panelMintegiak);
            this.panel3.Controls.Add(this.panelMatxurak);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 703);
            this.panel3.TabIndex = 0;

            // 
            // panelGailuak
            // 
            this.panelGailuak.Controls.Add(this.lblBilatzailea);
            this.panelGailuak.Controls.Add(this.txtBilatzailea);
            this.panelGailuak.Controls.Add(this.lblFiltroMota);
            this.panelGailuak.Controls.Add(this.cmbFiltroMota);
            this.panelGailuak.Controls.Add(this.lblFiltroGailuak);
            this.panelGailuak.Controls.Add(this.cmbFiltroGailuak);
            this.panelGailuak.Controls.Add(this.btnHistoriala);
            this.panelGailuak.Controls.Add(this.btnAltaMatxura);
            this.panelGailuak.Controls.Add(this.btnBajaGailua);
            this.panelGailuak.Controls.Add(this.btnAldatuGailua);
            this.panelGailuak.Controls.Add(this.btnAltaGailua);
            this.panelGailuak.Controls.Add(this.dgvGailuak);
            this.panelGailuak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGailuak.Location = new System.Drawing.Point(0, 0);
            this.panelGailuak.Name = "panelGailuak";
            this.panelGailuak.Size = new System.Drawing.Size(774, 703);
            this.panelGailuak.TabIndex = 3;

            // 
            // lblBilatzailea
            // 
            this.lblBilatzailea.AutoSize = true;
            this.lblBilatzailea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBilatzailea.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblBilatzailea.Location = new System.Drawing.Point(6, 17);
            this.lblBilatzailea.Name = "lblBilatzailea";
            this.lblBilatzailea.Size = new System.Drawing.Size(84, 23);
            this.lblBilatzailea.TabIndex = 10;
            this.lblBilatzailea.Text = "🔍 Bilatu:";

            // 
            // txtBilatzailea
            // 
            this.txtBilatzailea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBilatzailea.Location = new System.Drawing.Point(90, 14);
            this.txtBilatzailea.Name = "txtBilatzailea";
            this.txtBilatzailea.Size = new System.Drawing.Size(140, 30);
            this.txtBilatzailea.TabIndex = 11;
            this.txtBilatzailea.TextChanged += new System.EventHandler(this.txtBilatzailea_TextChanged);

            // 
            // lblFiltroMota
            // 
            this.lblFiltroMota.AutoSize = true;
            this.lblFiltroMota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFiltroMota.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblFiltroMota.Location = new System.Drawing.Point(240, 17);
            this.lblFiltroMota.Name = "lblFiltroMota";
            this.lblFiltroMota.Size = new System.Drawing.Size(65, 23);
            this.lblFiltroMota.TabIndex = 8;
            this.lblFiltroMota.Text = "Gailua:";

            // 
            // cmbFiltroMota
            // 
            this.cmbFiltroMota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroMota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroMota.FormattingEnabled = true;
            this.cmbFiltroMota.Items.AddRange(new object[] { "Denak", "Ordenagailua", "Inprimagailua" });
            this.cmbFiltroMota.Location = new System.Drawing.Point(305, 14);
            this.cmbFiltroMota.Name = "cmbFiltroMota";
            this.cmbFiltroMota.Size = new System.Drawing.Size(120, 31);
            this.cmbFiltroMota.TabIndex = 9;
            this.cmbFiltroMota.SelectedIndexChanged += new System.EventHandler(this.txtBilatzailea_TextChanged); // Reusamos el método filtrado

            // 
            // lblFiltroGailuak
            // 
            this.lblFiltroGailuak.AutoSize = true;
            this.lblFiltroGailuak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFiltroGailuak.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblFiltroGailuak.Location = new System.Drawing.Point(435, 17);
            this.lblFiltroGailuak.Name = "lblFiltroGailuak";
            this.lblFiltroGailuak.Size = new System.Drawing.Size(70, 23);
            this.lblFiltroGailuak.TabIndex = 5;
            this.lblFiltroGailuak.Text = "Egoera:";

            // 
            // cmbFiltroGailuak
            // 
            this.cmbFiltroGailuak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroGailuak.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltroGailuak.FormattingEnabled = true;
            this.cmbFiltroGailuak.Items.AddRange(new object[] { "Denak", "Aktiboak", "Matxuratuak", "Bajan" });
            this.cmbFiltroGailuak.Location = new System.Drawing.Point(505, 14);
            this.cmbFiltroGailuak.Name = "cmbFiltroGailuak";
            this.cmbFiltroGailuak.Size = new System.Drawing.Size(120, 31);
            this.cmbFiltroGailuak.TabIndex = 6;
            this.cmbFiltroGailuak.SelectedIndexChanged += new System.EventHandler(this.txtBilatzailea_TextChanged); // Reusamos el método filtrado

            // 
            // btnHistoriala
            // 
            this.btnHistoriala.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnHistoriala.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnHistoriala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoriala.FlatAppearance.BorderSize = 0;
            this.btnHistoriala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoriala.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistoriala.ForeColor = System.Drawing.Color.White;
            this.btnHistoriala.Location = new System.Drawing.Point(630, 12);
            this.btnHistoriala.Name = "btnHistoriala";
            this.btnHistoriala.Size = new System.Drawing.Size(135, 35);
            this.btnHistoriala.TabIndex = 7;
            this.btnHistoriala.Text = "📚 Historiala";
            this.btnHistoriala.UseVisualStyleBackColor = false;
            this.btnHistoriala.Click += new System.EventHandler(this.btnHistoriala_Click);

            // 
            // btnAltaMatxura
            // 
            this.btnAltaMatxura.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnAltaMatxura.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnAltaMatxura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaMatxura.FlatAppearance.BorderSize = 0;
            this.btnAltaMatxura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaMatxura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAltaMatxura.ForeColor = System.Drawing.Color.White;
            this.btnAltaMatxura.Location = new System.Drawing.Point(530, 520);
            this.btnAltaMatxura.Name = "btnAltaMatxura";
            this.btnAltaMatxura.Size = new System.Drawing.Size(180, 40);
            this.btnAltaMatxura.TabIndex = 4;
            this.btnAltaMatxura.Text = "🔧 Matxura Berria";
            this.btnAltaMatxura.UseVisualStyleBackColor = false;
            this.btnAltaMatxura.Click += new System.EventHandler(this.btnAltaMatxura_Click);

            // 
            // btnBajaGailua
            // 
            this.btnBajaGailua.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnBajaGailua.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnBajaGailua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaGailua.FlatAppearance.BorderSize = 0;
            this.btnBajaGailua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaGailua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBajaGailua.ForeColor = System.Drawing.Color.White;
            this.btnBajaGailua.Location = new System.Drawing.Point(366, 520);
            this.btnBajaGailua.Name = "btnBajaGailua";
            this.btnBajaGailua.Size = new System.Drawing.Size(140, 40);
            this.btnBajaGailua.TabIndex = 0;
            this.btnBajaGailua.Text = "🗑️ Baja Eman";
            this.btnBajaGailua.UseVisualStyleBackColor = false;
            this.btnBajaGailua.Click += new System.EventHandler(this.btnBajaGailua_Click);

            // 
            // btnAldatuGailua
            // 
            this.btnAldatuGailua.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnAldatuGailua.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAldatuGailua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAldatuGailua.FlatAppearance.BorderSize = 0;
            this.btnAldatuGailua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAldatuGailua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAldatuGailua.ForeColor = System.Drawing.Color.White;
            this.btnAldatuGailua.Location = new System.Drawing.Point(200, 520);
            this.btnAldatuGailua.Name = "btnAldatuGailua";
            this.btnAldatuGailua.Size = new System.Drawing.Size(140, 40);
            this.btnAldatuGailua.TabIndex = 1;
            this.btnAldatuGailua.Text = "✏️ Aldatu";
            this.btnAldatuGailua.UseVisualStyleBackColor = false;
            this.btnAldatuGailua.Click += new System.EventHandler(this.btnAldatuGailua_Click);

            // 
            // btnAltaGailua
            // 
            this.btnAltaGailua.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnAltaGailua.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAltaGailua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaGailua.FlatAppearance.BorderSize = 0;
            this.btnAltaGailua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaGailua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAltaGailua.ForeColor = System.Drawing.Color.White;
            this.btnAltaGailua.Location = new System.Drawing.Point(40, 520);
            this.btnAltaGailua.Name = "btnAltaGailua";
            this.btnAltaGailua.Size = new System.Drawing.Size(140, 40);
            this.btnAltaGailua.TabIndex = 2;
            this.btnAltaGailua.Text = "➕ Alta Eman";
            this.btnAltaGailua.UseVisualStyleBackColor = false;
            this.btnAltaGailua.Click += new System.EventHandler(this.btnAltaGailua_Click);

            // 
            // dgvGailuak
            // 
            this.dgvGailuak.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvGailuak.BackgroundColor = System.Drawing.Color.White;
            this.dgvGailuak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGailuak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGailuak.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGailuak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGailuak.ColumnHeadersHeight = 40;
            this.dgvGailuak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGailuak.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGailuak.EnableHeadersVisualStyles = false;
            this.dgvGailuak.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvGailuak.Location = new System.Drawing.Point(6, 60);
            this.dgvGailuak.Name = "dgvGailuak";
            this.dgvGailuak.RowHeadersVisible = false;
            this.dgvGailuak.RowHeadersWidth = 51;
            this.dgvGailuak.RowTemplate.Height = 35;
            this.dgvGailuak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGailuak.Size = new System.Drawing.Size(768, 430);
            this.dgvGailuak.TabIndex = 3;

            // 
            // panelHasiera
            // 
            this.panelHasiera.Controls.Add(this.lblAzalpena);
            this.panelHasiera.Controls.Add(this.lblOngiEtorri);
            this.panelHasiera.Controls.Add(this.panelContenedorTarjetas);
            this.panelHasiera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHasiera.Location = new System.Drawing.Point(0, 0);
            this.panelHasiera.Name = "panelHasiera";
            this.panelHasiera.Size = new System.Drawing.Size(774, 703);
            this.panelHasiera.TabIndex = 4;

            // 
            // lblAzalpena
            // 
            this.lblAzalpena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAzalpena.AutoSize = true;
            this.lblAzalpena.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAzalpena.ForeColor = System.Drawing.Color.FromArgb(120, 130, 140);
            this.lblAzalpena.Location = new System.Drawing.Point(151, 310);
            this.lblAzalpena.Name = "lblAzalpena";
            this.lblAzalpena.Size = new System.Drawing.Size(471, 28);
            this.lblAzalpena.TabIndex = 1;
            this.lblAzalpena.Text = "Erabili ezkerreko menua kudeaketa ataletara joateko.";
            this.lblAzalpena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblOngiEtorri
            // 
            this.lblOngiEtorri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOngiEtorri.AutoSize = true;
            this.lblOngiEtorri.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblOngiEtorri.ForeColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.lblOngiEtorri.Location = new System.Drawing.Point(109, 230);
            this.lblOngiEtorri.Name = "lblOngiEtorri";
            this.lblOngiEtorri.Size = new System.Drawing.Size(555, 62);
            this.lblOngiEtorri.TabIndex = 0;
            this.lblOngiEtorri.Text = "Ongi etorri Inbentariora";
            this.lblOngiEtorri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelContenedorTarjetas
            // 
            this.panelContenedorTarjetas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedorTarjetas.Controls.Add(this.panelCard1);
            this.panelContenedorTarjetas.Controls.Add(this.panelCard2);
            this.panelContenedorTarjetas.Controls.Add(this.panelCard3);
            this.panelContenedorTarjetas.Location = new System.Drawing.Point(7, 380);
            this.panelContenedorTarjetas.Name = "panelContenedorTarjetas";
            this.panelContenedorTarjetas.Size = new System.Drawing.Size(760, 140);
            this.panelContenedorTarjetas.TabIndex = 2;

            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.panelCard1.Controls.Add(this.lblGailuKop);
            this.panelCard1.Controls.Add(this.lblTituloGailuak);
            this.panelCard1.Location = new System.Drawing.Point(0, 0);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(240, 140);
            this.panelCard1.TabIndex = 2;

            // 
            // lblGailuKop
            // 
            this.lblGailuKop.AutoSize = true;
            this.lblGailuKop.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblGailuKop.ForeColor = System.Drawing.Color.White;
            this.lblGailuKop.Location = new System.Drawing.Point(15, 50);
            this.lblGailuKop.Name = "lblGailuKop";
            this.lblGailuKop.Size = new System.Drawing.Size(70, 81);
            this.lblGailuKop.TabIndex = 1;
            this.lblGailuKop.Text = "0";

            // 
            // lblTituloGailuak
            // 
            this.lblTituloGailuak.AutoSize = true;
            this.lblTituloGailuak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloGailuak.ForeColor = System.Drawing.Color.White;
            this.lblTituloGailuak.Location = new System.Drawing.Point(20, 20);
            this.lblTituloGailuak.Name = "lblTituloGailuak";
            this.lblTituloGailuak.Size = new System.Drawing.Size(117, 28);
            this.lblTituloGailuak.TabIndex = 0;
            this.lblTituloGailuak.Text = "💻 Gailuak";

            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.panelCard2.Controls.Add(this.lblErabiltzaileKop);
            this.panelCard2.Controls.Add(this.lblTituloErabiltzaileak);
            this.panelCard2.Location = new System.Drawing.Point(260, 0);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(240, 140);
            this.panelCard2.TabIndex = 3;

            // 
            // lblErabiltzaileKop
            // 
            this.lblErabiltzaileKop.AutoSize = true;
            this.lblErabiltzaileKop.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblErabiltzaileKop.ForeColor = System.Drawing.Color.White;
            this.lblErabiltzaileKop.Location = new System.Drawing.Point(15, 50);
            this.lblErabiltzaileKop.Name = "lblErabiltzaileKop";
            this.lblErabiltzaileKop.Size = new System.Drawing.Size(70, 81);
            this.lblErabiltzaileKop.TabIndex = 1;
            this.lblErabiltzaileKop.Text = "0";

            // 
            // lblTituloErabiltzaileak
            // 
            this.lblTituloErabiltzaileak.AutoSize = true;
            this.lblTituloErabiltzaileak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloErabiltzaileak.ForeColor = System.Drawing.Color.White;
            this.lblTituloErabiltzaileak.Location = new System.Drawing.Point(20, 20);
            this.lblTituloErabiltzaileak.Name = "lblTituloErabiltzaileak";
            this.lblTituloErabiltzaileak.Size = new System.Drawing.Size(174, 28);
            this.lblTituloErabiltzaileak.TabIndex = 0;
            this.lblTituloErabiltzaileak.Text = "👥 Erabiltzaileak";

            // 
            // panelCard3
            // 
            this.panelCard3.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.panelCard3.Controls.Add(this.lblMatxuraKop);
            this.panelCard3.Controls.Add(this.lblTituloMatxurak);
            this.panelCard3.Location = new System.Drawing.Point(520, 0);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Size = new System.Drawing.Size(240, 140);
            this.panelCard3.TabIndex = 4;

            // 
            // lblMatxuraKop
            // 
            this.lblMatxuraKop.AutoSize = true;
            this.lblMatxuraKop.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblMatxuraKop.ForeColor = System.Drawing.Color.White;
            this.lblMatxuraKop.Location = new System.Drawing.Point(15, 50);
            this.lblMatxuraKop.Name = "lblMatxuraKop";
            this.lblMatxuraKop.Size = new System.Drawing.Size(70, 81);
            this.lblMatxuraKop.TabIndex = 1;
            this.lblMatxuraKop.Text = "0";

            // 
            // lblTituloMatxurak
            // 
            this.lblTituloMatxurak.AutoSize = true;
            this.lblTituloMatxurak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloMatxurak.ForeColor = System.Drawing.Color.White;
            this.lblTituloMatxurak.Location = new System.Drawing.Point(20, 20);
            this.lblTituloMatxurak.Name = "lblTituloMatxurak";
            this.lblTituloMatxurak.Size = new System.Drawing.Size(137, 28);
            this.lblTituloMatxurak.TabIndex = 0;
            this.lblTituloMatxurak.Text = "🔧 Matxurak";

            // 
            // panelErabiltzaileak
            // 
            this.panelErabiltzaileak.Controls.Add(this.dgvErabiltzaileak);
            this.panelErabiltzaileak.Controls.Add(this.btnBajaErabiltzailea);
            this.panelErabiltzaileak.Controls.Add(this.btnAldatuErabiltzailea);
            this.panelErabiltzaileak.Controls.Add(this.btnAltaErabiltzailea);
            this.panelErabiltzaileak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelErabiltzaileak.Location = new System.Drawing.Point(0, 0);
            this.panelErabiltzaileak.Name = "panelErabiltzaileak";
            this.panelErabiltzaileak.Size = new System.Drawing.Size(774, 703);
            this.panelErabiltzaileak.TabIndex = 0;

            // 
            // dgvErabiltzaileak
            // 
            this.dgvErabiltzaileak.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvErabiltzaileak.BackgroundColor = System.Drawing.Color.White;
            this.dgvErabiltzaileak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvErabiltzaileak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvErabiltzaileak.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvErabiltzaileak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvErabiltzaileak.ColumnHeadersHeight = 40;
            this.dgvErabiltzaileak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvErabiltzaileak.EnableHeadersVisualStyles = false;
            this.dgvErabiltzaileak.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvErabiltzaileak.Location = new System.Drawing.Point(0, 0);
            this.dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            this.dgvErabiltzaileak.RowHeadersVisible = false;
            this.dgvErabiltzaileak.RowHeadersWidth = 51;
            this.dgvErabiltzaileak.RowTemplate.Height = 35;
            this.dgvErabiltzaileak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErabiltzaileak.Size = new System.Drawing.Size(762, 490);
            this.dgvErabiltzaileak.TabIndex = 0;

            // 
            // btnBajaErabiltzailea
            // 
            this.btnBajaErabiltzailea.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnBajaErabiltzailea.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnBajaErabiltzailea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaErabiltzailea.FlatAppearance.BorderSize = 0;
            this.btnBajaErabiltzailea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaErabiltzailea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBajaErabiltzailea.ForeColor = System.Drawing.Color.White;
            this.btnBajaErabiltzailea.Location = new System.Drawing.Point(366, 520);
            this.btnBajaErabiltzailea.Name = "btnBajaErabiltzailea";
            this.btnBajaErabiltzailea.Size = new System.Drawing.Size(231, 40);
            this.btnBajaErabiltzailea.TabIndex = 0;
            this.btnBajaErabiltzailea.Text = "🗑️ Ezabatu Erabiltzailea";
            this.btnBajaErabiltzailea.UseVisualStyleBackColor = false;
            this.btnBajaErabiltzailea.Click += new System.EventHandler(this.btnBajaErabiltzailea_Click);

            // 
            // btnAldatuErabiltzailea
            // 
            this.btnAldatuErabiltzailea.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnAldatuErabiltzailea.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAldatuErabiltzailea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAldatuErabiltzailea.FlatAppearance.BorderSize = 0;
            this.btnAldatuErabiltzailea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAldatuErabiltzailea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAldatuErabiltzailea.ForeColor = System.Drawing.Color.White;
            this.btnAldatuErabiltzailea.Location = new System.Drawing.Point(206, 520);
            this.btnAldatuErabiltzailea.Name = "btnAldatuErabiltzailea";
            this.btnAldatuErabiltzailea.Size = new System.Drawing.Size(140, 40);
            this.btnAldatuErabiltzailea.TabIndex = 1;
            this.btnAldatuErabiltzailea.Text = "✏️ Aldatu";
            this.btnAldatuErabiltzailea.UseVisualStyleBackColor = false;
            this.btnAldatuErabiltzailea.Click += new System.EventHandler(this.btnAldatuErabiltzailea_Click);

            // 
            // btnAltaErabiltzailea
            // 
            this.btnAltaErabiltzailea.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnAltaErabiltzailea.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAltaErabiltzailea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaErabiltzailea.FlatAppearance.BorderSize = 0;
            this.btnAltaErabiltzailea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaErabiltzailea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAltaErabiltzailea.ForeColor = System.Drawing.Color.White;
            this.btnAltaErabiltzailea.Location = new System.Drawing.Point(40, 520);
            this.btnAltaErabiltzailea.Name = "btnAltaErabiltzailea";
            this.btnAltaErabiltzailea.Size = new System.Drawing.Size(140, 40);
            this.btnAltaErabiltzailea.TabIndex = 2;
            this.btnAltaErabiltzailea.Text = "➕ Alta";
            this.btnAltaErabiltzailea.UseVisualStyleBackColor = false;
            this.btnAltaErabiltzailea.Click += new System.EventHandler(this.btnAltaErabiltzailea_Click);

            // 
            // panelMintegiak
            // 
            this.panelMintegiak.Controls.Add(this.btnEzabatuMintegia);
            this.panelMintegiak.Controls.Add(this.btnMintegiaSortu);
            this.panelMintegiak.Controls.Add(this.dgvMintegiak);
            this.panelMintegiak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMintegiak.Location = new System.Drawing.Point(0, 0);
            this.panelMintegiak.Name = "panelMintegiak";
            this.panelMintegiak.Size = new System.Drawing.Size(774, 703);
            this.panelMintegiak.TabIndex = 1;

            // 
            // btnEzabatuMintegia
            // 
            this.btnEzabatuMintegia.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnEzabatuMintegia.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnEzabatuMintegia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEzabatuMintegia.FlatAppearance.BorderSize = 0;
            this.btnEzabatuMintegia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEzabatuMintegia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEzabatuMintegia.ForeColor = System.Drawing.Color.White;
            this.btnEzabatuMintegia.Location = new System.Drawing.Point(220, 520);
            this.btnEzabatuMintegia.Name = "btnEzabatuMintegia";
            this.btnEzabatuMintegia.Size = new System.Drawing.Size(160, 40);
            this.btnEzabatuMintegia.TabIndex = 2;
            this.btnEzabatuMintegia.Text = "🗑️ Ezabatu";
            this.btnEzabatuMintegia.UseVisualStyleBackColor = false;
            this.btnEzabatuMintegia.Click += new System.EventHandler(this.btnEzabatuMintegia_Click);

            // 
            // btnMintegiaSortu
            // 
            this.btnMintegiaSortu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnMintegiaSortu.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnMintegiaSortu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMintegiaSortu.FlatAppearance.BorderSize = 0;
            this.btnMintegiaSortu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMintegiaSortu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMintegiaSortu.ForeColor = System.Drawing.Color.White;
            this.btnMintegiaSortu.Location = new System.Drawing.Point(40, 520);
            this.btnMintegiaSortu.Name = "btnMintegiaSortu";
            this.btnMintegiaSortu.Size = new System.Drawing.Size(160, 40);
            this.btnMintegiaSortu.TabIndex = 1;
            this.btnMintegiaSortu.Text = "➕ Mintegia Sortu";
            this.btnMintegiaSortu.UseVisualStyleBackColor = false;
            this.btnMintegiaSortu.Click += new System.EventHandler(this.btnMintegiaSortu_Click);

            // 
            // dgvMintegiak
            // 
            this.dgvMintegiak.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvMintegiak.BackgroundColor = System.Drawing.Color.White;
            this.dgvMintegiak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMintegiak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMintegiak.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMintegiak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMintegiak.ColumnHeadersHeight = 40;
            this.dgvMintegiak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMintegiak.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMintegiak.EnableHeadersVisualStyles = false;
            this.dgvMintegiak.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvMintegiak.Location = new System.Drawing.Point(0, 0);
            this.dgvMintegiak.Name = "dgvMintegiak";
            this.dgvMintegiak.RowHeadersVisible = false;
            this.dgvMintegiak.RowHeadersWidth = 51;
            this.dgvMintegiak.RowTemplate.Height = 35;
            this.dgvMintegiak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMintegiak.Size = new System.Drawing.Size(762, 490);
            this.dgvMintegiak.TabIndex = 0;

            // 
            // panelMatxurak
            // 
            this.panelMatxurak.Controls.Add(this.btnKonpondu);
            this.panelMatxurak.Controls.Add(this.dgvMatxurak);
            this.panelMatxurak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatxurak.Location = new System.Drawing.Point(0, 0);
            this.panelMatxurak.Name = "panelMatxurak";
            this.panelMatxurak.Size = new System.Drawing.Size(774, 703);
            this.panelMatxurak.TabIndex = 2;

            // 
            // btnKonpondu
            // 
            this.btnKonpondu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnKonpondu.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnKonpondu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonpondu.FlatAppearance.BorderSize = 0;
            this.btnKonpondu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonpondu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKonpondu.ForeColor = System.Drawing.Color.White;
            this.btnKonpondu.Location = new System.Drawing.Point(40, 520);
            this.btnKonpondu.Name = "btnKonpondu";
            this.btnKonpondu.Size = new System.Drawing.Size(160, 45);
            this.btnKonpondu.TabIndex = 0;
            this.btnKonpondu.Text = "✅ Konpondu";
            this.btnKonpondu.UseVisualStyleBackColor = false;
            this.btnKonpondu.Click += new System.EventHandler(this.btnKonpondu_Click);

            // 
            // dgvMatxurak
            // 
            this.dgvMatxurak.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvMatxurak.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatxurak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatxurak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMatxurak.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            System.Windows.Forms.DataGridViewCellStyle matxuraHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            matxuraHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            matxuraHeaderStyle.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            matxuraHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            matxuraHeaderStyle.ForeColor = System.Drawing.Color.White;
            matxuraHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            matxuraHeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMatxurak.ColumnHeadersDefaultCellStyle = matxuraHeaderStyle;

            this.dgvMatxurak.ColumnHeadersHeight = 40;
            this.dgvMatxurak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            System.Windows.Forms.DataGridViewCellStyle matxuraRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            matxuraRowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            matxuraRowStyle.BackColor = System.Drawing.Color.White;
            matxuraRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            matxuraRowStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            matxuraRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            matxuraRowStyle.SelectionForeColor = System.Drawing.Color.White;
            matxuraRowStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatxurak.DefaultCellStyle = matxuraRowStyle;

            this.dgvMatxurak.EnableHeadersVisualStyles = false;
            this.dgvMatxurak.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvMatxurak.Location = new System.Drawing.Point(0, 0);
            this.dgvMatxurak.Name = "dgvMatxurak";
            this.dgvMatxurak.RowHeadersVisible = false;
            this.dgvMatxurak.RowHeadersWidth = 51;
            this.dgvMatxurak.RowTemplate.Height = 35;
            this.dgvMatxurak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatxurak.Size = new System.Drawing.Size(762, 490);
            this.dgvMatxurak.TabIndex = 1;

            // 
            // FNagusia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FNagusia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izarraitz LHII - Inbentario Kudeaketa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelGailuak.ResumeLayout(false);
            this.panelGailuak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGailuak)).EndInit();
            this.panelHasiera.ResumeLayout(false);
            this.panelHasiera.PerformLayout();
            this.panelContenedorTarjetas.ResumeLayout(false);
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panelCard3.ResumeLayout(false);
            this.panelCard3.PerformLayout();
            this.panelErabiltzaileak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErabiltzaileak)).EndInit();
            this.panelMintegiak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMintegiak)).EndInit();
            this.panelMatxurak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatxurak)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMintegiak;
        private System.Windows.Forms.Button btnErabiltzaileak;
        private System.Windows.Forms.Button btnMatxurak;
        private System.Windows.Forms.Button btnGailuak;
        private System.Windows.Forms.Button btnHasiera;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGailuak;
        private System.Windows.Forms.Panel panelHasiera;
        private System.Windows.Forms.Panel panelMatxurak;
        private System.Windows.Forms.Panel panelErabiltzaileak;
        private System.Windows.Forms.Panel panelMintegiak;
        private System.Windows.Forms.Label lblOngiEtorri;
        private System.Windows.Forms.Label lblAzalpena;
        private System.Windows.Forms.DataGridView dgvGailuak;
        private System.Windows.Forms.Button btnBajaGailua;
        private System.Windows.Forms.Button btnAldatuGailua;
        private System.Windows.Forms.Button btnAltaGailua;
        private System.Windows.Forms.DataGridView dgvMatxurak;
        private System.Windows.Forms.Button btnKonpondu;
        private System.Windows.Forms.Button btnBajaErabiltzailea;
        private System.Windows.Forms.Button btnAldatuErabiltzailea;
        private System.Windows.Forms.Button btnAltaErabiltzailea;
        private System.Windows.Forms.DataGridView dgvErabiltzaileak;
        private System.Windows.Forms.DataGridView dgvMintegiak;
        private System.Windows.Forms.Button btnMintegiaSortu;
        private System.Windows.Forms.Button btnEzabatuMintegia;
        private System.Windows.Forms.Button btnAltaMatxura;
        private System.Windows.Forms.Label lblFiltroGailuak;
        private System.Windows.Forms.ComboBox cmbFiltroGailuak;
        private System.Windows.Forms.Button btnHistoriala;
        private System.Windows.Forms.Label lblFiltroMota;
        private System.Windows.Forms.ComboBox cmbFiltroMota;

        // BERRIA: Bilatzailearen elementuak
        private System.Windows.Forms.Label lblBilatzailea;
        private System.Windows.Forms.TextBox txtBilatzailea;

        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblTituloGailuak;
        private System.Windows.Forms.Label lblGailuKop;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblTituloErabiltzaileak;
        private System.Windows.Forms.Label lblErabiltzaileKop;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblTituloMatxurak;
        private System.Windows.Forms.Label lblMatxuraKop;
        private System.Windows.Forms.Panel panelContenedorTarjetas;
    }
}