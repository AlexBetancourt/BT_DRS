using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiteDB;
using System.Threading;

namespace BT_DRS_WinForm
{
    public partial class frmMechBay : Form
    {
        public frmMechBay()
        {
            InitializeComponent();
        }

        private void frmMechBay_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");
                    Mechs.EnsureIndex(x => x.MechID);

                    foreach (DS_BTDRSMechs Mech in Mechs.FindAll())
                    {
                        lbMechs.Items.Add(Mech.Name + "(" + Mech.Model + ")");


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdAddTeam1_Click(object sender, EventArgs e)
        {
            if (lbMechs.SelectedItems.Count > 0)
            {
                lbTeam1.Items.Add(lbMechs.SelectedItem);
            }
        }

        private void cmdAddTeam2_Click(object sender, EventArgs e)
        {
            if (lbMechs.SelectedItems.Count > 0)
            {
                lbTeam2.Items.Add(lbMechs.SelectedItem);

            }
        }

        private void cmdRemoveTeam1_Click(object sender, EventArgs e)
        {
            if (lbTeam1.SelectedItems.Count > 0)
            {
                lbTeam1.Items.Remove(lbTeam1.SelectedItem);

            }
        }

        private void cmdRemoveTeam2_Click(object sender, EventArgs e)
        {
            if (lbTeam2.SelectedItems.Count > 0)
            {
                lbTeam2.Items.Remove(lbTeam2.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 V Betty - STARTUP Reactor Online.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(2300);
                }
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 V Betty - STARTUP Sensors Online.wav");
                for (int i = 0; i < length; i++)
                {
                    player2.Play();
                    Thread.Sleep(2000);
                }
                System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 V Betty - STARTUP Weapons Systems Online.wav");
                for (int i = 0; i < length; i++)
                {
                    player3.Play();
                    Thread.Sleep(2350);
                }
                System.Media.SoundPlayer player4 = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 V Betty - STARTUP All Functioning Systems Nominal.wav");
                for (int i = 0; i < length; i++)
                {
                    player4.Play();
                    Thread.Sleep(2000);
                }
                for (int i = 0; i < lbTeam1.Items.Count; i++)
                {
                    Form childForm = new frmDigitalRecordSheet();
                    childForm.MdiParent = this.ParentForm;
                    childForm.Text = "RED ARMY -" + lbTeam1.Items[i].ToString();
                    childForm.Show();
                }

                for (int i = 0; i < lbTeam2.Items.Count; i++)
                {
                    Form childForm = new frmDigitalRecordSheet();
                    childForm.MdiParent = this.ParentForm;
                    childForm.Text = "BLUE ARMY -" + lbTeam2.Items[i].ToString();
                    childForm.Show();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

