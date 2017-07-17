namespace BT_DRS_WinForm
{
    partial class frmArmory
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
            this.lbWnE = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpWnE = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWeaponType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeat = new System.Windows.Forms.TextBox();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMedium = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTons = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeaponType = new System.Windows.Forms.TextBox();
            this.tpAmmo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameAmmo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAmmoA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTonsAmmo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCostAmmo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBVAmmo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbAmmo = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpWnE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpAmmo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWnE
            // 
            this.lbWnE.FormattingEnabled = true;
            this.lbWnE.Location = new System.Drawing.Point(493, 19);
            this.lbWnE.Name = "lbWnE";
            this.lbWnE.Size = new System.Drawing.Size(134, 277);
            this.lbWnE.Sorted = true;
            this.lbWnE.TabIndex = 0;
            this.lbWnE.SelectedValueChanged += new System.EventHandler(this.lbWnE_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpWnE);
            this.tabControl1.Controls.Add(this.tpAmmo);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 365);
            this.tabControl1.TabIndex = 1;
            // 
            // tpWnE
            // 
            this.tpWnE.Controls.Add(this.button3);
            this.tpWnE.Controls.Add(this.button2);
            this.tpWnE.Controls.Add(this.groupBox1);
            this.tpWnE.Controls.Add(this.lbWnE);
            this.tpWnE.Location = new System.Drawing.Point(4, 22);
            this.tpWnE.Name = "tpWnE";
            this.tpWnE.Padding = new System.Windows.Forms.Padding(3);
            this.tpWnE.Size = new System.Drawing.Size(633, 339);
            this.tpWnE.TabIndex = 0;
            this.tpWnE.Text = "Weapons & Equipment";
            this.tpWnE.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 25);
            this.button3.TabIndex = 29;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 25);
            this.button2.TabIndex = 28;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblWeaponType);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtHeat);
            this.groupBox1.Controls.Add(this.txtDamage);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMinimum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtShort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMedium);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTons);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCrits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmmo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWeaponType);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 327);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.Location = new System.Drawing.Point(252, 74);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(78, 13);
            this.lblWeaponType.TabIndex = 26;
            this.lblWeaponType.Text = "Weapon Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtHeat
            // 
            this.txtHeat.Location = new System.Drawing.Point(130, 71);
            this.txtHeat.Name = "txtHeat";
            this.txtHeat.Size = new System.Drawing.Size(100, 20);
            this.txtHeat.TabIndex = 2;
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(130, 97);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(100, 20);
            this.txtDamage.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ammo per Ton:";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(130, 123);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Crits:";
            // 
            // txtShort
            // 
            this.txtShort.Location = new System.Drawing.Point(130, 149);
            this.txtShort.Name = "txtShort";
            this.txtShort.Size = new System.Drawing.Size(100, 20);
            this.txtShort.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tons:";
            // 
            // txtMedium
            // 
            this.txtMedium.Location = new System.Drawing.Point(130, 175);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(100, 20);
            this.txtMedium.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Long Range:";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(130, 201);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Medium Range:";
            // 
            // txtTons
            // 
            this.txtTons.Location = new System.Drawing.Point(333, 97);
            this.txtTons.Name = "txtTons";
            this.txtTons.Size = new System.Drawing.Size(100, 20);
            this.txtTons.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Short Range:";
            // 
            // txtCrits
            // 
            this.txtCrits.Location = new System.Drawing.Point(333, 123);
            this.txtCrits.Name = "txtCrits";
            this.txtCrits.Size = new System.Drawing.Size(100, 20);
            this.txtCrits.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Minimum Range:";
            // 
            // txtAmmo
            // 
            this.txtAmmo.Location = new System.Drawing.Point(333, 149);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(100, 20);
            this.txtAmmo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Damage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Heat:";
            // 
            // txtWeaponType
            // 
            this.txtWeaponType.Location = new System.Drawing.Point(333, 71);
            this.txtWeaponType.Name = "txtWeaponType";
            this.txtWeaponType.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponType.TabIndex = 13;
            // 
            // tpAmmo
            // 
            this.tpAmmo.Controls.Add(this.button5);
            this.tpAmmo.Controls.Add(this.button4);
            this.tpAmmo.Controls.Add(this.groupBox2);
            this.tpAmmo.Controls.Add(this.lbAmmo);
            this.tpAmmo.Location = new System.Drawing.Point(4, 22);
            this.tpAmmo.Name = "tpAmmo";
            this.tpAmmo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAmmo.Size = new System.Drawing.Size(633, 339);
            this.tpAmmo.TabIndex = 1;
            this.tpAmmo.Text = "Ammo";
            this.tpAmmo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtNameAmmo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAmmoA);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTonsAmmo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCostAmmo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtBVAmmo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 284);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtNameAmmo
            // 
            this.txtNameAmmo.Location = new System.Drawing.Point(130, 101);
            this.txtNameAmmo.Name = "txtNameAmmo";
            this.txtNameAmmo.Size = new System.Drawing.Size(197, 20);
            this.txtNameAmmo.TabIndex = 26;
            this.txtNameAmmo.TextChanged += new System.EventHandler(this.txtNameAmmo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "BV";
            // 
            // txtAmmoA
            // 
            this.txtAmmoA.Location = new System.Drawing.Point(130, 127);
            this.txtAmmoA.Name = "txtAmmoA";
            this.txtAmmoA.Size = new System.Drawing.Size(100, 20);
            this.txtAmmoA.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cost";
            // 
            // txtTonsAmmo
            // 
            this.txtTonsAmmo.Location = new System.Drawing.Point(130, 153);
            this.txtTonsAmmo.Name = "txtTonsAmmo";
            this.txtTonsAmmo.Size = new System.Drawing.Size(100, 20);
            this.txtTonsAmmo.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tons";
            // 
            // txtCostAmmo
            // 
            this.txtCostAmmo.Location = new System.Drawing.Point(333, 127);
            this.txtCostAmmo.Name = "txtCostAmmo";
            this.txtCostAmmo.Size = new System.Drawing.Size(100, 20);
            this.txtCostAmmo.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ammo";
            // 
            // txtBVAmmo
            // 
            this.txtBVAmmo.Location = new System.Drawing.Point(333, 153);
            this.txtBVAmmo.Name = "txtBVAmmo";
            this.txtBVAmmo.Size = new System.Drawing.Size(100, 20);
            this.txtBVAmmo.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Name";
            // 
            // lbAmmo
            // 
            this.lbAmmo.FormattingEnabled = true;
            this.lbAmmo.Location = new System.Drawing.Point(493, 6);
            this.lbAmmo.Name = "lbAmmo";
            this.lbAmmo.Size = new System.Drawing.Size(134, 277);
            this.lbAmmo.TabIndex = 1;
            this.lbAmmo.SelectedIndexChanged += new System.EventHandler(this.lbAmmo_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(560, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 25);
            this.button4.TabIndex = 38;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(493, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 25);
            this.button5.TabIndex = 37;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(333, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 20);
            this.button6.TabIndex = 36;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmArmory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmArmory";
            this.Text = "Armory";
            this.Load += new System.EventHandler(this.frmArmory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpWnE.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpAmmo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbWnE;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpWnE;
        private System.Windows.Forms.TabPage tpAmmo;
        private System.Windows.Forms.ListBox lbAmmo;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.TextBox txtHeat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtMedium;
        private System.Windows.Forms.TextBox txtShort;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.TextBox txtWeaponType;
        private System.Windows.Forms.TextBox txtAmmo;
        private System.Windows.Forms.TextBox txtCrits;
        private System.Windows.Forms.TextBox txtTons;
        private System.Windows.Forms.Label lblWeaponType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBVAmmo;
        private System.Windows.Forms.TextBox txtCostAmmo;
        private System.Windows.Forms.TextBox txtTonsAmmo;
        private System.Windows.Forms.TextBox txtAmmoA;
        private System.Windows.Forms.TextBox txtNameAmmo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}