using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DT_DRS_WinForm
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        private void frmTables_Load(object sender, EventArgs e)
        {
            picTables.Image = Image.FromFile(Application.StartupPath + @"\Images\" + this.Text + ".png");
            this.Size = picTables.Image.Size;
        }
    }
}
