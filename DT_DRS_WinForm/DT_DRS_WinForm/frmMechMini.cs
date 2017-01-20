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
    public partial class frmMechMini : Form
    {
        public frmMechMini()
        {
            InitializeComponent();
        }

        private void frmMechMini_Load(object sender, EventArgs e)
        {
            lblMech.Text = this.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form childForm = new frmDigitalRecordSheet();
            childForm.MdiParent = this.ParentForm;
            childForm.Text = lblMech.Text;
            childForm.Show();
        }
    }
}
