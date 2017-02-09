namespace DT_DRS_WinForm
{
    partial class frmBarracks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.MechPilotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_BTDRS1 = new DT_DRS_WinForm.DS_BTDRS();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nmPS = new System.Windows.Forms.NumericUpDown();
            this.nmGS = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmKS = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmDT = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmHP = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCallSign = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsPilots = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.MechPilotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_BTDRS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MechPilotsBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(96, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 0;
            // 
            // MechPilotsBindingSource
            // 
            this.MechPilotsBindingSource.DataMember = "MechPilots";
            this.MechPilotsBindingSource.DataSource = this.dS_BTDRS1;
            // 
            // dS_BTDRS1
            // 
            this.dS_BTDRS1.DataSetName = "DS_BTDRS";
            this.dS_BTDRS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Affiliation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rank:";
            // 
            // txtRank
            // 
            this.txtRank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MechPilotsBindingSource, "Rank", true));
            this.txtRank.Location = new System.Drawing.Point(96, 129);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(245, 20);
            this.txtRank.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MechPilotsBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(96, 155);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 95);
            this.txtDescription.TabIndex = 7;
            // 
            // nmPS
            // 
            this.nmPS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MechPilotsBindingSource, "PilotingSkill", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.nmPS.Location = new System.Drawing.Point(96, 257);
            this.nmPS.Name = "nmPS";
            this.nmPS.Size = new System.Drawing.Size(57, 20);
            this.nmPS.TabIndex = 9;
            // 
            // nmGS
            // 
            this.nmGS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MechPilotsBindingSource, "GunnerySkill", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.nmGS.Location = new System.Drawing.Point(284, 259);
            this.nmGS.Name = "nmGS";
            this.nmGS.Size = new System.Drawing.Size(57, 20);
            this.nmGS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Piloting Skill:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gunnery Skill:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kills:";
            // 
            // nmKS
            // 
            this.nmKS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MechPilotsBindingSource, "Kills", true));
            this.nmKS.Location = new System.Drawing.Point(96, 309);
            this.nmKS.Name = "nmKS";
            this.nmKS.Size = new System.Drawing.Size(57, 20);
            this.nmKS.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Damage Taken:";
            // 
            // nmDT
            // 
            this.nmDT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MechPilotsBindingSource, "DamageTaken", true));
            this.nmDT.Location = new System.Drawing.Point(284, 285);
            this.nmDT.Name = "nmDT";
            this.nmDT.Size = new System.Drawing.Size(57, 20);
            this.nmDT.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hit Points:";
            // 
            // nmHP
            // 
            this.nmHP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MechPilotsBindingSource, "HitPoints", true));
            this.nmHP.Location = new System.Drawing.Point(96, 283);
            this.nmHP.Name = "nmHP";
            this.nmHP.Size = new System.Drawing.Size(57, 20);
            this.nmHP.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Callsign:";
            // 
            // txtCallSign
            // 
            this.txtCallSign.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MechPilotsBindingSource, "Affiliation", true));
            this.txtCallSign.Location = new System.Drawing.Point(96, 77);
            this.txtCallSign.Name = "txtCallSign";
            this.txtCallSign.Size = new System.Drawing.Size(245, 20);
            this.txtCallSign.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MechPilotsBindingSource, "Affiliation", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Alfirk (22nd Century to Present)",
            "Band of the Damned (3042 to Present)",
            "Calderon Protectorate (3066 to Present)",
            "Capellan Confederation (2366 to Present)",
            "Castilian Principalities (2396 to Present)",
            "Chainelane Isles (2786 to Present)",
            "Clan Blood Spirit (2807 to Present)",
            "Clan Cloud Cobra (2807 to Present)",
            "Clan Coyote (2807 to Present)",
            "Clan Fire Mandrill (2807 to Present)",
            "Clan Ghost Bear (2807 to Present)",
            "Clan Goliath Scorpion (2807 to Present)",
            "Clan Hell\'s Horses (2807 to Present)",
            "Clan Ice Hellion (2807 to Present)",
            "Clan Jade Falcon (2807 to Present)",
            "Clan Nova Cat (2807 to Present)",
            "Clan Sea Fox (2807 to Present)",
            "Clan Snord (3051 to Present)",
            "Clan Snow Raven (2807 to Present)",
            "Clan Spirit Cat (3132 to Present)",
            "Clan Star Adder (2807 to Present)",
            "Clan Steel Viper (2807 to Present)",
            "Clan Steel Wolf (3132 to Present)",
            "Clan Wolf (3057 to Present)",
            "Clan Wolf (in Exile; 2807 to Present)",
            "ComStar Protectorate (2780 to Present)",
            "Dark (3060 to Present)",
            "Death\'s Consorts (3064 to Present)",
            "Draconis Combine (2319 to Present)",
            "Duchy of Andurien (3030 to 3040; 3069 to Present)",
            "Farhome (24th century to Present)",
            "Farstar (3030 to Present)",
            "Federated Suns (2317 to Present)",
            "Fidelis (3060 to Present)",
            "Fiefdom of Randis (2988 to Present)",
            "Filtvelt Coalition (3072 to Present)",
            "Franklin Fiefs (2598 to Present)",
            "Free Worlds League (2271 to Present)",
            "Fronc Reaches (3066 to Present)",
            "Hanseatic League (2891 to Present)",
            "Herotitus (27th century to Present)",
            "Jewel\'s Picardoons (Unknown to Present)",
            "Lyran Commonwealth (2341 to Present)",
            "Magistracy of Canopus (2530 to Present)",
            "Marian Hegemony (2920 to Present)",
            "Mark Brady Gang (Unknown to Present)",
            "Mica Majority (26th century to Present)",
            "New Belt Pirates (3052 to Present)",
            "Niops Association (2700 to Present)",
            "None of the Above",
            "Northwind Highlanders (17th century to Present)",
            "Other Dependent World",
            "Other Independent World",
            "Other Mercenary Unit",
            "Other Pirate Band",
            "Port Krin (2674 to Present)",
            "Rasalhague Dominion (3071 to Present)",
            "Raven Alliance (3083 to Present)",
            "Regulan Fiefs (3086 to Present)",
            "Republic of the Sphere (3081 to Present)",
            "Republic Territories (3135 to Present)",
            "Rim Collection (3048 to Present)",
            "Rim Territories (3042 to Present)",
            "Santander\'s World (3019 to 3049)",
            "Senatorial Alliance (3135 to Present)",
            "Tall Trees Union (3136 to Present)",
            "Taurian Concordat (2335 to Present)",
            "Thanos\' Terribles (Unknown to Present)",
            "The Barrens (32nd Century to Present)",
            "The Marcadia Brothers (Unknown to Present)",
            "The Red Corsair (3055 to Present)",
            "Tortuga Dominions (2593 to Present)",
            "Ummayad Caliphate (2830 to Present)",
            "Vinson\'s Vigilantes (29th century to Present)",
            "Wolf\'s Dragoons (3000 to Present)"});
            this.comboBox2.Location = new System.Drawing.Point(96, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCallSign);
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmHP);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmDT);
            this.groupBox1.Controls.Add(this.nmPS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmGS);
            this.groupBox1.Controls.Add(this.nmKS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 337);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilot ‌Information:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsPilots);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 337);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilot Roster:";
            // 
            // lsPilots
            // 
            this.lsPilots.FormattingEnabled = true;
            this.lsPilots.Location = new System.Drawing.Point(6, 19);
            this.lsPilots.Name = "lsPilots";
            this.lsPilots.Size = new System.Drawing.Size(221, 303);
            this.lsPilots.TabIndex = 0;
            this.lsPilots.SelectedValueChanged += new System.EventHandler(this.lsPilots_SelectedValueChanged);
            // 
            // frmBarracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBarracks";
            this.Text = "Barracks";
            this.Load += new System.EventHandler(this.frmBarracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MechPilotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_BTDRS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DS_BTDRS dS_BTDRS1;
        private System.Windows.Forms.BindingSource MechPilotsBindingSource;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nmPS;
        private System.Windows.Forms.NumericUpDown nmGS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmKS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmHP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCallSign;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsPilots;
    }
}