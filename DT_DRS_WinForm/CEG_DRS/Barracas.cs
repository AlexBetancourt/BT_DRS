using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEG_DRS
{
    public partial class frmCharCreation : Form
    {
        public frmCharCreation()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 10)
                lblPV.Text = "Puntos de Vida: 5";
            else
            {
                decimal PV = 0;
                PV = Math.Floor(numericUpDown1.Value / 10) + 5;
                lblPV.Text = "Puntos de Vida: " + PV;
            }
        }
        Random random1 = new Random();
        private void d100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int randomNumber1 = random1.Next(1, 101);
            tirarDadosToolStripMenuItem.ShowDropDown();
            d100ToolStripMenuItem.DropDownItems.Insert(0, d100ToolStripMenuItem.DropDownItems.Add("Roll 1d100: " + randomNumber1.ToString()));//  ToolStripDropDown();
            d100ToolStripMenuItem.ShowDropDown();

        }
        int PuntosAsignar=0;
        private void d100ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int randomNumber1 = random1.Next(1, 101);
            int randomNumber2 = random1.Next(1, 101);
            int randomNumber3 = random1.Next(1, 101);
            int randomNumber4 = random1.Next(1, 101);
            int randomNumber5 = random1.Next(1, 101);
            tirarDadosToolStripMenuItem.ShowDropDown();
            d100ToolStripMenuItem1.DropDownItems.Insert(0, d100ToolStripMenuItem1.DropDownItems.Add("Roll 5d100:  " + randomNumber1.ToString() + " + " + randomNumber2.ToString() + " + " + randomNumber3.ToString() + " + " + randomNumber4.ToString() + " + " + randomNumber5.ToString() + " = " + (randomNumber1 + randomNumber2+ randomNumber3 + randomNumber4 + randomNumber5).ToString()));//  ToolStripDropDown();
            d100ToolStripMenuItem1.ShowDropDown();
            PuntosAsignar = randomNumber1 + randomNumber2 + randomNumber3 + randomNumber4 + randomNumber5;
        }
    }
}
