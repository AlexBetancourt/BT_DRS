using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT_DRS_WinForm
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
            this.Size = new System.Drawing.Size(picTables.Image.Size.Width + 50,picTables.Image.Size.Height + 70);
        }
    }
}
