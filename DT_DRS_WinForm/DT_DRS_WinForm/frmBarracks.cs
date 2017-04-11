using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiteDB;

namespace BT_DRS_WinForm
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
                        lsPilots.Items.Add(Mech.Name + " (" + Mech.Callsign + ")");
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
                if (txtName.Text == "")
                {
                    MessageBox.Show("Enter Pilot's Name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtCallSign.Text == "")
                {
                    MessageBox.Show("Enter Pilot's Callsign", "Invalid Callsign", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                    Pilots.EnsureIndex(x => x.Callsign);
                    int PilotIDTemp;
                    DS_BTDRSMechPilots PilotSearch = Pilots.FindOne(Query.EQ("Callsign", txtCallSign.Text));
                    if (PilotSearch != null)
                    {
                        PilotIDTemp = PilotSearch.PilotID;
                        Pilots.Delete(Query.EQ("Callsign", PilotSearch.Callsign));
                        PilotSearch.PilotID = PilotIDTemp;
                        PilotSearch.Name = txtName.Text;
                        PilotSearch.Callsign = txtCallSign.Text;
                        PilotSearch.Affiliation = comboBox2.Text;
                        PilotSearch.Rank = txtRank.Text;
                        PilotSearch.Description = txtDescription.Text;
                        PilotSearch.PilotingSkill = int.Parse(nmPS.Value.ToString());
                        PilotSearch.GunnerySkill = int.Parse(nmGS.Value.ToString());
                        PilotSearch.HitPoints = int.Parse(nmHP.Value.ToString());
                        PilotSearch.DamageTaken = int.Parse(nmDT.Value.ToString());
                        PilotSearch.Kills = int.Parse(nmKS.Value.ToString());
                        Pilots.Insert(PilotSearch);
                    }
                    else
                    {
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
                    }
                    LoadPilotList();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtCallSign.Text = "";
            txtDescription.Text = "";
            txtRank.Text = "";
            nmGS.Value = 4;
            nmPS.Value = 5;
            nmKS.Value = 0;
            nmHP.Value = 5;
            nmDT.Value = 0;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                    if (MessageBox.Show("Do you really want to delete ALL MechPilots??? (this action cannot be undone!)", "Deleting MechPilots", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Pilots.Delete(Query.All());
                    }
                }
                LoadPilotList();
                ClearFields();
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
                if (lsPilots.SelectedItems.Count > 0)
                {
                    string[] MDL = new string[3];
                    MDL = lsPilots.SelectedItem.ToString().Split('(');
                    if (MDL.Length > 1)
                    {
                        txtName.Text = MDL[0];
                        txtCallSign.Text = MDL[1].Substring(0, MDL[1].Length - 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsPilots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCallSign_TextChanged(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                Pilots.EnsureIndex(x => x.Callsign);

                DS_BTDRSMechPilots Pilot = Pilots.FindOne(Query.EQ("Callsign", txtCallSign.Text));
                if (Pilot != null)
                {
                    txtName.Text = Pilot.Name.ToString();
                    nmPS.Value = Pilot.PilotingSkill;
                    nmGS.Value = Pilot.GunnerySkill;
                    nmHP.Value = Pilot.HitPoints;
                    nmKS.Value = Pilot.Kills;
                    nmDT.Value = Pilot.DamageTaken;
                    txtDescription.Text = Pilot.Description;
                    txtRank.Text = Pilot.Rank;
                    comboBox2.Text = Pilot.Affiliation;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                Pilots.EnsureIndex(x => x.Callsign);

                DS_BTDRSMechPilots Pilot = Pilots.FindOne(Query.EQ("Callsign", txtCallSign.Text));
                if (Pilot != null)
                {
                    if (MessageBox.Show("Do you really want to delete this MechPilot??? (this action cannot be undone!)", "Deleting MechPilot", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Pilots.Delete(Query.EQ("Callsign", Pilot.Callsign));
                    }
                }
            }
            LoadPilotList();
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadPilotList();
        }
    }
}
