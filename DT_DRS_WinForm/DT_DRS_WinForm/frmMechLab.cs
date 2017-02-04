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
            chklstHead.Items.RemoveAt(chklstHead.SelectedIndex);
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
                        chklstComponentsH.Items.Add(Weapon.Name + " (" + Weapon.Crits + " Crits)");
                        chklstComponentsH.Sorted = true;
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

        private void chklstComponentsH_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void chklstComponentsH_DragEnter(object sender, DragEventArgs e)
        {
            // This event will  never be triggered unless listBox1.AllowDrop == true
            // Adding this event to listBox1's events allows the cursor to change
            // to indicate to the user that a copy dragdrop operation is underway.
            // Execution here signifies a DragDrop operation is running on this control
            // In this demo, I really don't want to allow a drop into listBox1.
            // Since I haven't written a listBox1_DragDrop event handler
            // an insertion into listBox1's Items never occurs.
            e.Effect = DragDropEffects.Copy;
        }

        private void GiveInfoAboutDragDropEvent(DateTime eventTime, string dragDropEventName, object originalSender, System.Windows.Forms.DragEventArgs e)
        {
            //listBox3.SetSelected(listBox3.Items.Count, true);
        }


        private void chklstComponentsH_MouseDown(object sender, MouseEventArgs e)
        {
            // starts a DoDragDrop operation with allowed effect  "Copy"
            DateTime date = DateTime.Now; // get time of event
            int indexOfItem = chklstComponentsH.IndexFromPoint(e.X, e.Y);
            if (indexOfItem >= 0 && indexOfItem < chklstComponentsH.Items.Count)  // check that an string is selected
            {

                // Set allowed DragDropEffect to Copy selected from DragDropEffects enumberation of None, Move, All etc.
                chklstComponentsH.DoDragDrop(chklstComponentsH.Items[indexOfItem], DragDropEffects.Copy);
            }
        }
        private Point screenOffset;
        private void chklstComponentsH_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            // This event is fired when there is a change in the keyboard or mouse button state
            // during a drag-and-drop operation.  This means that if the cursor is
            // moved,  this event is fired.  If the keyboard is pressed or if a
            // change to a mouse button occurs(press or release), this even is fired.
            // In other words, this event is fired alot!
            // For the purposes of the demo, if the mouse cursor  moves off Form1's boundaries
            // during DoDragDrop operation initiated by the  listBox2 mousedown event
            // the DoDragDrop operation initiated should be cancelled.

            // ( from VS. .NET Combined Collection Control.DoDragDrop documentation)
            // The screenOffset is used to account for any desktop bands
            // that may be at the top or left side of the screen when
            // determining when to cancel the drag drop operation.
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                // Cancel the drag if the mouse moves off the form. The screenOffset
                // takes into account any desktop bands that may be at the top or left
                // side of the screen.
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                    ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                    ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                    ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }


        }
        private int indexOfItemUnderMouseToDrop;
        private int indexOfItemUnderMouseToDrag;
        private void chklstHead_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                if (indexOfItemUnderMouseToDrop >= 0 && indexOfItemUnderMouseToDrop < chklstHead.Items.Count)
                {
                    chklstHead.Items.Insert(indexOfItemUnderMouseToDrop, e.Data.GetData(DataFormats.Text));
                    chklstHead.Items.RemoveAt(indexOfItemUnderMouseToDrop + 1);
                }
                else
                {
                    // add the selected string to bottom of list
                    chklstHead.Items.Add(e.Data.GetData(DataFormats.Text));
                }


            }
            // fill info listBox
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragDrop", sender, e);
            DateTime date = DateTime.Now;

            label1.Text = "";  // Erase info label.
        }

        private void chklstHead_DragEnter(object sender, DragEventArgs e)
        {
            // fill the informational listBox3
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragEnter", sender, e);

            // change the drag cursor to show that listbox2 is ready and set to accept data entry
            // either to Copy or Move
            // make sure we aren't inadvertently passing one of the other objects allow such as a bitmap!

            if (e.Data.GetDataPresent(DataFormats.StringFormat) && (e.AllowedEffect == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;



        }
        private DateTime eventTime;
        private void chklstHead_DragOver(object sender, DragEventArgs e)
        {
            indexOfItemUnderMouseToDrop =
    chklstHead.IndexFromPoint(chklstHead.PointToClient(new Point(e.X, e.Y)));

            if (indexOfItemUnderMouseToDrop != ListBox.NoMatches)
            {

                // pass the location back to use in the dragDrop event method.
                chklstHead.SelectedIndex = indexOfItemUnderMouseToDrop;

            }
            else
            {

                // save the intended drop location as an index number into the listBox2 Item collection.
                chklstHead.SelectedIndex = indexOfItemUnderMouseToDrop;
            }

            // if  the MouseDown event set the DragDrop operation to be a move event
            // immediately delete the item.  This has the desirable effect of
            // deleting any duplicate strings that might have been moved into
            // listBox2
            if (e.Effect == DragDropEffects.Move)  // When moving an item within listBox2
                chklstHead.Items.Remove((string)e.Data.GetData(DataFormats.Text));

            // fill the informational listBox3
            eventTime = DateTime.Now;
            GiveInfoAboutDragDropEvent(eventTime, "listBox2_DragOver", sender, e);
        }

        private void chklstHead_MouseDown(object sender, MouseEventArgs e)
        {

           // int indexOfItem = chklstHead.IndexFromPoint(e.X, e.Y);
            //DateTime date = DateTime.Now;
            //if (indexOfItem >= 0 && indexOfItem < chklstHead.Items.Count)  // check we clicked down on a string
            //{

            //    // Set allowed DragDropEffect to Move selected from DragDropEffects enumberation of None, Move, All etc.
            //    // A mouse down in listBox2 in this demo implies either delete or rearrange
            //    // is started, therefore the allowed DragDropEffect is always Move.
               //chklstHead.DoDragDrop(chklstHead.Items[indexOfItem], DragDropEffects.Move);

            //}
        }

        private void chklstHead_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            // This event is fired when there is a change in the keyboard or mouse button state
            // during a drag-and-drop operation.  This means that if the cursor is
            // moved,  this event is fired.  If the keyboard is pressed or if a
            // change to a mouse button occurs(press or release), this even is fired.
            // In other words,  this event is fired alot!
            // For the purposes of the demo, if the mouse cursor  moves off Form1's boundaries
            // during DoDragDrop operation initiated by the  listBox2 mousedown event
            // the DoDragDrop operation initiated should be cancelled.

            // ( from VS. .NET Combined Collection Control.DoDragDrop documentation)
            // The screenOffset is used to account for any desktop bands
            // that may be at the top or left side of the screen when
            // determining when to cancel the drag drop operation.
            screenOffset = SystemInformation.WorkingArea.Location;

            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Form f = lb.FindForm();
                // Cancel the drag if the mouse moves off the form. The screenOffset
                // takes into account any desktop bands that may be at the top or left
                // side of the screen.
                if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
                    ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
                    ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
                    ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
                {
                    e.Action = DragAction.Cancel;
                }
            }


        }
    }
}
