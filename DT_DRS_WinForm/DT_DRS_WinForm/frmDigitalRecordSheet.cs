using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using LiteDB;

namespace DT_DRS_WinForm
{
    public partial class frmDigitalRecordSheet : Form
    {
        public frmDigitalRecordSheet()
        {
            InitializeComponent();
        }

        #region "VARIABLES"
        int ApplyDamage;
        int DamageLocations;
        int DamageLocationsApplied;
        int actualDamage;
        int AppliedDamage;
        int DamageFactor;
        #endregion

        #region "SOUNDS"
        int Heat = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 - WEAPON Laser Small.wav");
            int length = 1;
            for (int i = 0; i < length; i++)
            {
                player.Play();
                Thread.Sleep(1000);
            }


            Heat = Heat + 1;
            if (Heat > 30)
            {
                pgbHeat.Value = 30;
            }
            else
            {
                pgbHeat.Value = Heat;
            }
            txtHeat.Text = Heat.ToString();
            HeatModifiers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 V Betty - STARTUP Reactor Online.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(2000);
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
                //DRS_DB();
                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 - WEAPON Laser Medium.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }
                //int Heat = 0;

                Heat = Heat + 3;
                if (Heat > 30)
                {
                    pgbHeat.Value = 30;
                }
                else
                {
                    pgbHeat.Value = Heat;
                }
                txtHeat.Text = Heat.ToString();
                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 - WEAPON Laser Large.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }
                //int Heat = 0;

                Heat = Heat + 8;

                if (Heat > 30)
                {
                    pgbHeat.Value = 30;
                }
                else
                {
                    pgbHeat.Value = Heat;
                }
                txtHeat.Text = Heat.ToString();
                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 - WEAPON AC20.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }
                //int Heat = 0;
                if (rdAC2.Checked || rdAC5.Checked)
                {
                    Heat = Heat + 1;
                }
                else if (rdAC10.Checked)
                {
                    Heat = Heat + 3;
                }
                else if (rdAC20.Checked)
                    Heat = Heat + 7;
                txtHeat.Text = Heat.ToString();
                if (Heat > 30)
                {
                    pgbHeat.Value = 30;
                }
                else
                {
                    pgbHeat.Value = Heat;
                }
                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW3 - WEAPON SRM6.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }

                //int Heat = 0;
                if (rdSRM2.Checked)
                    Heat = Heat + +2;
                else if (rdSRM4.Checked)
                    Heat = Heat + +3;
                else if (rdSRM6.Checked)
                    Heat = Heat + +4;
                txtHeat.Text = Heat.ToString();
                if (Heat > 30)
                {
                    pgbHeat.Value = 30;
                }
                else
                {
                    pgbHeat.Value = Heat;
                }
                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 - WEAPON PPC.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }

                // int Heat = 0;

                Heat = Heat + 10;
                txtHeat.Text = Heat.ToString();
                if (Heat > 30)
                {
                    pgbHeat.Value = 30;
                }
                else
                {
                    pgbHeat.Value = Heat;
                }

                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW3 - WEAPON LRM20.wav");
                int length = 1;
                for (int i = 0; i < length; i++)
                {
                    player.Play();
                    Thread.Sleep(1000);
                }

                //int Heat = 0;

                if (rdLRM5.Checked)
                    Heat = pgbHeat.Value + 2;
                else if (rdLRM10.Checked)
                    Heat = pgbHeat.Value + 4;
                else if (rdLRM15.Checked)
                    Heat = pgbHeat.Value + 5;
                else if (rdLRM20.Checked)
                    Heat = pgbHeat.Value + 6;

                if (Heat > 30)
                {
                    pgbHeat.Value = 30;
                }
                else
                {
                    pgbHeat.Value = Heat;
                }
                txtHeat.Text = Heat.ToString();
                HeatModifiers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion

        #region "DAMAGE MENU SELECTION"
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            ApplyDamage = 2;
            ApplyDamage = 6;
            DamageLocations = 3;
            DamageLocationsApplied = 0;
            DamageFactor = 2;
            AppliedDamage = 0;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void AlertColor()
        {
            lblDamage.BackColor = Color.Yellow;
        }
        private void hitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 2;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void mnuApplyDamage_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDamage = 4;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void largeLaserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 8;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 8;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void pPCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 10;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 10;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void mediumLaserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 5;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void smallLaserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 3;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 3;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void aC2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 2;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void aC5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 5;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void aC10ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 10;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 10;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void aC20ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApplyDamage = 20;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 20;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ApplyDamage = 1;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 1;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem6_Click(object sender, EventArgs e)
        {

            ApplyDamage = 2;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem7_Click(object sender, EventArgs e)
        {

            ApplyDamage = 3;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 3;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem8_Click(object sender, EventArgs e)
        {

            ApplyDamage = 4;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 4;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem9_Click(object sender, EventArgs e)
        {

            ApplyDamage = 5;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem10_Click(object sender, EventArgs e)
        {

            ApplyDamage = 3;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 3;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem11_Click(object sender, EventArgs e)
        {

            ApplyDamage = 4;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 4;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem12_Click(object sender, EventArgs e)
        {

            ApplyDamage = 6;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();

        }


        private void hitsToolStripMenuItem13_Click(object sender, EventArgs e)
        {

            ApplyDamage = 8;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem14_Click(object sender, EventArgs e)
        {

            ApplyDamage = 10;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem20_Click(object sender, EventArgs e)
        {

            ApplyDamage = 6;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem21_Click(object sender, EventArgs e)
        {

            ApplyDamage = 9;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem22_Click(object sender, EventArgs e)
        {

            ApplyDamage = 12;
            DamageLocations = 3;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem23_Click(object sender, EventArgs e)
        {

            ApplyDamage = 16;
            DamageLocations = 4;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem24_Click(object sender, EventArgs e)
        {

            ApplyDamage = 20;
            DamageLocations = 4;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hItsToolStripMenuItem19_Click(object sender, EventArgs e)
        {

            ApplyDamage = 15;
            DamageLocations = 3;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem18_Click(object sender, EventArgs e)
        {

            ApplyDamage = 12;
            DamageLocations = 3;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem17_Click(object sender, EventArgs e)
        {

            ApplyDamage = 9;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem16_Click(object sender, EventArgs e)
        {

            ApplyDamage = 6;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem15_Click(object sender, EventArgs e)
        {

            ApplyDamage = 5;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 5;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            ApplyDamage = 2;
            DamageLocations = 1;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            ApplyDamage = 4;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

            ApplyDamage = 8;
            DamageLocations = 4;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();

        }

        private void hitsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ApplyDamage = 4;
            DamageLocations = 2;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();

        }

        private void hitsToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ApplyDamage = 6;
            DamageLocations = 3;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();

        }

        private void hitsToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            ApplyDamage = 8;
            DamageLocations = 4;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();

        }

        private void hitsToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            ApplyDamage = 10;
            DamageLocations = 5;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        private void hitsToolStripMenuItem5_Click(object sender, EventArgs e)
        {

            ApplyDamage = 12;
            DamageLocations = 6;
            DamageLocationsApplied = 0;
            AppliedDamage = 0;
            DamageFactor = 2;
            lblDamage.Text = "Select " + DamageLocations.ToString() + " Locations";
            AlertColor();
        }

        #endregion

        #region "FUNCTIONS"
        public void DRS_DB()
        {
            using (var DataBase = new LiteDatabase(@"DRS.db"))
            {
                //var Mechs = DataBase.GetCollection<DS_BTDRSMechs>("Mechs");
                //var Mech = new DS_BTDRSMechs
                //{
                //    MechID = 1,
                //    Name = "ENFORCER",
                //    Code = "ENF-4R",
                //    Walk = 4,
                //    Run = 6,
                //    Jump = 4,
                //    Heatsinks = 12,
                //    Tons = 50
                //};
                //Mechs.Insert(Mech);

                //var Mech2 = new DS_BTDRSMechs
                //{
                //    MechID = 2,
                //    Name = "TREBUCHET",
                //    Code = "TBT-5N",
                //    Walk = 5,
                //    Run = 8,
                //    Jump = 0,
                //    Heatsinks = 10,
                //    Tons = 50
                //};
                //Mechs.Insert(Mech2);
            }


        }

        private void HeatModifiers()
        {
            try
            {
                if (pgbHeat.Value >= 5)
                {
                    lbl1M.Visible = true;
                    lblMModWalk.Text = "-1";

                    double RunMod;
                    RunMod = (int.Parse(txtWalk.Text) - 1) * 1.5;
                    int RunModRounded = int.Parse(Math.Ceiling(RunMod).ToString());
                    lblMModRun.Text = "-" + (int.Parse(txtRun.Text) - RunModRounded).ToString();


                }
                else
                {
                    lbl1M.Visible = false;
                    lblMModWalk.Text = lblMModRun.Text = lblMModJump.Text = "";

                }
                if (pgbHeat.Value >= 8)
                    lbl1TH.Visible = true;
                else
                    lbl1TH.Visible = false;

                if (pgbHeat.Value >= 10)
                {
                    lbl2M.Visible = true;
                    lblMModWalk.Text = "-2";
                    double RunMod;
                    RunMod = (int.Parse(txtWalk.Text) - 2) * 1.5;
                    int RunModRounded = int.Parse(Math.Ceiling(RunMod).ToString());
                    lblMModRun.Text = "-" + (int.Parse(txtRun.Text) - RunModRounded).ToString();
                }
                else
                {
                    lbl2M.Visible = false;
                    //               lblMModWalk.Text = lblMModRun.Text = lblMModJump.Text = "";
                }
                if (pgbHeat.Value >= 13)
                    lbl2TH.Visible = true;
                else
                    lbl2TH.Visible = false;

                if (pgbHeat.Value >= 14)
                    lblSD4.Visible = true;
                else
                    lblSD4.Visible = false;

                if (pgbHeat.Value >= 15)
                {
                    lbl3M.Visible = true;
                    lblMModWalk.Text = "-3";
                    double RunMod;
                    RunMod = (int.Parse(txtWalk.Text) - 3) * 1.5;
                    int RunModRounded = int.Parse(Math.Ceiling(RunMod).ToString());
                    lblMModRun.Text = "-" + (int.Parse(txtRun.Text) - RunModRounded).ToString();

                }
                else
                {
                    lbl3M.Visible = false;
                    //   lblMModWalk.Text = lblMModRun.Text = lblMModJump.Text = "";

                }
                if (pgbHeat.Value >= 17)
                    lbl3TH.Visible = true;
                else
                    lbl3TH.Visible = false;

                if (pgbHeat.Value >= 18)
                    lblSD6.Visible = true;
                else
                    lblSD6.Visible = false;

                if (pgbHeat.Value >= 19)
                    lblAE4.Visible = true;
                else
                    lblAE4.Visible = false;

                if (pgbHeat.Value >= 20)
                {
                    lbl4M.Visible = true;
                    lblMModWalk.Text = "-4";
                    double RunMod;
                    RunMod = (int.Parse(txtWalk.Text) - 4) * 1.5;
                    int RunModRounded = int.Parse(Math.Ceiling(RunMod).ToString());
                    lblMModRun.Text = "-" + (int.Parse(txtRun.Text) - RunModRounded).ToString();
                }
                else
                {
                    lbl4M.Visible = false;
                    //               lblMModWalk.Text = lblMModRun.Text = lblMModJump.Text = "";

                }
                if (pgbHeat.Value >= 22)
                    lblSD8.Visible = true;
                else
                    lblSD8.Visible = false;

                if (pgbHeat.Value >= 23)
                    lblAE6.Visible = true;
                else
                    lblAE6.Visible = false;

                if (pgbHeat.Value >= 24)
                    lbl4TH.Visible = true;
                else
                    lbl4TH.Visible = false;

                if (pgbHeat.Value >= 25)
                {
                    lbl5M.Visible = true;
                    lblMModWalk.Text = "-5";

                    double RunMod;
                    RunMod = (int.Parse(txtWalk.Text) - 5) * 1.5;
                    int RunModRounded = int.Parse(Math.Ceiling(RunMod).ToString());
                    lblMModRun.Text = "-" + (int.Parse(txtRun.Text) - RunModRounded).ToString();
                }
                else
                {
                    lbl5M.Visible = false;
                    //                lblMModWalk.Text = lblMModRun.Text = lblMModJump.Text = "";
                }

                if (pgbHeat.Value >= 26)
                    lblSD10.Visible = true;
                else
                    lblSD10.Visible = false;

                if (pgbHeat.Value >= 28)
                    lblAE8.Visible = true;
                else
                    lblAE8.Visible = false;

                if (pgbHeat.Value >= 30)
                    lblShutdown.Visible = true;
                else
                    lblShutdown.Visible = false;

                txtHeat.Text = Heat.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void validateInternalDamage(int Damage, int Armor, TextBox InternalControl, TextBox TransferControl)
        {
            try
            {
                if (Damage >= ((Armor / 3) * 2))
                {
                    InternalControl.BackColor = Color.Red;
                    InternalControl.ForeColor = Color.White;
                }
                else if (Damage >= (Armor / 3))
                {
                    InternalControl.BackColor = Color.Yellow;
                }

                if (Damage >= Armor)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW2 Betty - Destroyed.wav");
                    int length = 1;
                    for (int i = 0; i < length; i++)
                    {
                        player.Play();
                        Thread.Sleep(1000);
                    }
                    InternalControl.BackColor = Color.Black;
                    InternalControl.ForeColor = Color.White;
                    InternalControl.Enabled = false;
                    InternalControl.ReadOnly = true;
                    InternalControl.Text = Armor.ToString();

                    TransferControl.Text = (int.Parse(TransferControl.Text) + (Damage - Armor)).ToString();

                    if (InternalControl.Name == "txtILT")
                    {
                        txtLA.BackColor = txtILA.BackColor = Color.Black;
                        txtLA.ForeColor = txtILA.ForeColor = Color.White;
                        txtLA.Enabled = txtILA.Enabled = false;
                        txtLA.ReadOnly = txtILA.ReadOnly = true;
                    }
                    if (InternalControl.Name == "txtIRT")
                    {
                        txtRA.BackColor = txtIRA.BackColor = Color.Black;
                        txtRA.ForeColor = txtIRA.ForeColor = Color.White;
                        txtRA.Enabled = txtIRA.Enabled = false;
                        txtRA.ReadOnly = txtIRA.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void validateInternalDamage(int Damage, int Armor, TextBox InternalControl)
        {
            try
            {
                if (Damage >= ((Armor / 3) * 2))
                {
                    InternalControl.BackColor = Color.Red;
                    InternalControl.ForeColor = Color.White;
                }
                else if (Damage >= (Armor / 3))
                {
                    InternalControl.BackColor = Color.Yellow;
                }

                if (Damage >= Armor)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW2 Betty - Destroyed.wav");
                    int length = 1;
                    for (int i = 0; i < length; i++)
                    {
                        player.Play();
                        Thread.Sleep(1000);
                    }
                    InternalControl.BackColor = Color.Black;
                    InternalControl.ForeColor = Color.White;
                    InternalControl.Text = Armor.ToString();

                    txtCT.BackColor = txtCTR.BackColor = txtRT.BackColor = txtRTR.BackColor = txtLT.BackColor = txtLTR.BackColor = txtLA.BackColor = txtRA.BackColor = txtLL.BackColor = txtRL.BackColor = txtH.BackColor = txtIH.BackColor = txtICT.BackColor = txtILT.BackColor = txtIRT.BackColor = txtILA.BackColor = txtIRA.BackColor = txtILL.BackColor = txtIRL.BackColor = Color.Black;
                    txtCT.Enabled = txtCTR.Enabled = txtRT.Enabled = txtRTR.Enabled = txtLT.Enabled = txtLTR.Enabled = txtLA.Enabled = txtRA.Enabled = txtLL.Enabled = txtRL.Enabled = txtH.Enabled = txtIH.Enabled = txtICT.Enabled = txtILT.Enabled = txtIRT.Enabled = txtILA.Enabled = txtIRA.Enabled = txtILL.Enabled = txtIRL.Enabled = false;
                    txtCT.ReadOnly = txtCTR.ReadOnly = txtRT.ReadOnly = txtRTR.ReadOnly = txtLT.ReadOnly = txtLTR.ReadOnly = txtLA.ReadOnly = txtRA.ReadOnly = txtLL.ReadOnly = txtRL.ReadOnly = txtH.ReadOnly = txtIH.ReadOnly = txtICT.ReadOnly = txtILT.ReadOnly = txtIRT.ReadOnly = txtILA.ReadOnly = txtIRA.ReadOnly = txtILL.ReadOnly = txtIRL.ReadOnly = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void validateTransferDamage(int Damage, int Armor, TextBox InternalControl, TextBox TransferLocation)
        {
            try
            {
                if (Damage >= ((Armor / 3) * 2))
                {
                    InternalControl.BackColor = Color.Red;
                    InternalControl.ForeColor = Color.White;
                }
                else if (Damage >= (Armor / 3))
                {
                    InternalControl.BackColor = Color.Yellow;
                }

                if (Damage >= Armor)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW2 Betty - Destroyed.wav");
                    int length = 1;
                    for (int i = 0; i < length; i++)
                    {
                        player.Play();
                        Thread.Sleep(1000);
                    }
                    InternalControl.BackColor = Color.Black;
                    InternalControl.ForeColor = Color.White;
                    InternalControl.Enabled = false;
                    InternalControl.ReadOnly = true;
                    InternalControl.Text = Armor.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void validateArmor(int Damage, int Armor, TextBox Control, TextBox InternalControl)
        {
            try
            {
                if (Damage >= ((Armor / 3) * 2))
                {
                    Control.BackColor = Color.Red;
                    Control.ForeColor = Color.White;
                }
                else if (Damage >= (Armor / 3))
                {
                    Control.BackColor = Color.Yellow;
                }
                if (Damage > Armor)
                {
                    Control.Text = Armor.ToString();
                    Control.BackColor = Color.Black;
                    Control.ForeColor = Color.White;
                    Control.Enabled = false;
                    Control.ReadOnly = true;
                    int InternalDamage;
                    InternalDamage = Damage - Armor;
                    InternalControl.Enabled = true;
                    InternalControl.ReadOnly = false;
                    InternalControl.Text = (int.Parse(InternalControl.Text.ToString()) + InternalDamage).ToString();

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Sounds\MW4 V Betty - Armour Breached.wav");
                    int length = 1;
                    for (int i = 0; i < length; i++)
                    {
                        player.Play();
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ApplyDamageSub(TextBox Control)
        {
            try
            {
                DamageLocationsApplied = DamageLocationsApplied + 1;
                if (DamageLocationsApplied == DamageLocations)
                {
                    actualDamage = int.Parse(Control.Text);
                    int NewDamage = actualDamage + (ApplyDamage - AppliedDamage);
                    Control.Text = NewDamage.ToString();
                    ApplyDamage = 0;
                    DamageLocationsApplied = 0;
                    DamageLocations = 0;
                    AppliedDamage = 0;
                    DamageFactor = 0;
                    lblDamage.Text = "";
                    lblDamage.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    actualDamage = int.Parse(Control.Text);
                    AppliedDamage = AppliedDamage + DamageFactor;
                    int NewDamage = actualDamage + DamageFactor;
                    Control.Text = NewDamage.ToString();
                    if (DamageLocations > 0)
                    {
                        lblDamage.Text = "Select " + (DamageLocations - DamageLocationsApplied).ToString() + " Locations";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion

        #region EVENTS
        private void label22_Click(object sender, EventArgs e)
        {

        }
        private void cmdResetHeat_Click(object sender, EventArgs e)
        {
            pgbHeat.Value = 0;
            if (checkBox1.Checked)
            {
                pgbHeat.Value = pgbHeat.Value + 5;
            }
            if (checkBox2.Checked)
            {
                pgbHeat.Value = pgbHeat.Value + 5;
            }
            HeatModifiers();
        }

        private void cmdHeatSinks_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                checkBox2.Enabled = true;
                Heat = Heat + 5;

                //checkBox1.Enabled = false;
                txtHeat.Text = Heat.ToString();

                HeatModifiers();
            }
            if (checkBox2.Checked)
            {
                checkBox3.Enabled = true;
                Heat = Heat + 5;
                HeatModifiers();
                //checkBox1.Enabled = false;
                txtHeat.Text = Heat.ToString();

                HeatModifiers();
            }
            if (checkBox3.Checked)
            {
                validateInternalDamage(int.Parse(lblICT.Text), int.Parse(lblICT.Text), txtICT);
            }
            if (Heat >= int.Parse(txtHeatSinks.Text))
            {
                Heat = Heat - int.Parse(txtHeatSinks.Text);
                if (Heat > 30)
                    pgbHeat.Value = 30;
                else
                    pgbHeat.Value = Heat;


            }
            else
                pgbHeat.Value = 0;
            HeatModifiers();
        }
        private void frmDataRecordSheet_Load(object sender, EventArgs e)
        {


            string[] MDL = new string[2];
            MDL = this.Text.Split('(');
            if (MDL.Length > 1)
            {
                txtModel.Text = MDL[1].Substring(0, MDL[1].Length - 1);
            }
            HeatModifiers();
            txtModel.ReadOnly = true;
            txtName.ReadOnly = true;
            txtWalk.ReadOnly = true;
            txtRun.ReadOnly = true;
            txtJump.ReadOnly = true;

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void txtHits_TextChanged(object sender, EventArgs e)
        {
            switch (txtHits.Text)
            {
                case "1":
                    lblCons.Text = "3";
                    break;
                case "2":
                    lblCons.Text = "5";
                    break;
                case "3":
                    lblCons.Text = "7";
                    break;
                case "4":
                    lblCons.Text = "10";
                    break;
                case "5":
                    lblCons.Text = "11";
                    break;
                case "6":
                    lblCons.Text = "Dead";
                    break;
                default:
                    lblCons.Text = "3";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
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
                    txtTons.Text = Mech.Tons.ToString();
                    txtName.Text = Mech.Name.ToString();

                    var MechLocations = db.GetCollection<DS_BTDRSMechLocation>("MechLocations");
                    MechLocations.EnsureIndex(x => x.MechID);

                    var MechLocationss = MechLocations.Find(Query.EQ("MechID", Mech.MechID));
                    foreach (DS_BTDRSMechLocation MechLoc in MechLocationss)
                    {
                        switch (MechLoc.LocationID)
                        {
                            case 1:
                                lblH.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 2:
                                lblCT.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 3:
                                lblLT.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 4:
                                lblRT.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 5:
                                lblLA.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 6:
                                lblRA.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 7:
                                lblLL.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 8:
                                lblRL.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 9:
                                lblCTR.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 10:
                                lblLTR.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 11:
                                lblRTR.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 12:
                                lblIH.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 13:
                                lblICT.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 14:
                                lblILT.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 15:
                                lblIRT.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 16:
                                lblILA.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 17:
                                lblIRA.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 18:
                                lblILL.Text = MechLoc.HitPoints.ToString();
                                break;
                            case 19:
                                lblIRL.Text = MechLoc.HitPoints.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtH.Text);
            int Armor = int.Parse(lblH.Text);
            validateArmor(Damage, Armor, txtH, txtIH);
        }

        private void txtH_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtH);
            txtHits.Text = (int.Parse(txtHits.Text) + 1).ToString();
        }

        private void txtCT_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtCT.Text);
            int Armor = int.Parse(lblCT.Text);
            validateArmor(Damage, Armor, txtCT, txtICT);
        }

        private void txtCT_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtCT);
        }

        private void txtLA_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtLA.Text);
            int Armor = int.Parse(lblLA.Text);
            validateArmor(Damage, Armor, txtLA, txtILA);
        }

        private void txtLA_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtLA);

        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtRA.Text);
            int Armor = int.Parse(lblRA.Text);
            validateArmor(Damage, Armor, txtRA, txtIRA);
        }

        private void txtRA_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtRA);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtLT.Text);
            int Armor = int.Parse(lblLT.Text);

            validateArmor(Damage, Armor, txtLT, txtILT);

        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtLT);
        }

        private void txtRT_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtRT.Text);
            int Armor = int.Parse(lblRT.Text);
            validateArmor(Damage, Armor, txtRT, txtIRT);
        }

        private void txtRT_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtRT);
        }

        private void txtLL_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtLL.Text);
            int Armor = int.Parse(lblLL.Text);
            validateArmor(Damage, Armor, txtLL, txtILL);
        }

        private void txtLL_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtLL);
        }

        private void txtRL_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtRL.Text);
            int Armor = int.Parse(lblRL.Text);
            validateArmor(Damage, Armor, txtRL, txtIRL);
        }

        private void txtRL_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtRL);
        }

        private void txtLTR_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtLTR.Text);
            int Armor = int.Parse(lblLTR.Text);
            validateArmor(Damage, Armor, txtLTR, txtILT);
        }

        private void txtLTR_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtLTR);
        }

        private void txtCTR_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtCTR.Text);
            int Armor = int.Parse(lblCTR.Text);
            validateArmor(Damage, Armor, txtCTR, txtICT);
        }

        private void txtCTR_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtCTR);
        }

        private void txtRTR_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtRTR.Text);
            int Armor = int.Parse(lblRTR.Text);
            validateArmor(Damage, Armor, txtRTR, txtIRT);

        }

        private void txtRTR_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtRTR);
        }

        private void txtIH_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtIH.Text);
            int Armor = int.Parse(lblIH.Text);

            validateInternalDamage(Damage, Armor, txtIH);
        }

        private void txtILA_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtILA.Text);
            int Armor = int.Parse(lblILA.Text);

            validateInternalDamage(Damage, Armor, txtILA, txtLT);
        }

        private void txtILT_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtILT.Text);
            int Armor = int.Parse(lblILT.Text);

            validateInternalDamage(Damage, Armor, txtILT, txtCT);
        }

        private void txtICT_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtICT.Text);
            int Armor = int.Parse(lblICT.Text);

            validateInternalDamage(Damage, Armor, txtICT);
        }

        private void txtIRT_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtIRT.Text);
            int Armor = int.Parse(lblIRT.Text);

            validateInternalDamage(Damage, Armor, txtIRT, txtCT);
        }

        private void txtIRA_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtIRA.Text);
            int Armor = int.Parse(lblIRA.Text);

            validateInternalDamage(Damage, Armor, txtIRA, txtRT);
        }

        private void txtILL_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtILL.Text);
            int Armor = int.Parse(lblILL.Text);

            validateInternalDamage(Damage, Armor, txtILL, txtLT);
        }

        private void txtIRL_TextChanged(object sender, EventArgs e)
        {
            int Damage = int.Parse(txtIRL.Text);
            int Armor = int.Parse(lblIRL.Text);

            validateInternalDamage(Damage, Armor, txtIRL, txtRT);
        }

        private void txtIH_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtIH);
            txtHits.Text = (int.Parse(txtHits.Text) + 1).ToString();
        }

        private void txtILA_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtILA);
        }

        private void txtILT_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtILT);
        }

        private void txtICT_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtICT);
        }

        private void txtIRT_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtIRT);
        }

        private void txtIRA_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtIRA);
        }

        private void txtILL_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtILL);
        }

        private void txtIRL_Click(object sender, EventArgs e)
        {
            ApplyDamageSub(txtIRL);
        }

        private void frmDigitalRecordSheet_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lRM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtWalk_Click(object sender, EventArgs e)
        {
            Heat = Heat + 1;
            if (Heat > 30)
                pgbHeat.Value = 30;
            else
                pgbHeat.Value = Heat;
            HeatModifiers();
        }

        private void rdAC20_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAC2.Checked || rdAC5.Checked || rdAC10.Checked || rdAC20.Checked)
            {
                cmdAC.Enabled = true;
            }
            else
                cmdAC.Enabled = false;
        }

        private void rdSRM6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSRM2.Checked || rdSRM4.Checked || rdSRM6.Checked)
            {
                cmdSRM.Enabled = true;
            }
            else
                cmdSRM.Enabled = false;
        }

        private void rdLRM20_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLRM5.Checked || rdLRM10.Checked || rdLRM15.Checked || rdLRM20.Checked)
            {
                cmdLRM.Enabled = true;
            }
            else
                cmdLRM.Enabled = false;
        }

        private void txtHeat_DoubleClick(object sender, EventArgs e)
        {
            pgbHeat.Value = int.Parse(txtHeat.Text);
            HeatModifiers();
        }

        private void txtJump_Click(object sender, EventArgs e)
        {
            Heat = Heat + 3;
            if (Heat > 30)
                pgbHeat.Value = 30;
            else
                pgbHeat.Value = Heat;
            HeatModifiers();
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    pgbHeat.Value = pgbHeat.Value + 5;
            //    HeatModifiers();
            //    //checkBox1.Enabled = false;
            //    txtHeat.Text = pgbHeat.Value.ToString();
            //}
            //else
            //{
            //    pgbHeat.Value = pgbHeat.Value + 5;
            //    HeatModifiers();
            //    //checkBox1.Enabled = false;
            //    txtHeat.Text = pgbHeat.Value.ToString();
            //}
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked) {
            //    pgbHeat.Value = pgbHeat.Value + 5;
            //    HeatModifiers();
            //    //checkBox2.Enabled = false;
            //    txtHeat.Text = pgbHeat.Value.ToString();
            //}
            //else
            //{
            //    pgbHeat.Value = pgbHeat.Value + 5;
            //    HeatModifiers();
            //    //checkBox1.Enabled = false;
            //    txtHeat.Text = pgbHeat.Value.ToString();
            //}
        }

        private void txtRun_Click(object sender, EventArgs e)
        {
            Heat = Heat + 2;
            if (Heat > 30)
                pgbHeat.Value = 30;
            else
                pgbHeat.Value = Heat;
            HeatModifiers();
        }
    }
}
