namespace INBENT_VISUAL.diseinuak
{
    partial class FHistoriala
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
            this.lblTituloa = new System.Windows.Forms.Label();
            this.lblBajaArrazoia = new System.Windows.Forms.Label();
            this.dgvHistoriala = new System.Windows.Forms.DataGridView();
            this.btnItxi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriala)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTituloa
            // 
            this.lblTituloa.AutoSize = true;
            this.lblTituloa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloa.Location = new System.Drawing.Point(20, 15);
            this.lblTituloa.Name = "lblTituloa";
            this.lblTituloa.Size = new System.Drawing.Size(262, 32);
            this.lblTituloa.TabIndex = 0;
            this.lblTituloa.Text = "📚 Gailuaren Historiala";

            // 
            // lblBajaArrazoia
            // 
            this.lblBajaArrazoia.AutoSize = true;
            this.lblBajaArrazoia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBajaArrazoia.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblBajaArrazoia.Location = new System.Drawing.Point(22, 50);
            this.lblBajaArrazoia.MaximumSize = new System.Drawing.Size(730, 0); // 🌟 HAU DA GAKOA: 730px-ra iristean, testua hurrengo lerroan jarriko da
            this.lblBajaArrazoia.Name = "lblBajaArrazoia";
            this.lblBajaArrazoia.Size = new System.Drawing.Size(0, 25);
            this.lblBajaArrazoia.TabIndex = 3;
            this.lblBajaArrazoia.Visible = false;

            // 
            // dgvHistoriala
            // 
            this.dgvHistoriala.AllowUserToAddRows = false;
            this.dgvHistoriala.AllowUserToDeleteRows = false;
            this.dgvHistoriala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoriala.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistoriala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistoriala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistoriala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvHistoriala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoriala.ColumnHeadersHeight = 40;
            this.dgvHistoriala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistoriala.EnableHeadersVisualStyles = false;
            this.dgvHistoriala.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);

            this.dgvHistoriala.Location = new System.Drawing.Point(26, 110);
            this.dgvHistoriala.Name = "dgvHistoriala";
            this.dgvHistoriala.ReadOnly = true;
            this.dgvHistoriala.RowHeadersVisible = false;
            this.dgvHistoriala.RowHeadersWidth = 51;

            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoriala.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoriala.RowTemplate.Height = 50;
            this.dgvHistoriala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriala.Size = new System.Drawing.Size(730, 260);
            this.dgvHistoriala.TabIndex = 1;

            // 
            // btnItxi
            // 
            this.btnItxi.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnItxi.FlatAppearance.BorderSize = 0;
            this.btnItxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItxi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnItxi.ForeColor = System.Drawing.Color.White;
            this.btnItxi.Location = new System.Drawing.Point(316, 390);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(150, 40);
            this.btnItxi.TabIndex = 2;
            this.btnItxi.Text = "🚪 Itxi";
            this.btnItxi.UseVisualStyleBackColor = false;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);

            // 
            // FHistoriala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.dgvHistoriala);
            this.Controls.Add(this.lblBajaArrazoia);
            this.Controls.Add(this.lblTituloa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FHistoriala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historiala";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloa;
        private System.Windows.Forms.Label lblBajaArrazoia;
        private System.Windows.Forms.DataGridView dgvHistoriala;
        private System.Windows.Forms.Button btnItxi;
    }
}