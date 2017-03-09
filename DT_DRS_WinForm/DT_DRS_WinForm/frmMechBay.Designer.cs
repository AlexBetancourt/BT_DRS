namespace BT_DRS_WinForm
{
    partial class frmMechBay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMechs = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTeam1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTeam2 = new System.Windows.Forms.ListBox();
            this.cmdAddTeam1 = new System.Windows.Forms.Button();
            this.cmdAddTeam2 = new System.Windows.Forms.Button();
            this.cmdRemoveTeam1 = new System.Windows.Forms.Button();
            this.cmdRemoveTeam2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMechs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Mech:";
            // 
            // lbMechs
            // 
            this.lbMechs.FormattingEnabled = true;
            this.lbMechs.Location = new System.Drawing.Point(7, 22);
            this.lbMechs.Name = "lbMechs";
            this.lbMechs.Size = new System.Drawing.Size(211, 303);
            this.lbMechs.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTeam1);
            this.groupBox2.Location = new System.Drawing.Point(356, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RED ARMY";
            // 
            // lbTeam1
            // 
            this.lbTeam1.FormattingEnabled = true;
            this.lbTeam1.Location = new System.Drawing.Point(7, 22);
            this.lbTeam1.Name = "lbTeam1";
            this.lbTeam1.Size = new System.Drawing.Size(211, 95);
            this.lbTeam1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTeam2);
            this.groupBox3.Location = new System.Drawing.Point(356, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BLUE ARMY";
            // 
            // lbTeam2
            // 
            this.lbTeam2.FormattingEnabled = true;
            this.lbTeam2.Location = new System.Drawing.Point(7, 22);
            this.lbTeam2.Name = "lbTeam2";
            this.lbTeam2.Size = new System.Drawing.Size(211, 95);
            this.lbTeam2.TabIndex = 1;
            // 
            // cmdAddTeam1
            // 
            this.cmdAddTeam1.Location = new System.Drawing.Point(255, 81);
            this.cmdAddTeam1.Name = "cmdAddTeam1";
            this.cmdAddTeam1.Size = new System.Drawing.Size(75, 23);
            this.cmdAddTeam1.TabIndex = 3;
            this.cmdAddTeam1.Text = ">>";
            this.cmdAddTeam1.UseVisualStyleBackColor = true;
            this.cmdAddTeam1.Click += new System.EventHandler(this.cmdAddTeam1_Click);
            // 
            // cmdAddTeam2
            // 
            this.cmdAddTeam2.Location = new System.Drawing.Point(255, 259);
            this.cmdAddTeam2.Name = "cmdAddTeam2";
            this.cmdAddTeam2.Size = new System.Drawing.Size(75, 23);
            this.cmdAddTeam2.TabIndex = 4;
            this.cmdAddTeam2.Text = ">>";
            this.cmdAddTeam2.UseVisualStyleBackColor = true;
            this.cmdAddTeam2.Click += new System.EventHandler(this.cmdAddTeam2_Click);
            // 
            // cmdRemoveTeam1
            // 
            this.cmdRemoveTeam1.Location = new System.Drawing.Point(255, 110);
            this.cmdRemoveTeam1.Name = "cmdRemoveTeam1";
            this.cmdRemoveTeam1.Size = new System.Drawing.Size(75, 23);
            this.cmdRemoveTeam1.TabIndex = 5;
            this.cmdRemoveTeam1.Text = "<<";
            this.cmdRemoveTeam1.UseVisualStyleBackColor = true;
            this.cmdRemoveTeam1.Click += new System.EventHandler(this.cmdRemoveTeam1_Click);
            // 
            // cmdRemoveTeam2
            // 
            this.cmdRemoveTeam2.Location = new System.Drawing.Point(255, 288);
            this.cmdRemoveTeam2.Name = "cmdRemoveTeam2";
            this.cmdRemoveTeam2.Size = new System.Drawing.Size(75, 23);
            this.cmdRemoveTeam2.TabIndex = 6;
            this.cmdRemoveTeam2.Text = "<<";
            this.cmdRemoveTeam2.UseVisualStyleBackColor = true;
            this.cmdRemoveTeam2.Click += new System.EventHandler(this.cmdRemoveTeam2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Deploy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMechBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdRemoveTeam2);
            this.Controls.Add(this.cmdRemoveTeam1);
            this.Controls.Add(this.cmdAddTeam2);
            this.Controls.Add(this.cmdAddTeam1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMechBay";
            this.Text = "Mech Bay";
            this.Load += new System.EventHandler(this.frmMechBay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbMechs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbTeam1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbTeam2;
        private System.Windows.Forms.Button cmdAddTeam1;
        private System.Windows.Forms.Button cmdAddTeam2;
        private System.Windows.Forms.Button cmdRemoveTeam1;
        private System.Windows.Forms.Button cmdRemoveTeam2;
        private System.Windows.Forms.Button button1;
    }
}

