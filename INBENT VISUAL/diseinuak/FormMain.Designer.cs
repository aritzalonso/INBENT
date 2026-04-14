namespace INBENT_VISUAL
{
    partial class FormMain : System.Windows.Forms.Form
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnKudeaketa = new System.Windows.Forms.Button();
            this.btnMatxurak = new System.Windows.Forms.Button();
            this.btnInbentarioa = new System.Windows.Forms.Button();
            this.btnHasiera = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(40, 40, 50);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(180, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnKudeaketa
            // 
            this.btnKudeaketa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKudeaketa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKudeaketa.FlatAppearance.BorderSize = 0;
            this.btnKudeaketa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKudeaketa.ForeColor = System.Drawing.Color.White;
            this.btnKudeaketa.Location = new System.Drawing.Point(0, 180);
            this.btnKudeaketa.Name = "btnKudeaketa";
            this.btnKudeaketa.Size = new System.Drawing.Size(180, 60);
            this.btnKudeaketa.TabIndex = 3;
            this.btnKudeaketa.Text = "Kudeaketa";
            this.btnKudeaketa.UseVisualStyleBackColor = true;
            // 
            // btnMatxurak
            // 
            this.btnMatxurak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatxurak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatxurak.FlatAppearance.BorderSize = 0;
            this.btnMatxurak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMatxurak.ForeColor = System.Drawing.Color.White;
            this.btnMatxurak.Location = new System.Drawing.Point(0, 120);
            this.btnMatxurak.Name = "btnMatxurak";
            this.btnMatxurak.Size = new System.Drawing.Size(180, 60);
            this.btnMatxurak.TabIndex = 2;
            this.btnMatxurak.Text = "Matxurak";
            this.btnMatxurak.UseVisualStyleBackColor = true;
            // 
            // btnInbentarioa
            // 
            this.btnInbentarioa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbentarioa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbentarioa.FlatAppearance.BorderSize = 0;
            this.btnInbentarioa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnInbentarioa.ForeColor = System.Drawing.Color.White;
            this.btnInbentarioa.Location = new System.Drawing.Point(0, 60);
            this.btnInbentarioa.Name = "btnInbentarioa";
            this.btnInbentarioa.Size = new System.Drawing.Size(180, 60);
            this.btnInbentarioa.TabIndex = 1;
            this.btnInbentarioa.Text = "Inbentarioa";
            this.btnInbentarioa.UseVisualStyleBackColor = true;
            // 
            // btnHasiera
            // 
            this.btnHasiera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasiera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasiera.FlatAppearance.BorderSize = 0;
            this.btnHasiera.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHasiera.ForeColor = System.Drawing.Color.White;
            this.btnHasiera.Location = new System.Drawing.Point(0, 0);
            this.btnHasiera.Name = "btnHasiera";
            this.btnHasiera.Size = new System.Drawing.Size(180, 60);
            this.btnHasiera.TabIndex = 0;
            this.btnHasiera.Text = "Hasiera";
            this.btnHasiera.UseVisualStyleBackColor = true;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(180, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(820, 700);
            this.pnlContenedor.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormMain";
            this.Text = "INBENT - Main";
            this.pnlSidebar.Controls.Add(this.btnKudeaketa);
            this.pnlSidebar.Controls.Add(this.btnMatxurak);
            this.pnlSidebar.Controls.Add(this.btnInbentarioa);
            this.pnlSidebar.Controls.Add(this.btnHasiera);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnHasiera;
        private System.Windows.Forms.Button btnInbentarioa;
        private System.Windows.Forms.Button btnMatxurak;
        private System.Windows.Forms.Button btnKudeaketa;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}