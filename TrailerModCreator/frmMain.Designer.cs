namespace TrailerModCreator
{
    partial class frmMain
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
            this.cmbTrailerChassis = new System.Windows.Forms.ComboBox();
            this.lblTrailerChassis = new System.Windows.Forms.Label();
            this.lblTrailerCargo = new System.Windows.Forms.Label();
            this.cmbTrailerCargo = new System.Windows.Forms.ComboBox();
            this.btnBuildMod = new System.Windows.Forms.Button();
            this.lblModName = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTrailerChassis
            // 
            this.cmbTrailerChassis.FormattingEnabled = true;
            this.cmbTrailerChassis.Location = new System.Drawing.Point(38, 43);
            this.cmbTrailerChassis.Name = "cmbTrailerChassis";
            this.cmbTrailerChassis.Size = new System.Drawing.Size(197, 21);
            this.cmbTrailerChassis.TabIndex = 0;
            // 
            // lblTrailerChassis
            // 
            this.lblTrailerChassis.AutoSize = true;
            this.lblTrailerChassis.Location = new System.Drawing.Point(38, 24);
            this.lblTrailerChassis.Name = "lblTrailerChassis";
            this.lblTrailerChassis.Size = new System.Drawing.Size(75, 13);
            this.lblTrailerChassis.TabIndex = 1;
            this.lblTrailerChassis.Text = "Trailer Chassis";
            // 
            // lblTrailerCargo
            // 
            this.lblTrailerCargo.AutoSize = true;
            this.lblTrailerCargo.Location = new System.Drawing.Point(38, 97);
            this.lblTrailerCargo.Name = "lblTrailerCargo";
            this.lblTrailerCargo.Size = new System.Drawing.Size(67, 13);
            this.lblTrailerCargo.TabIndex = 3;
            this.lblTrailerCargo.Text = "Trailer Cargo";
            // 
            // cmbTrailerCargo
            // 
            this.cmbTrailerCargo.FormattingEnabled = true;
            this.cmbTrailerCargo.Location = new System.Drawing.Point(38, 116);
            this.cmbTrailerCargo.Name = "cmbTrailerCargo";
            this.cmbTrailerCargo.Size = new System.Drawing.Size(197, 21);
            this.cmbTrailerCargo.TabIndex = 2;
            // 
            // btnBuildMod
            // 
            this.btnBuildMod.Location = new System.Drawing.Point(355, 112);
            this.btnBuildMod.Name = "btnBuildMod";
            this.btnBuildMod.Size = new System.Drawing.Size(194, 25);
            this.btnBuildMod.TabIndex = 4;
            this.btnBuildMod.Text = "Build Trailer Mod";
            this.btnBuildMod.UseVisualStyleBackColor = true;
            this.btnBuildMod.Click += new System.EventHandler(this.btnBuildMod_Click);
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(352, 24);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(59, 13);
            this.lblModName.TabIndex = 5;
            this.lblModName.Text = "Mod Name";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(355, 43);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(194, 20);
            this.txtModName.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 167);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.btnBuildMod);
            this.Controls.Add(this.lblTrailerCargo);
            this.Controls.Add(this.cmbTrailerCargo);
            this.Controls.Add(this.lblTrailerChassis);
            this.Controls.Add(this.cmbTrailerChassis);
            this.MaximumSize = new System.Drawing.Size(630, 206);
            this.MinimumSize = new System.Drawing.Size(630, 206);
            this.Name = "frmMain";
            this.Text = "Trailer Mod Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTrailerChassis;
        private System.Windows.Forms.Label lblTrailerChassis;
        private System.Windows.Forms.Label lblTrailerCargo;
        private System.Windows.Forms.ComboBox cmbTrailerCargo;
        private System.Windows.Forms.Button btnBuildMod;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.TextBox txtModName;
    }
}

