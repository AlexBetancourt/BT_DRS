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
            int randomNumber1 = random1.Next(1, 7);
            tirarDadosToolStripMenuItem.ShowDropDown();
            d100ToolStripMenuItem.DropDownItems.Insert(0, d100ToolStripMenuItem.DropDownItems.Add("Lanza 1d6: " + randomNumber1.ToString()));//  ToolStripDropDown();
            d100ToolStripMenuItem.ShowDropDown();

        }

        int PuntosAsignar = 0;
        private void d100ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int randomNumber1 = random1.Next(2, 13);
            int randomNumber2 = random1.Next(2, 13);
            int randomNumber3 = random1.Next(2, 13);
            int randomNumber4 = random1.Next(2, 13);
            int randomNumber5 = random1.Next(2, 13);
            int randomNumber6 = random1.Next(2, 13);
            tirarDadosToolStripMenuItem.ShowDropDown();
            d100ToolStripMenuItem1.DropDownItems.Insert(0, d100ToolStripMenuItem1.DropDownItems.Add("Lanza 2d6 x 6:  " + randomNumber1.ToString() + " + " + randomNumber2.ToString() + " + " + randomNumber3.ToString() + " + " + randomNumber4.ToString() + " + " + randomNumber5.ToString() + " + " + randomNumber6.ToString() + " = " + (randomNumber1 + randomNumber2 + randomNumber3 + randomNumber4 + randomNumber5 + randomNumber6).ToString()));//  ToolStripDropDown();
            d100ToolStripMenuItem1.ShowDropDown();
            PuntosAsignar = randomNumber1 + randomNumber2 + randomNumber3 + randomNumber4 + randomNumber5 + randomNumber6;

            numericUpDown1.Value = NivelTexto(numericUpDown1, lblDestreza, randomNumber1);
            numericUpDown2.Value = NivelTexto(numericUpDown2, lblCoordinacion, randomNumber2);
            numericUpDown3.Value = NivelTexto(numericUpDown3, lblFuerza, randomNumber3);
            numericUpDown4.Value = NivelTexto(numericUpDown4, lblIntelecto, randomNumber4);
            numericUpDown5.Value = NivelTexto(numericUpDown5, lblConsciencia, randomNumber5);
            numericUpDown6.Value = NivelTexto(numericUpDown6, lblVoluntad, randomNumber6);

        }

        private void frmCharCreation_Load(object sender, EventArgs e)
        {

        }

        private int NivelTexto(NumericUpDown ControlNumerico, Label ControlEtiqueta, int Nivel)
        {
            string Descripcion = "";
            int Valor = 1;
            switch (Nivel)
            {
                case 2:

                    Descripcion = "Debil";
                    Valor = 1;
                    break;
                case 3:
                    Descripcion = "Pobre";
                    Valor = 2;
                    break;
                case 4:
                    Descripcion = "Medio";
                    Valor = 3;
                    break;
                case 5:
                    Descripcion = "Aceptable";
                    Valor = 4;
                    break;
                case 6:
                    Descripcion = "Aceptable";
                    Valor = 4;
                    break;
                case 7:
                    Descripcion = "Bueno";
                    Valor = 5;
                    break;
                case 8:
                    Descripcion = "Bueno";
                    Valor = 5;
                    break;
                case 9:
                    Descripcion = "Grandioso";
                    Valor = 6;
                    break;
                case 10:
                    Descripcion = "Grandioso";
                    Valor = 6;
                    break;
                case 11:
                    Descripcion = "Increíble";
                    Valor = 7;
                    break;
                case 12:
                    Descripcion = "Asombroso";
                    Valor = 8;
                    break;
                default:
                    Descripcion = "";
                    break;
            }

            ControlEtiqueta.Text = Descripcion;


            return Valor;

        }

    }
}
