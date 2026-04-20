using System.Drawing;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnMintegiak = new Button();
            btnErabiltzaileak = new Button();
            btnMatxurak = new Button();
            btnGailuak = new Button();
            btnHasiera = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panelHasiera = new Panel();
            lblAzalpena = new Label();
            lblOngiEtorri = new Label();
            panelContenedorTarjetas = new Panel();
            panelCard1 = new Panel();
            lblGailuKop = new Label();
            lblTituloGailuak = new Label();
            panelCard2 = new Panel();
            lblErabiltzaileKop = new Label();
            lblTituloErabiltzaileak = new Label();
            panelCard3 = new Panel();
            lblMatxuraKop = new Label();
            lblTituloMatxurak = new Label();
            panelErabiltzaileak = new Panel();
            dgvErabiltzaileak = new DataGridView();
            btnBajaErabiltzailea = new Button();
            btnAldatuErabiltzailea = new Button();
            btnAltaErabiltzailea = new Button();
            panelMintegiak = new Panel();
            btnEzabatuMintegia = new Button();
            btnMintegiaSortu = new Button();
            dgvMintegiak = new DataGridView();
            panelMatxurak = new Panel();
            btnKonpondu = new Button();
            dgvMatxurak = new DataGridView();
            panelGailuak = new Panel();
            lblFiltroMota = new Label();
            cmbFiltroMota = new ComboBox();
            lblFiltroGailuak = new Label();
            cmbFiltroGailuak = new ComboBox();
            btnHistoriala = new Button();
            btnAltaMatxura = new Button();
            btnBajaGailua = new Button();
            btnAldatuGailua = new Button();
            btnAltaGailua = new Button();
            dgvGailuak = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelHasiera.SuspendLayout();
            panelContenedorTarjetas.SuspendLayout();
            panelCard1.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard3.SuspendLayout();
            panelErabiltzaileak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).BeginInit();
            panelMintegiak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMintegiak).BeginInit();
            panelMatxurak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatxurak).BeginInit();
            panelGailuak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGailuak).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 47, 61);
            panel1.Controls.Add(btnMintegiak);
            panel1.Controls.Add(btnErabiltzaileak);
            panel1.Controls.Add(btnMatxurak);
            panel1.Controls.Add(btnGailuak);
            panel1.Controls.Add(btnHasiera);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 768);
            panel1.TabIndex = 0;
            // 
            // btnMintegiak
            // 
            btnMintegiak.Cursor = Cursors.Hand;
            btnMintegiak.Dock = DockStyle.Top;
            btnMintegiak.FlatAppearance.BorderSize = 0;
            btnMintegiak.FlatStyle = FlatStyle.Flat;
            btnMintegiak.Font = new Font("Segoe UI", 12F);
            btnMintegiak.ForeColor = Color.White;
            btnMintegiak.Location = new Point(0, 210);
            btnMintegiak.Name = "btnMintegiak";
            btnMintegiak.Padding = new Padding(20, 0, 0, 0);
            btnMintegiak.Size = new Size(250, 38);
            btnMintegiak.TabIndex = 0;
            btnMintegiak.Text = "📁  Mintegiak Kudeatu";
            btnMintegiak.TextAlign = ContentAlignment.MiddleLeft;
            btnMintegiak.Click += btnMintegiak_Click;
            // 
            // btnErabiltzaileak
            // 
            btnErabiltzaileak.Cursor = Cursors.Hand;
            btnErabiltzaileak.Dock = DockStyle.Top;
            btnErabiltzaileak.FlatAppearance.BorderSize = 0;
            btnErabiltzaileak.FlatStyle = FlatStyle.Flat;
            btnErabiltzaileak.Font = new Font("Segoe UI", 12F);
            btnErabiltzaileak.ForeColor = Color.White;
            btnErabiltzaileak.Location = new Point(0, 162);
            btnErabiltzaileak.Name = "btnErabiltzaileak";
            btnErabiltzaileak.Padding = new Padding(20, 0, 0, 0);
            btnErabiltzaileak.Size = new Size(250, 48);
            btnErabiltzaileak.TabIndex = 1;
            btnErabiltzaileak.Text = "👥  Erabiltzaileak Kudeatu";
            btnErabiltzaileak.TextAlign = ContentAlignment.MiddleLeft;
            btnErabiltzaileak.Click += btnErabiltzaileak_Click;
            // 
            // btnMatxurak
            // 
            btnMatxurak.Cursor = Cursors.Hand;
            btnMatxurak.Dock = DockStyle.Top;
            btnMatxurak.FlatAppearance.BorderSize = 0;
            btnMatxurak.FlatStyle = FlatStyle.Flat;
            btnMatxurak.Font = new Font("Segoe UI", 12F);
            btnMatxurak.ForeColor = Color.White;
            btnMatxurak.Location = new Point(0, 108);
            btnMatxurak.Name = "btnMatxurak";
            btnMatxurak.Padding = new Padding(20, 0, 0, 0);
            btnMatxurak.Size = new Size(250, 54);
            btnMatxurak.TabIndex = 2;
            btnMatxurak.Text = "🔧  Matxurak";
            btnMatxurak.TextAlign = ContentAlignment.MiddleLeft;
            btnMatxurak.Click += btnMatxurak_Click;
            // 
            // btnGailuak
            // 
            btnGailuak.Cursor = Cursors.Hand;
            btnGailuak.Dock = DockStyle.Top;
            btnGailuak.FlatAppearance.BorderSize = 0;
            btnGailuak.FlatStyle = FlatStyle.Flat;
            btnGailuak.Font = new Font("Segoe UI", 12F);
            btnGailuak.ForeColor = Color.White;
            btnGailuak.Location = new Point(0, 60);
            btnGailuak.Name = "btnGailuak";
            btnGailuak.Padding = new Padding(20, 0, 0, 0);
            btnGailuak.Size = new Size(250, 48);
            btnGailuak.TabIndex = 3;
            btnGailuak.Text = "💻  Gailuak";
            btnGailuak.TextAlign = ContentAlignment.MiddleLeft;
            btnGailuak.Click += btnGailuak_Click;
            // 
            // btnHasiera
            // 
            btnHasiera.Cursor = Cursors.Hand;
            btnHasiera.Dock = DockStyle.Top;
            btnHasiera.FlatAppearance.BorderSize = 0;
            btnHasiera.FlatStyle = FlatStyle.Flat;
            btnHasiera.Font = new Font("Segoe UI", 12F);
            btnHasiera.ForeColor = Color.White;
            btnHasiera.Location = new Point(0, 0);
            btnHasiera.Name = "btnHasiera";
            btnHasiera.Padding = new Padding(20, 0, 0, 0);
            btnHasiera.Size = new Size(250, 60);
            btnHasiera.TabIndex = 4;
            btnHasiera.Text = "🏠  Hasiera";
            btnHasiera.TextAlign = ContentAlignment.MiddleLeft;
            btnHasiera.Click += btnHasiera_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 65);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(100, 100, 100);
            label2.Location = new Point(520, 22);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 0;
            label2.Text = "Erabiltzailea / Rola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(340, 37);
            label1.TabIndex = 1;
            label1.Text = "Izarraitz LHII Inbentarioa";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 247, 250);
            panel3.Controls.Add(panelGailuak);
            panel3.Controls.Add(panelHasiera);
            panel3.Controls.Add(panelErabiltzaileak);
            panel3.Controls.Add(panelMintegiak);
            panel3.Controls.Add(panelMatxurak);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 703);
            panel3.TabIndex = 0;
            // 
            // panelHasiera
            // 
            panelHasiera.Controls.Add(lblAzalpena);
            panelHasiera.Controls.Add(lblOngiEtorri);
            panelHasiera.Controls.Add(panelContenedorTarjetas);
            panelHasiera.Dock = DockStyle.Fill;
            panelHasiera.Location = new Point(0, 0);
            panelHasiera.Name = "panelHasiera";
            panelHasiera.Size = new Size(774, 703);
            panelHasiera.TabIndex = 4;
            // 
            // lblAzalpena
            // 
            lblAzalpena.Anchor = AnchorStyles.None;
            lblAzalpena.AutoSize = true;
            lblAzalpena.Font = new Font("Segoe UI", 12F);
            lblAzalpena.ForeColor = Color.FromArgb(120, 130, 140);
            lblAzalpena.Location = new Point(151, 310);
            lblAzalpena.Name = "lblAzalpena";
            lblAzalpena.Size = new Size(471, 28);
            lblAzalpena.TabIndex = 1;
            lblAzalpena.Text = "Erabili ezkerreko menua kudeaketa ataletara joateko.";
            lblAzalpena.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOngiEtorri
            // 
            lblOngiEtorri.Anchor = AnchorStyles.None;
            lblOngiEtorri.AutoSize = true;
            lblOngiEtorri.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblOngiEtorri.ForeColor = Color.FromArgb(33, 47, 61);
            lblOngiEtorri.Location = new Point(109, 230);
            lblOngiEtorri.Name = "lblOngiEtorri";
            lblOngiEtorri.Size = new Size(555, 62);
            lblOngiEtorri.TabIndex = 0;
            lblOngiEtorri.Text = "Ongi etorri Inbentariora";
            lblOngiEtorri.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenedorTarjetas
            // 
            panelContenedorTarjetas.Anchor = AnchorStyles.None;
            panelContenedorTarjetas.Controls.Add(panelCard1);
            panelContenedorTarjetas.Controls.Add(panelCard2);
            panelContenedorTarjetas.Controls.Add(panelCard3);
            panelContenedorTarjetas.Location = new Point(7, 380);
            panelContenedorTarjetas.Name = "panelContenedorTarjetas";
            panelContenedorTarjetas.Size = new Size(760, 140);
            panelContenedorTarjetas.TabIndex = 2;
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.FromArgb(52, 152, 219);
            panelCard1.Controls.Add(lblGailuKop);
            panelCard1.Controls.Add(lblTituloGailuak);
            panelCard1.Location = new Point(0, 0);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(240, 140);
            panelCard1.TabIndex = 2;
            // 
            // lblGailuKop
            // 
            lblGailuKop.AutoSize = true;
            lblGailuKop.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblGailuKop.ForeColor = Color.White;
            lblGailuKop.Location = new Point(15, 50);
            lblGailuKop.Name = "lblGailuKop";
            lblGailuKop.Size = new Size(70, 81);
            lblGailuKop.TabIndex = 1;
            lblGailuKop.Text = "0";
            // 
            // lblTituloGailuak
            // 
            lblTituloGailuak.AutoSize = true;
            lblTituloGailuak.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloGailuak.ForeColor = Color.White;
            lblTituloGailuak.Location = new Point(20, 20);
            lblTituloGailuak.Name = "lblTituloGailuak";
            lblTituloGailuak.Size = new Size(117, 28);
            lblTituloGailuak.TabIndex = 0;
            lblTituloGailuak.Text = "💻 Gailuak";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.FromArgb(46, 204, 113);
            panelCard2.Controls.Add(lblErabiltzaileKop);
            panelCard2.Controls.Add(lblTituloErabiltzaileak);
            panelCard2.Location = new Point(260, 0);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(240, 140);
            panelCard2.TabIndex = 3;
            // 
            // lblErabiltzaileKop
            // 
            lblErabiltzaileKop.AutoSize = true;
            lblErabiltzaileKop.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblErabiltzaileKop.ForeColor = Color.White;
            lblErabiltzaileKop.Location = new Point(15, 50);
            lblErabiltzaileKop.Name = "lblErabiltzaileKop";
            lblErabiltzaileKop.Size = new Size(70, 81);
            lblErabiltzaileKop.TabIndex = 1;
            lblErabiltzaileKop.Text = "0";
            // 
            // lblTituloErabiltzaileak
            // 
            lblTituloErabiltzaileak.AutoSize = true;
            lblTituloErabiltzaileak.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloErabiltzaileak.ForeColor = Color.White;
            lblTituloErabiltzaileak.Location = new Point(20, 20);
            lblTituloErabiltzaileak.Name = "lblTituloErabiltzaileak";
            lblTituloErabiltzaileak.Size = new Size(174, 28);
            lblTituloErabiltzaileak.TabIndex = 0;
            lblTituloErabiltzaileak.Text = "👥 Erabiltzaileak";
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.FromArgb(231, 76, 60);
            panelCard3.Controls.Add(lblMatxuraKop);
            panelCard3.Controls.Add(lblTituloMatxurak);
            panelCard3.Location = new Point(520, 0);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(240, 140);
            panelCard3.TabIndex = 4;
            // 
            // lblMatxuraKop
            // 
            lblMatxuraKop.AutoSize = true;
            lblMatxuraKop.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblMatxuraKop.ForeColor = Color.White;
            lblMatxuraKop.Location = new Point(15, 50);
            lblMatxuraKop.Name = "lblMatxuraKop";
            lblMatxuraKop.Size = new Size(70, 81);
            lblMatxuraKop.TabIndex = 1;
            lblMatxuraKop.Text = "0";
            // 
            // lblTituloMatxurak
            // 
            lblTituloMatxurak.AutoSize = true;
            lblTituloMatxurak.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloMatxurak.ForeColor = Color.White;
            lblTituloMatxurak.Location = new Point(20, 20);
            lblTituloMatxurak.Name = "lblTituloMatxurak";
            lblTituloMatxurak.Size = new Size(137, 28);
            lblTituloMatxurak.TabIndex = 0;
            lblTituloMatxurak.Text = "🔧 Matxurak";
            // 
            // panelErabiltzaileak
            // 
            panelErabiltzaileak.Controls.Add(dgvErabiltzaileak);
            panelErabiltzaileak.Controls.Add(btnBajaErabiltzailea);
            panelErabiltzaileak.Controls.Add(btnAldatuErabiltzailea);
            panelErabiltzaileak.Controls.Add(btnAltaErabiltzailea);
            panelErabiltzaileak.Dock = DockStyle.Fill;
            panelErabiltzaileak.Location = new Point(0, 0);
            panelErabiltzaileak.Name = "panelErabiltzaileak";
            panelErabiltzaileak.Size = new Size(774, 703);
            panelErabiltzaileak.TabIndex = 0;
            // 
            // dgvErabiltzaileak
            // 
            dgvErabiltzaileak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvErabiltzaileak.BackgroundColor = Color.White;
            dgvErabiltzaileak.BorderStyle = BorderStyle.None;
            dgvErabiltzaileak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvErabiltzaileak.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvErabiltzaileak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvErabiltzaileak.ColumnHeadersHeight = 40;
            dgvErabiltzaileak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvErabiltzaileak.EnableHeadersVisualStyles = false;
            dgvErabiltzaileak.GridColor = Color.FromArgb(224, 224, 224);
            dgvErabiltzaileak.Location = new Point(0, 0);
            dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            dgvErabiltzaileak.RowHeadersVisible = false;
            dgvErabiltzaileak.RowHeadersWidth = 51;
            dgvErabiltzaileak.RowTemplate.Height = 35;
            dgvErabiltzaileak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvErabiltzaileak.Size = new Size(762, 490);
            dgvErabiltzaileak.TabIndex = 0;
            // 
            // btnBajaErabiltzailea
            // 
            btnBajaErabiltzailea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBajaErabiltzailea.BackColor = Color.FromArgb(231, 76, 60);
            btnBajaErabiltzailea.Cursor = Cursors.Hand;
            btnBajaErabiltzailea.FlatAppearance.BorderSize = 0;
            btnBajaErabiltzailea.FlatStyle = FlatStyle.Flat;
            btnBajaErabiltzailea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBajaErabiltzailea.ForeColor = Color.White;
            btnBajaErabiltzailea.Location = new Point(366, 520);
            btnBajaErabiltzailea.Name = "btnBajaErabiltzailea";
            btnBajaErabiltzailea.Size = new Size(231, 40);
            btnBajaErabiltzailea.TabIndex = 0;
            btnBajaErabiltzailea.Text = "🗑️ Ezabatu Erabiltzailea";
            btnBajaErabiltzailea.UseVisualStyleBackColor = false;
            btnBajaErabiltzailea.Click += btnBajaErabiltzailea_Click;
            // 
            // btnAldatuErabiltzailea
            // 
            btnAldatuErabiltzailea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAldatuErabiltzailea.BackColor = Color.FromArgb(52, 152, 219);
            btnAldatuErabiltzailea.Cursor = Cursors.Hand;
            btnAldatuErabiltzailea.FlatAppearance.BorderSize = 0;
            btnAldatuErabiltzailea.FlatStyle = FlatStyle.Flat;
            btnAldatuErabiltzailea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAldatuErabiltzailea.ForeColor = Color.White;
            btnAldatuErabiltzailea.Location = new Point(206, 520);
            btnAldatuErabiltzailea.Name = "btnAldatuErabiltzailea";
            btnAldatuErabiltzailea.Size = new Size(140, 40);
            btnAldatuErabiltzailea.TabIndex = 1;
            btnAldatuErabiltzailea.Text = "✏️ Aldatu";
            btnAldatuErabiltzailea.UseVisualStyleBackColor = false;
            btnAldatuErabiltzailea.Click += btnAldatuErabiltzailea_Click;
            // 
            // btnAltaErabiltzailea
            // 
            btnAltaErabiltzailea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAltaErabiltzailea.BackColor = Color.FromArgb(46, 204, 113);
            btnAltaErabiltzailea.Cursor = Cursors.Hand;
            btnAltaErabiltzailea.FlatAppearance.BorderSize = 0;
            btnAltaErabiltzailea.FlatStyle = FlatStyle.Flat;
            btnAltaErabiltzailea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAltaErabiltzailea.ForeColor = Color.White;
            btnAltaErabiltzailea.Location = new Point(40, 520);
            btnAltaErabiltzailea.Name = "btnAltaErabiltzailea";
            btnAltaErabiltzailea.Size = new Size(140, 40);
            btnAltaErabiltzailea.TabIndex = 2;
            btnAltaErabiltzailea.Text = "➕ Alta";
            btnAltaErabiltzailea.UseVisualStyleBackColor = false;
            btnAltaErabiltzailea.Click += btnAltaErabiltzailea_Click;
            // 
            // panelMintegiak
            // 
            panelMintegiak.Controls.Add(btnEzabatuMintegia);
            panelMintegiak.Controls.Add(btnMintegiaSortu);
            panelMintegiak.Controls.Add(dgvMintegiak);
            panelMintegiak.Dock = DockStyle.Fill;
            panelMintegiak.Location = new Point(0, 0);
            panelMintegiak.Name = "panelMintegiak";
            panelMintegiak.Size = new Size(774, 703);
            panelMintegiak.TabIndex = 1;
            // 
            // btnEzabatuMintegia
            // 
            btnEzabatuMintegia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEzabatuMintegia.BackColor = Color.FromArgb(231, 76, 60);
            btnEzabatuMintegia.Cursor = Cursors.Hand;
            btnEzabatuMintegia.FlatAppearance.BorderSize = 0;
            btnEzabatuMintegia.FlatStyle = FlatStyle.Flat;
            btnEzabatuMintegia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEzabatuMintegia.ForeColor = Color.White;
            btnEzabatuMintegia.Location = new Point(220, 520);
            btnEzabatuMintegia.Name = "btnEzabatuMintegia";
            btnEzabatuMintegia.Size = new Size(160, 40);
            btnEzabatuMintegia.TabIndex = 2;
            btnEzabatuMintegia.Text = "🗑️ Ezabatu";
            btnEzabatuMintegia.UseVisualStyleBackColor = false;
            btnEzabatuMintegia.Click += btnEzabatuMintegia_Click;
            // 
            // btnMintegiaSortu
            // 
            btnMintegiaSortu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMintegiaSortu.BackColor = Color.FromArgb(46, 204, 113);
            btnMintegiaSortu.Cursor = Cursors.Hand;
            btnMintegiaSortu.FlatAppearance.BorderSize = 0;
            btnMintegiaSortu.FlatStyle = FlatStyle.Flat;
            btnMintegiaSortu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMintegiaSortu.ForeColor = Color.White;
            btnMintegiaSortu.Location = new Point(40, 520);
            btnMintegiaSortu.Name = "btnMintegiaSortu";
            btnMintegiaSortu.Size = new Size(160, 40);
            btnMintegiaSortu.TabIndex = 1;
            btnMintegiaSortu.Text = "➕ Mintegia Sortu";
            btnMintegiaSortu.UseVisualStyleBackColor = false;
            btnMintegiaSortu.Click += btnMintegiaSortu_Click;
            // 
            // dgvMintegiak
            // 
            dgvMintegiak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMintegiak.BackgroundColor = Color.White;
            dgvMintegiak.BorderStyle = BorderStyle.None;
            dgvMintegiak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMintegiak.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvMintegiak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMintegiak.ColumnHeadersHeight = 40;
            dgvMintegiak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMintegiak.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMintegiak.EnableHeadersVisualStyles = false;
            dgvMintegiak.GridColor = Color.FromArgb(224, 224, 224);
            dgvMintegiak.Location = new Point(0, 0);
            dgvMintegiak.Name = "dgvMintegiak";
            dgvMintegiak.RowHeadersVisible = false;
            dgvMintegiak.RowHeadersWidth = 51;
            dgvMintegiak.RowTemplate.Height = 35;
            dgvMintegiak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMintegiak.Size = new Size(762, 490);
            dgvMintegiak.TabIndex = 0;
            // 
            // panelMatxurak
            // 
            panelMatxurak.Controls.Add(btnKonpondu);
            panelMatxurak.Controls.Add(dgvMatxurak);
            panelMatxurak.Dock = DockStyle.Fill;
            panelMatxurak.Location = new Point(0, 0);
            panelMatxurak.Name = "panelMatxurak";
            panelMatxurak.Size = new Size(774, 703);
            panelMatxurak.TabIndex = 2;
            // 
            // btnKonpondu
            // 
            btnKonpondu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnKonpondu.BackColor = Color.FromArgb(46, 204, 113);
            btnKonpondu.Cursor = Cursors.Hand;
            btnKonpondu.FlatAppearance.BorderSize = 0;
            btnKonpondu.FlatStyle = FlatStyle.Flat;
            btnKonpondu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKonpondu.ForeColor = Color.White;
            btnKonpondu.Location = new Point(40, 520);
            btnKonpondu.Name = "btnKonpondu";
            btnKonpondu.Size = new Size(160, 45);
            btnKonpondu.TabIndex = 0;
            btnKonpondu.Text = "✅ Konpondu";
            btnKonpondu.UseVisualStyleBackColor = false;
            btnKonpondu.Click += btnKonpondu_Click;
            // 
            // dgvMatxurak
            // 
            dgvMatxurak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMatxurak.BackgroundColor = Color.White;
            dgvMatxurak.BorderStyle = BorderStyle.None;
            dgvMatxurak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMatxurak.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMatxurak.ColumnHeadersHeight = 40;
            dgvMatxurak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMatxurak.EnableHeadersVisualStyles = false;
            dgvMatxurak.GridColor = Color.FromArgb(224, 224, 224);
            dgvMatxurak.Location = new Point(0, 0);
            dgvMatxurak.Name = "dgvMatxurak";
            dgvMatxurak.RowHeadersVisible = false;
            dgvMatxurak.RowHeadersWidth = 51;
            dgvMatxurak.RowTemplate.Height = 35;
            dgvMatxurak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatxurak.Size = new Size(762, 490);
            dgvMatxurak.TabIndex = 1;
            // 
            // panelGailuak
            // 
            panelGailuak.Controls.Add(lblFiltroMota);
            panelGailuak.Controls.Add(cmbFiltroMota);
            panelGailuak.Controls.Add(lblFiltroGailuak);
            panelGailuak.Controls.Add(cmbFiltroGailuak);
            panelGailuak.Controls.Add(btnHistoriala);
            panelGailuak.Controls.Add(btnAltaMatxura);
            panelGailuak.Controls.Add(btnBajaGailua);
            panelGailuak.Controls.Add(btnAldatuGailua);
            panelGailuak.Controls.Add(btnAltaGailua);
            panelGailuak.Controls.Add(dgvGailuak);
            panelGailuak.Dock = DockStyle.Fill;
            panelGailuak.Location = new Point(0, 0);
            panelGailuak.Name = "panelGailuak";
            panelGailuak.Size = new Size(774, 703);
            panelGailuak.TabIndex = 3;
            // 
            // lblFiltroMota
            // 
            lblFiltroMota.AutoSize = true;
            lblFiltroMota.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFiltroMota.ForeColor = Color.FromArgb(100, 100, 100);
            lblFiltroMota.Location = new Point(0, 17);
            lblFiltroMota.Name = "lblFiltroMota";
            lblFiltroMota.Size = new Size(65, 23);
            lblFiltroMota.TabIndex = 8;
            lblFiltroMota.Text = "Gailua:";
            // 
            // cmbFiltroMota
            // 
            cmbFiltroMota.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroMota.Font = new Font("Segoe UI", 10F);
            cmbFiltroMota.FormattingEnabled = true;
            cmbFiltroMota.Items.AddRange(new object[] { "Denak", "Ordenagailua", "Inprimagailua" });
            cmbFiltroMota.Location = new Point(65, 14);
            cmbFiltroMota.Name = "cmbFiltroMota";
            cmbFiltroMota.Size = new Size(140, 31);
            cmbFiltroMota.TabIndex = 9;
            cmbFiltroMota.SelectedIndexChanged += FiltratuGailuak;
            // 
            // lblFiltroGailuak
            // 
            lblFiltroGailuak.AutoSize = true;
            lblFiltroGailuak.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFiltroGailuak.ForeColor = Color.FromArgb(100, 100, 100);
            lblFiltroGailuak.Location = new Point(220, 17);
            lblFiltroGailuak.Name = "lblFiltroGailuak";
            lblFiltroGailuak.Size = new Size(70, 23);
            lblFiltroGailuak.TabIndex = 5;
            lblFiltroGailuak.Text = "Egoera:";
            // 
            // cmbFiltroGailuak
            // 
            cmbFiltroGailuak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroGailuak.Font = new Font("Segoe UI", 10F);
            cmbFiltroGailuak.FormattingEnabled = true;
            cmbFiltroGailuak.Items.AddRange(new object[] { "Denak", "Aktiboak", "Matxuratuak", "Bajan" });
            cmbFiltroGailuak.Location = new Point(290, 14);
            cmbFiltroGailuak.Name = "cmbFiltroGailuak";
            cmbFiltroGailuak.Size = new Size(140, 31);
            cmbFiltroGailuak.TabIndex = 6;
            cmbFiltroGailuak.SelectedIndexChanged += FiltratuGailuak;
            // 
            // btnHistoriala
            // 
            btnHistoriala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHistoriala.BackColor = Color.FromArgb(52, 152, 219);
            btnHistoriala.Cursor = Cursors.Hand;
            btnHistoriala.FlatAppearance.BorderSize = 0;
            btnHistoriala.FlatStyle = FlatStyle.Flat;
            btnHistoriala.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHistoriala.ForeColor = Color.White;
            btnHistoriala.Location = new Point(588, 12);
            btnHistoriala.Name = "btnHistoriala";
            btnHistoriala.Size = new Size(180, 35);
            btnHistoriala.TabIndex = 7;
            btnHistoriala.Text = "📚 Ikusi Historiala";
            btnHistoriala.UseVisualStyleBackColor = false;
            btnHistoriala.Click += btnHistoriala_Click;
            // 
            // btnAltaMatxura
            // 
            btnAltaMatxura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAltaMatxura.BackColor = Color.FromArgb(243, 156, 18);
            btnAltaMatxura.Cursor = Cursors.Hand;
            btnAltaMatxura.FlatAppearance.BorderSize = 0;
            btnAltaMatxura.FlatStyle = FlatStyle.Flat;
            btnAltaMatxura.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAltaMatxura.ForeColor = Color.White;
            btnAltaMatxura.Location = new Point(530, 520);
            btnAltaMatxura.Name = "btnAltaMatxura";
            btnAltaMatxura.Size = new Size(180, 40);
            btnAltaMatxura.TabIndex = 4;
            btnAltaMatxura.Text = "🔧 Matxura Berria";
            btnAltaMatxura.UseVisualStyleBackColor = false;
            btnAltaMatxura.Click += btnAltaMatxura_Click;
            // 
            // btnBajaGailua
            // 
            btnBajaGailua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBajaGailua.BackColor = Color.FromArgb(231, 76, 60);
            btnBajaGailua.Cursor = Cursors.Hand;
            btnBajaGailua.FlatAppearance.BorderSize = 0;
            btnBajaGailua.FlatStyle = FlatStyle.Flat;
            btnBajaGailua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBajaGailua.ForeColor = Color.White;
            btnBajaGailua.Location = new Point(366, 520);
            btnBajaGailua.Name = "btnBajaGailua";
            btnBajaGailua.Size = new Size(140, 40);
            btnBajaGailua.TabIndex = 0;
            btnBajaGailua.Text = "🗑️ Baja Eman";
            btnBajaGailua.UseVisualStyleBackColor = false;
            btnBajaGailua.Click += btnBajaGailua_Click;
            // 
            // btnAldatuGailua
            // 
            btnAldatuGailua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAldatuGailua.BackColor = Color.FromArgb(52, 152, 219);
            btnAldatuGailua.Cursor = Cursors.Hand;
            btnAldatuGailua.FlatAppearance.BorderSize = 0;
            btnAldatuGailua.FlatStyle = FlatStyle.Flat;
            btnAldatuGailua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAldatuGailua.ForeColor = Color.White;
            btnAldatuGailua.Location = new Point(200, 520);
            btnAldatuGailua.Name = "btnAldatuGailua";
            btnAldatuGailua.Size = new Size(140, 40);
            btnAldatuGailua.TabIndex = 1;
            btnAldatuGailua.Text = "✏️ Aldatu";
            btnAldatuGailua.UseVisualStyleBackColor = false;
            btnAldatuGailua.Click += btnAldatuGailua_Click;
            // 
            // btnAltaGailua
            // 
            btnAltaGailua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAltaGailua.BackColor = Color.FromArgb(46, 204, 113);
            btnAltaGailua.Cursor = Cursors.Hand;
            btnAltaGailua.FlatAppearance.BorderSize = 0;
            btnAltaGailua.FlatStyle = FlatStyle.Flat;
            btnAltaGailua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAltaGailua.ForeColor = Color.White;
            btnAltaGailua.Location = new Point(40, 520);
            btnAltaGailua.Name = "btnAltaGailua";
            btnAltaGailua.Size = new Size(140, 40);
            btnAltaGailua.TabIndex = 2;
            btnAltaGailua.Text = "➕ Alta Eman";
            btnAltaGailua.UseVisualStyleBackColor = false;
            btnAltaGailua.Click += btnAltaGailua_Click;
            // 
            // dgvGailuak
            // 
            dgvGailuak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGailuak.BackgroundColor = Color.White;
            dgvGailuak.BorderStyle = BorderStyle.None;
            dgvGailuak.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGailuak.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvGailuak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGailuak.ColumnHeadersHeight = 40;
            dgvGailuak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGailuak.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGailuak.EnableHeadersVisualStyles = false;
            dgvGailuak.GridColor = Color.FromArgb(224, 224, 224);
            dgvGailuak.Location = new Point(6, 60);
            dgvGailuak.Name = "dgvGailuak";
            dgvGailuak.RowHeadersVisible = false;
            dgvGailuak.RowHeadersWidth = 51;
            dgvGailuak.RowTemplate.Height = 35;
            dgvGailuak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGailuak.Size = new Size(768, 430);
            dgvGailuak.TabIndex = 3;
            // 
            // FHasiera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FHasiera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izarraitz LHII - Inbentario Kudeaketa";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panelHasiera.ResumeLayout(false);
            panelHasiera.PerformLayout();
            panelContenedorTarjetas.ResumeLayout(false);
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            panelErabiltzaileak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).EndInit();
            panelMintegiak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMintegiak).EndInit();
            panelMatxurak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatxurak).EndInit();
            panelGailuak.ResumeLayout(false);
            panelGailuak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGailuak).EndInit();
            ResumeLayout(false);

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

        // NUEVAS VARIABLES DEL DASHBOARD
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblTituloGailuak;
        private System.Windows.Forms.Label lblGailuKop;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblTituloErabiltzaileak;
        private System.Windows.Forms.Label lblErabiltzaileKop;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblTituloMatxurak;
        private System.Windows.Forms.Label lblMatxuraKop;
        private Panel panelContenedorTarjetas;
    }
}