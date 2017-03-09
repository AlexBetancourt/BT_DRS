namespace BT_DRS_WinForm
{
    partial class frmTables
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
            this.picTables = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTables)).BeginInit();
            this.SuspendLayout();
            // 
            // picTables
            // 
            this.picTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTables.Location = new System.Drawing.Point(12, 12);
            this.picTables.Name = "picTables";
            this.picTables.Size = new System.Drawing.Size(260, 238);
            this.picTables.TabIndex = 0;
            this.picTables.TabStop = false;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.picTables);
            this.Name = "frmTables";
            this.Text = "frmTables";
            this.Load += new System.EventHandler(this.frmTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTables;
    }
}