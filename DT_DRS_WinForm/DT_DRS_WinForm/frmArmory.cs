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
    public partial class frmArmory : Form
    {
        public frmArmory()
        {
            InitializeComponent();
        }

        private void frmArmory_Load(object sender, EventArgs e)
        {
            LoadWnEList();
            LoadAmmoList();
        }

        private void LoadWnEList()
        {
            try
            {
                lbWnE.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                    Weapons.EnsureIndex(x => x.WeaponID);

                    foreach (DS_BTDRSWeapons Weapon in Weapons.FindAll())
                    {
                        lbWnE.Items.Add(Weapon.Name);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAmmoList()
        {
            try
            {
                lbAmmo.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                    Ammos.EnsureIndex(x => x.AmmoID);

                    foreach (DS_BTDRSAmmo Ammo in Ammos.FindAll())
                    {
                        lbAmmo.Items.Add(Ammo.AmmoName + " (" + Ammo.Ammo + " rounds)");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbWnE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbWnE.SelectedItems.Count > 0)
                {
                    string[] MDL = new string[3];
                    MDL = lbWnE.SelectedItem.ToString().Split('|');
                    if (MDL.Length > 0)
                    {
                        txtName.Text = MDL[0];
                        //txtCallSign.Text = MDL[1].Substring(0, MDL[1].Length - 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                Weapons.EnsureIndex(x => x.Name);

                DS_BTDRSWeapons Weapon = Weapons.FindOne(Query.EQ("Name", txtName.Text));
                if (Weapon != null)
                {
                    txtName.Text = Weapon.Name.ToString();
                    txtHeat.Text= Weapon.Heat.ToString();
                    txtDamage.Text = Weapon.Damage;
                    txtMinimum.Text = Weapon.Minimum;
                    txtShort.Text = Weapon.Short;
                    txtMedium.Text = Weapon.Medium;
                    txtLong.Text = Weapon.Long.ToString();
                    txtTons.Text = Weapon.Tons.ToString();
                    txtCrits.Text = Weapon.Crits.ToString();
                    txtWeaponType.Text = Weapon.WeaponType;
                    txtAmmo.Text = Weapon.Ammo;

                }

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
    }
}
