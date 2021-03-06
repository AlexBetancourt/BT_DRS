﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace BT_DRS_WinForm
{

    public partial class MDI_BTDRS : Form
    {
        private int childFormNumber = 0;
        public string MechName = "";
        public string Table = "";
        public MDI_BTDRS()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new frmDigitalRecordSheet();
            childForm.MdiParent = this;
            childForm.Text = "RecordSheet " + childFormNumber++;

            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmMechMini();
            childForm.MdiParent = this;
            childForm.Text = "RecordSheet " + childFormNumber++;
            childForm.Show();
        }

        private void MDI_BTDRS_Load(object sender, EventArgs e)
        {

            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            this.Size = new System.Drawing.Size(screenWidth, screenHeight);
            this.Location = new System.Drawing.Point(screenLeft, screenTop);

            using (var Database = new LiteDatabase(@"DRS.db"))
            {
                var Locations = Database.GetCollection<DS_BTDRSLocations>("Locations");

                if (Locations.Count() == 0)
                {
                    AutoConfig = true;
                    initializeWeaponsEquipmentToolStripMenuItem_Click(null, null);
                }
                else
                {
                    tsLabel.Text = "Configuration Complete.";
                    tsProgBar.Value = tsProgBar.Maximum;
                }
            }
        }

        private void mechLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmMechLab();
            childForm.MdiParent = this;
            childForm.Text = "MechLab";
            childForm.Show();
        }

        private void initializeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        bool AutoConfig = false;
        private void initializeWeaponsEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AutoConfig || MessageBox.Show("Are you sure you want to Initialize the Database??? (It will erase all data excluding Introductory BoxSet Mechs)", "Initialize Database", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (var Database = new LiteDatabase(@"DRS.db"))
                    {
                        // Some language locals (eg. Hungarian) use "," as a decimal separator so we change that.
                        NumberFormatInfo nfi = new NumberFormatInfo();
                        nfi.NumberDecimalSeparator = ".";
                        //LOCATIONS
                        var LocationRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Locations.csv"));
                        var LocationRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Locations.csv"));
                        var Locations = Database.GetCollection<DS_BTDRSLocations>("Locations");
                        Locations.EnsureIndex(x => x.LocationID);

                        tsLabel.Text = "Loading Configurations...";


                        Locations.Delete(Query.All(1));
                        tsLabel.Text = "Adding Locations";
                        tsProgBar.Value = 0;
                        int rowsCount = 0;
                        while (!LocationRowsCount.EndOfStream)
                        {
                            var line = LocationRowsCount.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "LocationID")
                            {
                                rowsCount = rowsCount + 1;
                            }
                        }
                        tsProgBar.Maximum = rowsCount;
                        
                        while (!LocationRows.EndOfStream)
                        {
                            var line = LocationRows.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "LocationID")
                            {
                                var Location = new DS_BTDRSLocations
                                {
                                    LocationID = int.Parse(values[0]),
                                    Description = values[1]
                                };
                                Locations.Insert(Location);
                                tsProgBar.Value = tsProgBar.Value + 1;
                            }
                        }
                        //MessageBox.Show("Location Count: " + Locations.Count().ToString());


                        //WEAPONS AND EQUIPMENT
                        var WeaponRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\WeaponsNEquipment.csv"));
                        var WeaponRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\WeaponsNEquipment.csv"));
                        var Weapons = Database.GetCollection<DS_BTDRSWeapons>("Weapons");
                        Weapons.EnsureIndex(x => x.WeaponID);

                        Weapons.Delete(Query.All(1));
                        tsLabel.Text = "Adding Weapons";
                        tsProgBar.Value = 0;
                        rowsCount = 0;
                        while (!WeaponRowsCount.EndOfStream)
                        {
                            var line = WeaponRowsCount.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "WeaponID")
                            {
                                rowsCount = rowsCount + 1;
                            }
                        }
                        tsProgBar.Maximum = rowsCount;


                        while (!WeaponRows.EndOfStream)
                        {
                            var line = WeaponRows.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "WeaponID")
                            {
                                // decimal tonnage = decimal.Parse(values[8]);
                                var Weapon = new DS_BTDRSWeapons
                                {
                                    WeaponID = int.Parse(values[0]),
                                    Name = values[1],
                                    Heat = int.Parse(values[2]),
                                    Damage = values[3],
                                    Minimum = values[4],
                                    Short = values[5],
                                    Medium = values[6],
                                    Long = values[7],
                                    Tons = decimal.Parse(values[8], nfi),
                                    Crits = int.Parse(values[9]),
                                    Ammo = values[10],
                                    WeaponType = values[13]
                                };
                                Weapons.Insert(Weapon);
                                tsProgBar.Value = tsProgBar.Value + 1;
                            }


                        }


                        //AMMO
                        var AmmoRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Ammo.csv"));
                        var AmmoRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Ammo.csv"));
                        var Ammos = Database.GetCollection<DS_BTDRSAmmo>("Ammos");
                        Ammos.EnsureIndex(x => x.AmmoID);

                        Ammos.Delete(Query.All(1));
                        tsLabel.Text = "Adding Ammo";
                        tsProgBar.Value = 0;
                        rowsCount = 0;
                        while (!AmmoRowsCount.EndOfStream)
                        {
                            var line = AmmoRowsCount.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "AmmoID")
                            {
                                rowsCount = rowsCount + 1;
                            }
                        }
                        tsProgBar.Maximum = rowsCount;
                        while (!AmmoRows.EndOfStream)
                        {
                            var line = AmmoRows.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "AmmoID")
                            {
                                var Ammo = new DS_BTDRSAmmo
                                {
                                    AmmoID = int.Parse(values[0]),
                                    AmmoName = values[1],
                                    Ammo = values[2],
                                    Tons = decimal.Parse(values[3], nfi),
                                    Cost = int.Parse(values[4]),
                                    BV = int.Parse(values[5])
                                };
                                Ammos.Insert(Ammo);
                                tsProgBar.Value = tsProgBar.Value + 1;
                            }
                        }



                        //MECHS
                        var MechsRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Mechs.csv"));
                        var MechsRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Mechs.csv"));
                        var Mechs = Database.GetCollection<DS_BTDRSMechs>("Mechs");
                        Mechs.EnsureIndex(x => x.MechID);
                        var MechLocations = Database.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                        MechLocations.Delete(Query.All());
                        Mechs.Delete(Query.All(1));
                        tsLabel.Text = "Adding Mechs";
                        tsProgBar.Value = 0;
                        rowsCount = 0;
                        while (!MechsRowsCount.EndOfStream)
                        {
                            var line = MechsRowsCount.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "MechID")
                            {
                                rowsCount = rowsCount + 1;
                            }
                        }
                        tsProgBar.Maximum = rowsCount;
                        while (!MechsRows.EndOfStream)
                        {
                            var line = MechsRows.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "MechID")
                            {
                                var Mech = new DS_BTDRSMechs
                                {
                                    MechID = int.Parse(values[0]),
                                    Name = values[1],
                                    Model = values[2],
                                    Walk = int.Parse(values[3]),
                                    Run = int.Parse(values[4]),
                                    Jump = int.Parse(values[5]),
                                    Heatsinks = int.Parse(values[6]),
                                    Tons = int.Parse(values[7])
                                };
                                Mechs.Insert(Mech);
                                tsProgBar.Value = tsProgBar.Value + 1;
                                //var MechLocations = Database.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                                var MechLocation = new DS_BTDRSMechLocation
                                {
                                    MechLocationID = MechLocations.Count() + 1,
                                    MechID = int.Parse(values[0]),
                                    LocationID = 1,
                                    HitPoints = int.Parse(values[8])
                                };
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 2;
                                MechLocation.HitPoints = int.Parse(values[9]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 3;
                                MechLocation.HitPoints = int.Parse(values[10]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 4;
                                MechLocation.HitPoints = int.Parse(values[11]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 5;
                                MechLocation.HitPoints = int.Parse(values[12]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 6;
                                MechLocation.HitPoints = int.Parse(values[13]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 7;
                                MechLocation.HitPoints = int.Parse(values[14]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 8;
                                MechLocation.HitPoints = int.Parse(values[15]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 9;
                                MechLocation.HitPoints = int.Parse(values[16]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 10;
                                MechLocation.HitPoints = int.Parse(values[17]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 11;
                                MechLocation.HitPoints = int.Parse(values[18]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 12;
                                MechLocation.HitPoints = int.Parse(values[19]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 13;
                                MechLocation.HitPoints = int.Parse(values[20]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 14;
                                MechLocation.HitPoints = int.Parse(values[21]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 15;
                                MechLocation.HitPoints = int.Parse(values[22]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 16;
                                MechLocation.HitPoints = int.Parse(values[23]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 17;
                                MechLocation.HitPoints = int.Parse(values[24]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 18;
                                MechLocation.HitPoints = int.Parse(values[25]);
                                MechLocations.Insert(MechLocation);

                                MechLocation.MechLocationID = MechLocations.Count() + 1;
                                MechLocation.MechID = int.Parse(values[0]);
                                MechLocation.LocationID = 19;
                                MechLocation.HitPoints = int.Parse(values[26]);
                                MechLocations.Insert(MechLocation);



                            }
                           
                        }

                        ////WEAPON LOCATIONS
                        //var WeaponLocations = Database.GetCollection<DS_BTDRSMechWeaponLocation>("MechWeaponLocations");
                        //WeaponLocations.Delete(Query.All());

                        //MECH CONFIGURATIONS
                        var MechConfigsRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\MechConfigs.csv"));
                        var MechConfigsRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\MechConfigs.csv"));
                        var MechConfigs = Database.GetCollection<DS_BTDRSMechConfigs>("MechConfigs");
                        MechConfigs.EnsureIndex(x => x.Tons);

                        MechConfigs.Delete(Query.All(1));
                        tsLabel.Text = "Adding Configs";
                        tsProgBar.Value = 0;
                        rowsCount = 0;
                        while (!MechConfigsRowsCount.EndOfStream)
                        {
                            var line = MechConfigsRowsCount.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "Tons")
                            {
                                rowsCount = rowsCount + 1;
                            }
                        }
                        tsProgBar.Maximum = rowsCount;
                        while (!MechConfigsRows.EndOfStream)
                        {
                            var line = MechConfigsRows.ReadLine();
                            var values = line.Split('|');
                            if (values[0] != "Tons")
                            {
                                var MechConfig = new DS_BTDRSMechConfigs
                                {
                                    Tons = int.Parse(values[0]),
                                    StandarTons = decimal.Parse(values[1], nfi),
                                    EndoTons = decimal.Parse(values[2], nfi),
                                    HeadHP = int.Parse(values[3]),
                                    CTorsoHP = int.Parse(values[4]),
                                    LRTorsoHP = int.Parse(values[5]),
                                    LRArmsHP = int.Parse(values[6]),
                                    LRLegsHP = int.Parse(values[7]),
                                    MaxArmor = values[8]
                                };
                                MechConfigs.Insert(MechConfig);
                                tsProgBar.Value = tsProgBar.Value + 1;
                            }
                        }

                        tsLabel.Text = "Configuration Complete.";


                    }
                    AutoConfig = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mechBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmMechBay();
            childForm.MdiParent = this;
            childForm.Text = "MechBay";
            childForm.Show();
        }

        private void barracksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmBarracks();
            childForm.MdiParent = this;
            childForm.Text = "Barracks";
            childForm.Show();
        }

        private void weaponsAttackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Weapon Attack Modifiers";
            childForm.Text = "Weapon Attack Modifiers";
            childForm.Show();
        }


        Random random1 = new Random();
        private void d6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int randomNumber1 = random1.Next(1, 7);
            diceRollToolStripMenuItem.ShowDropDown();
            d6ToolStripMenuItem.DropDownItems.Insert(0,d6ToolStripMenuItem.DropDownItems.Add("Roll 1D6: " + randomNumber1.ToString()));//  ToolStripDropDown();
            d6ToolStripMenuItem.ShowDropDown();

           // MessageBox.Show("Roll 1D6:  " + randomNumber1.ToString());

        }

        private void d6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int randomNumber1 = random1.Next(1, 7);
            int randomNumber2 = random1.Next(1, 7);
            diceRollToolStripMenuItem.ShowDropDown();
            d6ToolStripMenuItem1.DropDownItems.Insert(0, d6ToolStripMenuItem1.DropDownItems.Add("Roll 2D6:  " + randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = " + (randomNumber1 + randomNumber2).ToString()));//  ToolStripDropDown();
            d6ToolStripMenuItem1.ShowDropDown();
            //MessageBox.Show("Roll 2D6:  " + randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = " + (randomNumber1 + randomNumber2).ToString());
        }

        private void movementCostTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Movement Costs Table";
            childForm.Text = "Movement Costs Table";
            childForm.Show();
        }

        private void allAttacksModifiersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "All Atacks Modifiers";
            childForm.Text = "All Atacks Modifiers";
            childForm.Show();
        }

        private void physicalAttackModifiersTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Physical Attack Modifiers";
            childForm.Text = "Physical Attack Modifiers";
            childForm.Show();
        }

        private void mechHitLocationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Hit Location Table";
            childForm.Text = "Hit Location Table";
            childForm.Show();
        }

        private void mechKickLocationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Kick Location Table";
            childForm.Text = "Kick Location Table";
            childForm.Show();
        }

        private void mechPunchLocationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Punch Location Table";
            childForm.Text = "Punch Location Table";
            childForm.Show();
        }

        private void physicalAttacksModifiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Physical Attacks Modifiers";
            childForm.Text = "Physical Attacks Modifiers";
            childForm.Show();
        }

        private void clusterHitsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Cluster Hits Table";
            childForm.Text = "Cluster Hits Table";
            childForm.Show();
        }

        private void facingAfterFallTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Facing After Fall";
            childForm.Text = "Facing After Fall";
            childForm.Show();
        }

        private void heatPointTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Heat Point Table";
            childForm.Text = "Heat Point Table";
            childForm.Show();
        }

        private void criticalHitsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Critical Hits Table";
            childForm.Text = "Critical Hits Table";
            childForm.Show();
        }

        private void pilotingSkillRollTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmTables();
            childForm.MdiParent = this;
            Table = "Piloting Skill Roll Table";
            childForm.Text = "Piloting Skill Roll Table";
            childForm.Show();
        }

        private void clearRollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d6ToolStripMenuItem.DropDownItems.Clear();
            d6ToolStripMenuItem1.DropDownItems.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new AboutBox1();
            childForm.MdiParent = this;
            Table = "About";
            childForm.Text = "About";
            childForm.Show();
        }

        private void armoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new frmArmory();
            childForm.MdiParent = this;
            childForm.Text = "Armory";
            childForm.Show();
        }

        private void initializeMechsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int rowsCount = 0;
            // Some language locals (eg. Hungarian) use "," as a decimal separator so we change that.
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            using (var Database = new LiteDatabase(@"DRS.db"))
            {
                //MECHS
                var MechsRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Mechs.csv"));
            var MechsRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Mechs.csv"));
            var Mechs = Database.GetCollection<DS_BTDRSMechs>("Mechs");
            Mechs.EnsureIndex(x => x.MechID);
            var MechLocations = Database.GetCollection<DS_BTDRSMechLocation>("MechLocations");
            MechLocations.Delete(Query.All());
            Mechs.Delete(Query.All(1));
            tsLabel.Text = "Adding Mechs";
            tsProgBar.Value = 0;
            rowsCount = 0;
            while (!MechsRowsCount.EndOfStream)
            {
                var line = MechsRowsCount.ReadLine();
                var values = line.Split('|');
                if (values[0] != "MechID")
                {
                    rowsCount = rowsCount + 1;
                }
            }
            tsProgBar.Maximum = rowsCount;
                while (!MechsRows.EndOfStream)
                {
                    var line = MechsRows.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "MechID")
                    {
                        var Mech = new DS_BTDRSMechs
                        {
                            MechID = int.Parse(values[0]),
                            Name = values[1],
                            Model = values[2],
                            Walk = int.Parse(values[3]),
                            Run = int.Parse(values[4]),
                            Jump = int.Parse(values[5]),
                            Heatsinks = int.Parse(values[6]),
                            Tons = int.Parse(values[7])
                        };
                        Mechs.Insert(Mech);
                        tsProgBar.Value = tsProgBar.Value + 1;
                        //var MechLocations = Database.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                        var MechLocation = new DS_BTDRSMechLocation
                        {
                            MechLocationID = MechLocations.Count() + 1,
                            MechID = int.Parse(values[0]),
                            LocationID = 1,
                            HitPoints = int.Parse(values[8])
                        };
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 2;
                        MechLocation.HitPoints = int.Parse(values[9]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 3;
                        MechLocation.HitPoints = int.Parse(values[10]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 4;
                        MechLocation.HitPoints = int.Parse(values[11]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 5;
                        MechLocation.HitPoints = int.Parse(values[12]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 6;
                        MechLocation.HitPoints = int.Parse(values[13]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 7;
                        MechLocation.HitPoints = int.Parse(values[14]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 8;
                        MechLocation.HitPoints = int.Parse(values[15]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 9;
                        MechLocation.HitPoints = int.Parse(values[16]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 10;
                        MechLocation.HitPoints = int.Parse(values[17]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 11;
                        MechLocation.HitPoints = int.Parse(values[18]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 12;
                        MechLocation.HitPoints = int.Parse(values[19]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 13;
                        MechLocation.HitPoints = int.Parse(values[20]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 14;
                        MechLocation.HitPoints = int.Parse(values[21]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 15;
                        MechLocation.HitPoints = int.Parse(values[22]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 16;
                        MechLocation.HitPoints = int.Parse(values[23]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 17;
                        MechLocation.HitPoints = int.Parse(values[24]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 18;
                        MechLocation.HitPoints = int.Parse(values[25]);
                        MechLocations.Insert(MechLocation);

                        MechLocation.MechLocationID = MechLocations.Count() + 1;
                        MechLocation.MechID = int.Parse(values[0]);
                        MechLocation.LocationID = 19;
                        MechLocation.HitPoints = int.Parse(values[26]);
                        MechLocations.Insert(MechLocation);



                    }
                }
            }
            tsLabel.Text = "Initialization Complete.";
        }

        private void initializeMechWarriorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"DRS.db"))
                {
                    var Pilots = db.GetCollection<DS_BTDRSMechPilots>("Pilots");
                    if (MessageBox.Show("Do you really want to delete ALL MechPilots??? (this action cannot be undone!)", "Deleting MechPilots", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Pilots.Delete(Query.All());
                        tsLabel.Text = "Initialization Complete.";
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void initializeWeaponsAndAmmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int rowsCount = 0;
            // Some language locals (eg. Hungarian) use "," as a decimal separator so we change that.
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            using (var Database = new LiteDatabase(@"DRS.db"))
            {
                var WeaponRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\WeaponsNEquipment.csv"));
                var WeaponRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\WeaponsNEquipment.csv"));
                var Weapons = Database.GetCollection<DS_BTDRSWeapons>("Weapons");
                Weapons.EnsureIndex(x => x.WeaponID);

                Weapons.Delete(Query.All(1));
                tsLabel.Text = "Adding Weapons";
                tsProgBar.Value = 0;
                rowsCount = 0;
                while (!WeaponRowsCount.EndOfStream)
                {
                    var line = WeaponRowsCount.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "WeaponID")
                    {
                        rowsCount = rowsCount + 1;
                    }
                }
                tsProgBar.Maximum = rowsCount;


                while (!WeaponRows.EndOfStream)
                {
                    var line = WeaponRows.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "WeaponID")
                    {
                        // decimal tonnage = decimal.Parse(values[8]);
                        var Weapon = new DS_BTDRSWeapons
                        {
                            WeaponID = int.Parse(values[0]),
                            Name = values[1],
                            Heat = int.Parse(values[2]),
                            Damage = values[3],
                            Minimum = values[4],
                            Short = values[5],
                            Medium = values[6],
                            Long = values[7],
                            Tons = decimal.Parse(values[8], nfi),
                            Crits = int.Parse(values[9]),
                            Ammo = values[10],
                            WeaponType = values[13]
                        };
                        Weapons.Insert(Weapon);
                        tsProgBar.Value = tsProgBar.Value + 1;
                    }


                }


                //AMMO
                var AmmoRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Ammo.csv"));
                var AmmoRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\Ammo.csv"));
                var Ammos = Database.GetCollection<DS_BTDRSAmmo>("Ammos");
                Ammos.EnsureIndex(x => x.AmmoID);

                Ammos.Delete(Query.All(1));
                tsLabel.Text = "Adding Ammo";
                tsProgBar.Value = 0;
                rowsCount = 0;
                while (!AmmoRowsCount.EndOfStream)
                {
                    var line = AmmoRowsCount.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "AmmoID")
                    {
                        rowsCount = rowsCount + 1;
                    }
                }
                tsProgBar.Maximum = rowsCount;
                while (!AmmoRows.EndOfStream)
                {
                    var line = AmmoRows.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "AmmoID")
                    {
                        var Ammo = new DS_BTDRSAmmo
                        {
                            AmmoID = int.Parse(values[0]),
                            AmmoName = values[1],
                            Ammo = values[2],
                            Tons = decimal.Parse(values[3], nfi),
                            Cost = int.Parse(values[4]),
                            BV = int.Parse(values[5])
                        };
                        Ammos.Insert(Ammo);
                        tsProgBar.Value = tsProgBar.Value + 1;
                    }
                }
            }
            tsLabel.Text = "Initialization Complete.";
        }

        private void initializeMechConfigurationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WEAPONS AND EQUIPMENT
            int rowsCount = 0;
            // Some language locals (eg. Hungarian) use "," as a decimal separator so we change that.
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            using (var Database = new LiteDatabase(@"DRS.db"))
            {

                //MECH CONFIGURATIONS
                var MechConfigsRowsCount = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\MechConfigs.csv"));
                var MechConfigsRows = new StreamReader(File.OpenRead(Application.StartupPath + @"\Catalogs\MechConfigs.csv"));
                var MechConfigs = Database.GetCollection<DS_BTDRSMechConfigs>("MechConfigs");
                MechConfigs.EnsureIndex(x => x.Tons);

                MechConfigs.Delete(Query.All(1));
                tsLabel.Text = "Adding Configs";
                tsProgBar.Value = 0;
                rowsCount = 0;
                while (!MechConfigsRowsCount.EndOfStream)
                {
                    var line = MechConfigsRowsCount.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "Tons")
                    {
                        rowsCount = rowsCount + 1;
                    }
                }
                tsProgBar.Maximum = rowsCount;
                while (!MechConfigsRows.EndOfStream)
                {
                    var line = MechConfigsRows.ReadLine();
                    var values = line.Split('|');
                    if (values[0] != "Tons")
                    {
                        var MechConfig = new DS_BTDRSMechConfigs
                        {
                            Tons = int.Parse(values[0]),
                            StandarTons = decimal.Parse(values[1], nfi),
                            EndoTons = decimal.Parse(values[2], nfi),
                            HeadHP = int.Parse(values[3]),
                            CTorsoHP = int.Parse(values[4]),
                            LRTorsoHP = int.Parse(values[5]),
                            LRArmsHP = int.Parse(values[6]),
                            LRLegsHP = int.Parse(values[7]),
                            MaxArmor = values[8]
                        };
                        MechConfigs.Insert(MechConfig);
                        tsProgBar.Value = tsProgBar.Value + 1;
                    }
                }
            }
            tsLabel.Text = "Initialization Complete.";
        }
    }
}
