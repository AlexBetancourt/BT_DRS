using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiteDB;

namespace DT_DRS_WinForm
{
    public partial class frmBarracks : Form
    {
        public frmBarracks()
        {
            InitializeComponent();
        }

        private void frmBarracks_Load(object sender, EventArgs e)
        {
            LoadPilotList();
        }

        private void LoadPilotList()
        {
            try
            {
                lsPilots.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                    Pilots.EnsureIndex(x => x.PilotID);

                    foreach (DS_BTDRSMechPilots Mech in Pilots.FindAll())
                    {
                        lsPilots.Items.Add(Mech.Name + " ''" + Mech.Callsign + "''");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                    Pilots.EnsureIndex(x => x.PilotID);

                    DS_BTDRSMechPilots Pilot = new DS_BTDRSMechPilots
                    {
                        PilotID = Pilots.Count() + 1,
                        Name = txtName.Text,
                        Callsign = txtCallSign.Text,
                        Affiliation = comboBox2.Text,
                        Rank = txtRank.Text,
                        Description = txtDescription.Text,
                        PilotingSkill = int.Parse(nmPS.Value.ToString()),
                        GunnerySkill = int.Parse(nmGS.Value.ToString()),
                        HitPoints = int.Parse(nmHP.Value.ToString()),
                        DamageTaken = int.Parse(nmDT.Value.ToString()),
                        Kills = int.Parse(nmKS.Value.ToString())
                    };
                    Pilots.Insert(Pilot);
                    LoadPilotList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                    Pilots.Delete(Query.All());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void lsPilots_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string[] MDL = new string[3];
                MDL = lsPilots.SelectedItem.ToString().Split('"');
                if (MDL.Length > 1)
                {
                    txtName.Text = MDL[0] + " " + MDL[2];
                    txtCallSign.Text = MDL[1];
                    //TODO:
                        //SEARCH AND GET MECHWARRIOR DATA
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
