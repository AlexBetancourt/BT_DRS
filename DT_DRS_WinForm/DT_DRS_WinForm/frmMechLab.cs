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
    public partial class frmMechLab : Form
    {
        public frmMechLab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chklstH.Items.RemoveAt(chklstH.SelectedIndex);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFieldsMech(txtModel.Text, txtName.Text))
                {
                    using (var DataBase = new LiteDatabase(@"DRS.db"))
                    {
                        var Mechs = DataBase.GetCollection<DS_BTDRSMechs>("Mechs");


                        DS_BTDRSMechs MechVal = Mechs.FindOne(Query.EQ("Model", txtModel.Text));

                        if (MechVal == null)
                        {
                            var Mech = new DS_BTDRSMechs
                            {

                                MechID = int.Parse(Mechs.Count().ToString()) + 1,
                                Name = txtName.Text,
                                Model = txtModel.Text,
                                Walk = int.Parse(txtWalk.Text),
                                Run = int.Parse(txtRun.Text),
                                Jump = int.Parse(txtJump.Text),
                                Heatsinks = int.Parse(txtHeatSinks.Text),
                                Tons = int.Parse(nmTons.Value.ToString())
                            };
                            Mechs.Insert(Mech);

                            var MechLocations = DataBase.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                            var Mechlocation = new DS_BTDRSMechLocation
                            {
                                MechLocationID = MechLocations.Count() + 1,
                                MechID = Mech.MechID,
                                LocationID = 1,
                                HitPoints = int.Parse(txtH.Text),

                            };
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 2;
                            Mechlocation.HitPoints = int.Parse(txtCT.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 3;
                            Mechlocation.HitPoints = int.Parse(txtLT.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 4;
                            Mechlocation.HitPoints = int.Parse(txtRT.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 5;
                            Mechlocation.HitPoints = int.Parse(txtLA.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 6;
                            Mechlocation.HitPoints = int.Parse(txtRA.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 7;
                            Mechlocation.HitPoints = int.Parse(txtLL.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 8;
                            Mechlocation.HitPoints = int.Parse(txtRL.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 9;
                            Mechlocation.HitPoints = int.Parse(txtCTR.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 10;
                            Mechlocation.HitPoints = int.Parse(txtLTR.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 11;
                            Mechlocation.HitPoints = int.Parse(txtRTR.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 12;
                            Mechlocation.HitPoints = int.Parse(txtIH.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 13;
                            Mechlocation.HitPoints = int.Parse(txtICT.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 14;
                            Mechlocation.HitPoints = int.Parse(txtILT.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 15;
                            Mechlocation.HitPoints = int.Parse(txtIRT.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 16;
                            Mechlocation.HitPoints = int.Parse(txtILA.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 17;
                            Mechlocation.HitPoints = int.Parse(txtIRA.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 18;
                            Mechlocation.HitPoints = int.Parse(txtILL.Text);
                            MechLocations.Insert(Mechlocation);

                            Mechlocation.MechLocationID = MechLocations.Count() + 1;
                            Mechlocation.MechID = Mech.MechID;
                            Mechlocation.LocationID = 19;
                            Mechlocation.HitPoints = int.Parse(txtIRL.Text);
                            MechLocations.Insert(Mechlocation);

                            MessageBox.Show("Mech Count: " + Mechs.Count().ToString());
                            MessageBox.Show("Mech Locations Count: " + MechLocations.Count().ToString());
                        }
                        else
                        {
                            if (MessageBox.Show("That Model already exists Overwrite???", "Existing Mech", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                cmdUpdate_Click(null, null);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Please Enter the Mech's Variant and Name");

                LoadMechList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private bool ValidateFieldsMech(string Code, string Name)
        {
            if (Name != "" && Code != "")
                return true;
            else
                return false;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");
                    Mechs.EnsureIndex(x => x.Model);

                    DS_BTDRSMechs Mech = Mechs.FindOne(Query.EQ("Model", txtModel.Text));
                    if (Mech != null)
                    {
                        txtWalk.Text = Mech.Walk.ToString();
                        txtRun.Text = Mech.Run.ToString();
                        txtJump.Text = Mech.Jump.ToString();
                        txtHeatSinks.Text = Mech.Heatsinks.ToString();
                        nmTons.Value = decimal.Parse(Mech.Tons.ToString());
                        txtName.Text = Mech.Name.ToString();

                        var MechLocations = db.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                        MechLocations.EnsureIndex(x => x.MechID);

                        var MechLocationss = MechLocations.Find(Query.EQ("MechID", Mech.MechID));
                        foreach (DS_BTDRSMechLocation MechLoc in MechLocationss)
                        {
                            switch (MechLoc.LocationID)
                            {
                                case 1:
                                    txtH.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 2:
                                    txtCT.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 3:
                                    txtLT.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 4:
                                    txtRT.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 5:
                                    txtLA.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 6:
                                    txtRA.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 7:
                                    txtLL.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 8:
                                    txtRL.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 9:
                                    txtCTR.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 10:
                                    txtLTR.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 11:
                                    txtRTR.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 12:
                                    txtIH.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 13:
                                    txtICT.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 14:
                                    txtILT.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 15:
                                    txtIRT.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 16:
                                    txtILA.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 17:
                                    txtIRA.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 18:
                                    txtILL.Text = MechLoc.HitPoints.ToString();
                                    break;
                                case 19:
                                    txtIRL.Text = MechLoc.HitPoints.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtLA_TextChanged(object sender, EventArgs e)
        {
            txtRA.Text = txtLA.Text;
        }

        private void txtLT_TextChanged(object sender, EventArgs e)
        {
            txtRT.Text = txtLT.Text;
        }

        private void txtLL_TextChanged(object sender, EventArgs e)
        {
            txtRL.Text = txtLL.Text;
        }

        private void txtILA_TextChanged(object sender, EventArgs e)
        {
            txtIRA.Text = txtILA.Text;
        }

        private void txtILT_TextChanged(object sender, EventArgs e)
        {
            txtIRT.Text = txtILT.Text;
        }

        private void txtILL_TextChanged(object sender, EventArgs e)
        {
            txtIRL.Text = txtILL.Text;
        }

        private void txtLTR_TextChanged(object sender, EventArgs e)
        {
            txtRTR.Text = txtLTR.Text;
        }

        private void frmMechLab_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");
                    Mechs.EnsureIndex(x => x.MechID);

                    foreach (DS_BTDRSMechs Mech in Mechs.FindAll())
                    {
                        lbMechs.Items.Add(Mech.Name + " (" + Mech.Model + ")");

                    }

                    var Weapons = db.GetCollection<DS_BTDRSWeapons>("Weapons");
                    Weapons.EnsureIndex(x => x.WeaponID);

                    foreach (DS_BTDRSWeapons Weapon in Weapons.FindAll())
                    {
                        chklstComponentsH.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsH.Sorted = true;
                        chklstComponentsCT.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsCT.Sorted = true;
                        chklstComponentsLT.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsLT.Sorted = true;
                        chklstComponentsRT.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsRT.Sorted = true;
                        chklstComponentsLA.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsLA.Sorted = true;
                        chklstComponentsRA.Items.Add(Weapon.Name + "(Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsRA.Sorted = true;
                        chklstComponentsLL.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsLL.Sorted = true;
                        chklstComponentsRL.Items.Add(Weapon.Name + " (Weapon " + Weapon.Crits + " Crits)");
                        chklstComponentsRL.Sorted = true;
                    }

                    var Ammos = db.GetCollection<DS_BTDRSAmmo>("Ammos");
                    Ammos.EnsureIndex(x => x.AmmoID);
                    {
                        foreach (DS_BTDRSAmmo Ammo in Ammos.FindAll())
                        {
                            chklstComponentsH.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsH.Sorted = true;
                            chklstComponentsCT.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsCT.Sorted = true;
                            chklstComponentsLT.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsLT.Sorted = true;
                            chklstComponentsRT.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsRT.Sorted = true;
                            chklstComponentsLA.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsLA.Sorted = true;
                            chklstComponentsRA.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsRA.Sorted = true;
                            chklstComponentsLL.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsLL.Sorted = true;
                            chklstComponentsRL.Items.Add(Ammo.AmmoName + " (Ammo " + Ammo.Ammo + " Shots)");
                            chklstComponentsRL.Sorted = true;
                        }
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadMechList()
        {
            try
            {
                lbMechs.Items.Clear();
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");
                    Mechs.EnsureIndex(x => x.MechID);

                    foreach (DS_BTDRSMechs Mech in Mechs.FindAll())
                    {
                        lbMechs.Items.Add(Mech.Name + " (" + Mech.Model + ")");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");
                    Mechs.EnsureIndex(x => x.Model);
                    int MechIDTemp;

                    DS_BTDRSMechs Mech = Mechs.FindOne(Query.EQ("Model", txtModel.Text));

                    if (Mech != null)
                    {
                        MechIDTemp = Mech.MechID;
                        Mechs.Delete(Query.EQ("Model", Mech.Model));
                        Mech.MechID = MechIDTemp;
                        Mech.Walk = int.Parse(txtWalk.Text);
                        Mech.Run = int.Parse(txtRun.Text);
                        Mech.Jump = int.Parse(txtJump.Text);
                        Mech.Heatsinks = int.Parse(txtHeatSinks.Text);
                        Mech.Tons = int.Parse(nmTons.Value.ToString());
                        Mech.Name = txtName.Text;
                        Mech.Model = txtModel.Text;
                        Mechs.Insert(Mech);

                        var MechLocations = db.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                        MechLocations.EnsureIndex(x => x.MechID);

                        MechLocations.Delete(Query.EQ("MechID", Mech.MechID));

                        var Mechlocation = new DS_BTDRSMechLocation
                        {
                            MechLocationID = MechLocations.Count() + 1,
                            MechID = Mech.MechID,
                            LocationID = 1,
                            HitPoints = int.Parse(txtH.Text),

                        };
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 2;
                        Mechlocation.HitPoints = int.Parse(txtCT.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 3;
                        Mechlocation.HitPoints = int.Parse(txtLT.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 4;
                        Mechlocation.HitPoints = int.Parse(txtRT.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 5;
                        Mechlocation.HitPoints = int.Parse(txtLA.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 6;
                        Mechlocation.HitPoints = int.Parse(txtRA.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 7;
                        Mechlocation.HitPoints = int.Parse(txtLL.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 8;
                        Mechlocation.HitPoints = int.Parse(txtRL.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 9;
                        Mechlocation.HitPoints = int.Parse(txtCTR.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 10;
                        Mechlocation.HitPoints = int.Parse(txtLTR.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 11;
                        Mechlocation.HitPoints = int.Parse(txtRTR.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 12;
                        Mechlocation.HitPoints = int.Parse(txtIH.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 13;
                        Mechlocation.HitPoints = int.Parse(txtICT.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 14;
                        Mechlocation.HitPoints = int.Parse(txtILT.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 15;
                        Mechlocation.HitPoints = int.Parse(txtIRT.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 16;
                        Mechlocation.HitPoints = int.Parse(txtILA.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 17;
                        Mechlocation.HitPoints = int.Parse(txtIRA.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 18;
                        Mechlocation.HitPoints = int.Parse(txtILL.Text);
                        MechLocations.Insert(Mechlocation);

                        Mechlocation.MechLocationID = MechLocations.Count() + 1;
                        Mechlocation.MechID = Mech.MechID;
                        Mechlocation.LocationID = 19;
                        Mechlocation.HitPoints = int.Parse(txtIRL.Text);
                        MechLocations.Insert(Mechlocation);


                        //-----------------------------------------------
                        //TODO: Insert code to save internal components
                        //-----------------------------------------------



                        //-----------------------------------------------





                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void lbMechs_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string[] MDL = new string[2];
                MDL = lbMechs.SelectedItem.ToString().Split('(');
                if (MDL.Length > 1)
                {
                    txtModel.Text = MDL[1].Substring(0, MDL[1].Length - 1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"DRS.db"))
            {
                var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");
                Mechs.EnsureIndex(x => x.MechID);

                string[] MDL = new string[2];
                MDL = lbMechs.SelectedItem.ToString().Split('(');
                if (MDL.Length > 1)
                {
                    Mechs.Delete(Query.EQ("Model", MDL[1].Substring(0, MDL[1].Length - 1)));
                }
                LoadMechList();
                //lbMechs.Items.RemoveAt(lbMechs.SelectedValue);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            LoadMechList();
        }

        private void txtWalk_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double i = Int32.Parse(txtWalk.Text);
                i = Math.Ceiling(i * 1.5);
                txtRun.Text = i.ToString();
            }
            catch (FormatException)
            {

            }
        }

        private void nmTons_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var MechConfigs = db.GetCollection<DS_BTDRSMechConfigs>("MechConfigs");
                    //var Mechs = db.GetCollection<DS_BTDRSMechs>("Mechs");

                    MechConfigs.EnsureIndex(x => x.Tons);
                    //                    MessageBox.Show(MechConfigs.Count().ToString());

                    //DS_BTDRSMechConfigs MechConfig = MechConfigs.FindOne(Query.EQ("Tons",txtTons.Text));
                    //DS_BTDRSMechs Mech = Mechs.FindOne(Query.EQ("Model", txtModel.Text));



                    foreach (DS_BTDRSMechConfigs MechConfig in MechConfigs.FindAll())
                    {
                        if (int.Parse(nmTons.Value.ToString()) == int.Parse(MechConfig.Tons.ToString()))
                        {
                            txtIH.Text = MechConfig.HeadHP.ToString();
                            txtICT.Text = MechConfig.CTorsoHP.ToString();
                            txtILT.Text = txtIRT.Text = MechConfig.LRTorsoHP.ToString();
                            txtILA.Text = txtIRA.Text = MechConfig.LRArmsHP.ToString();
                            txtILL.Text = txtIRL.Text = MechConfig.LRLegsHP.ToString();
                            return;
                        }

                    }




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private int indexOfItemUnderMouseToDrop;
        private int indexOfItemUnderMouseToDrag;
        private Point screenOffset;
        private DateTime eventTime;


        #region Head Internal Components
        private void chklstComponentsH_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void chklstComponentsH_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void GiveInfoAboutDragDropEvent(DateTime eventTime, string dragDropEventName, object originalSender, System.Windows.Forms.DragEventArgs e)
        {

        }

        private void chklstComponentsH_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsH.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsH.Items.Count)  // check that an string is selected
            {

                chklstComponentsH.DoDragDrop(chklstComponentsH.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsH_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }


        }




        private void chklstHead_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstH.Items.Count)
                {

                    chklstH.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstH.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstH.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void chklstHead_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;



        }

        private void chklstHead_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstH.IndexFromPoint(chklstH.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstH.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstH.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstH.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstHead_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void chklstHead_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }


        }
        #endregion

        #region Center Torso Internal Components
        private void chklstComponentsCT_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstComponentsCT_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsCT.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsCT.Items.Count)  // check that an string is selected
            {

                chklstComponentsCT.DoDragDrop(chklstComponentsCT.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsCT_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstCT_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstCT_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstCT.IndexFromPoint(chklstCT.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstCT.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstCT.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstCT.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstCT_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstCT_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstCT.Items.Count)
                {
                    chklstCT.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstCT.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstCT.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentCT_Click(object sender, EventArgs e)
        {
            chklstCT.Items.RemoveAt(chklstCT.SelectedIndex);
        }


        #endregion

        #region Left Torso Internal Components

        private void chklstComponentsLT_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstComponentsLT_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsLT.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsLT.Items.Count)  // check that an string is selected
            {

                chklstComponentsLT.DoDragDrop(chklstComponentsLT.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsLT_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstLT_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstLT_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstLT.IndexFromPoint(chklstLT.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstLT.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstLT.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstLT.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstLT_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstLT_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstLT.Items.Count)
                {
                    chklstLT.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstLT.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstLT.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentLT_Click(object sender, EventArgs e)
        {
            chklstLT.Items.RemoveAt(chklstLT.SelectedIndex);
        }
        #endregion

        #region Right Torso Internal Components
        private void chklstComponentsRT_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {

        }

        private void chklstComponentsRT_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsRT.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsRT.Items.Count)  // check that an string is selected
            {

                chklstComponentsRT.DoDragDrop(chklstComponentsRT.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsRT_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstRT_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstRT_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstRT.IndexFromPoint(chklstRT.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstRT.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstRT.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstRT.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstRT_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstRT_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstRT.Items.Count)
                {
                    chklstRT.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstRT.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstRT.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentRT_Click(object sender, EventArgs e)
        {
            chklstRT.Items.RemoveAt(chklstRT.SelectedIndex);
        }
        #endregion

        #region Left Arm Internal Components
        private void chklstComponentsLA_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstComponentsLA_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsLA.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsLA.Items.Count)  // check that an string is selected
            {

                chklstComponentsLA.DoDragDrop(chklstComponentsLA.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsLA_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstLA_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstLA_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstLA.IndexFromPoint(chklstLA.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstLA.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstLA.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstLA.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstLA_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstLA_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstLA.Items.Count)
                {
                    chklstLA.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstLA.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstLA.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentLA_Click(object sender, EventArgs e)
        {
            chklstLA.Items.RemoveAt(chklstLA.SelectedIndex);
        }
        #endregion

        #region Right Arm Internal Components
        private void chklstComponentsRA_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstComponentsRA_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsRA.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsRA.Items.Count)  // check that an string is selected
            {

                chklstComponentsRA.DoDragDrop(chklstComponentsRA.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsRA_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstRA_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstRA_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstRA.IndexFromPoint(chklstRA.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstRA.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstRA.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstRA.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstRA_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstRA_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstRA.Items.Count)
                {
                    chklstRA.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstRA.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstRA.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentRA_Click(object sender, EventArgs e)
        {
            chklstRA.Items.RemoveAt(chklstRA.SelectedIndex);
        }
        #endregion

        #region Left Leg Internal Components
        private void chklstComponentsLL_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstComponentsLL_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsLL.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsLL.Items.Count)  // check that an string is selected
            {

                chklstComponentsLL.DoDragDrop(chklstComponentsLL.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsLL_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstLL_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstLL_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstLL.IndexFromPoint(chklstLL.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstLL.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstLL.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstLL.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstLL_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstLL_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstLL.Items.Count)
                {
                    chklstLL.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstLL.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstLL.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentLL_Click(object sender, EventArgs e)
        {
            chklstLL.Items.RemoveAt(chklstLL.SelectedIndex);
        }
        #endregion

        #region Right Leg Internal Components
        private void chklstComponentsRL_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                  ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                  ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                  ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstComponentsRL_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsRL.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsRL.Items.Count)  // check that an string is selected
            {

                chklstComponentsRL.DoDragDrop(chklstComponentsRL.Items[indexOfItem], DragDropEffects.Copy);
            }
        }

        private void chklstComponentsRL_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void chklstRL_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                     ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                     ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                     ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }
        }

        private void chklstRL_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop = chklstRL.IndexFromPoint(chklstRL.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {
                chklstRL.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                chklstRL.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstRL.Items.Remove((string)e.Data.GetData(DataFormats.Text));


            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstRL_DragEnter(object sender, DragEventArgs e)
        {
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;


        }

        private void chklstRL_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstRL.Items.Count)
                {
                    chklstRL.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstRL.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    chklstRL.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void cmdRemoveComponentRL_Click(object sender, EventArgs e)
        {
            chklstRL.Items.RemoveAt(chklstRL.SelectedIndex);
        }

        #endregion
    }
}
