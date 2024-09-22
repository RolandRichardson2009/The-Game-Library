
namespace TheGameLibrary_RDR_2353FA21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainItmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmShopVideoGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmFile,
            this.mnuMainItmShopVideoGames,
            this.mnuMainItmHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.mnuMain.Size = new System.Drawing.Size(438, 27);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainItmFile
            // 
            this.mnuMainItmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmExit});
            this.mnuMainItmFile.Name = "mnuMainItmFile";
            this.mnuMainItmFile.Size = new System.Drawing.Size(37, 19);
            this.mnuMainItmFile.Text = "File";
            // 
            // mnuMainItmExit
            // 
            this.mnuMainItmExit.Name = "mnuMainItmExit";
            this.mnuMainItmExit.Size = new System.Drawing.Size(93, 22);
            this.mnuMainItmExit.Text = "Exit";
            this.mnuMainItmExit.Click += new System.EventHandler(this.mnuMainItmExit_Click);
            // 
            // mnuMainItmShopVideoGames
            // 
            this.mnuMainItmShopVideoGames.Name = "mnuMainItmShopVideoGames";
            this.mnuMainItmShopVideoGames.Size = new System.Drawing.Size(118, 19);
            this.mnuMainItmShopVideoGames.Text = "Shop Video Games";
            this.mnuMainItmShopVideoGames.Click += new System.EventHandler(this.mnuMainItmShopVideoGames_Click);
            // 
            // mnuMainItmHelp
            // 
            this.mnuMainItmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmViewHelp,
            this.mnuMainItmAbout});
            this.mnuMainItmHelp.Name = "mnuMainItmHelp";
            this.mnuMainItmHelp.Size = new System.Drawing.Size(44, 19);
            this.mnuMainItmHelp.Text = "Help";
            // 
            // mnuMainItmViewHelp
            // 
            this.mnuMainItmViewHelp.Name = "mnuMainItmViewHelp";
            this.mnuMainItmViewHelp.Size = new System.Drawing.Size(127, 22);
            this.mnuMainItmViewHelp.Text = "View Help";
            // 
            // mnuMainItmAbout
            // 
            this.mnuMainItmAbout.Name = "mnuMainItmAbout";
            this.mnuMainItmAbout.Size = new System.Drawing.Size(127, 22);
            this.mnuMainItmAbout.Text = "About";
            this.mnuMainItmAbout.Click += new System.EventHandler(this.mnuMainItmAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(438, 376);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Game Library";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmShopVideoGames;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmAbout;
    }
}

