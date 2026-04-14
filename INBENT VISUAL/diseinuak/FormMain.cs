using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INBENT_VISUAL.diseinuak
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FormMain
            // 
            ClientSize = new Size(1048, 660);
            Name = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
