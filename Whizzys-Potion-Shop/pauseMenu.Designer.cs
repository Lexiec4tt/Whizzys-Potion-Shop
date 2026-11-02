namespace Test1
{
    partial class pauseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pauseMenu));
            this.resume = new System.Windows.Forms.PictureBox();
            this.pauseIcon = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.toMenu = new System.Windows.Forms.PictureBox();
            this.saveExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveExit)).BeginInit();
            this.SuspendLayout();
            // 
            // resume
            // 
            this.resume.Image = ((System.Drawing.Image)(resources.GetObject("resume.Image")));
            this.resume.Location = new System.Drawing.Point(62, 106);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(233, 66);
            this.resume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resume.TabIndex = 0;
            this.resume.TabStop = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // pauseIcon
            // 
            this.pauseIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseIcon.BackgroundImage")));
            this.pauseIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseIcon.Location = new System.Drawing.Point(128, 12);
            this.pauseIcon.Name = "pauseIcon";
            this.pauseIcon.Size = new System.Drawing.Size(94, 73);
            this.pauseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pauseIcon.TabIndex = 1;
            this.pauseIcon.TabStop = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(62, 186);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(233, 66);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toMenu
            // 
            this.toMenu.Image = ((System.Drawing.Image)(resources.GetObject("toMenu.Image")));
            this.toMenu.Location = new System.Drawing.Point(62, 269);
            this.toMenu.Name = "toMenu";
            this.toMenu.Size = new System.Drawing.Size(233, 66);
            this.toMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toMenu.TabIndex = 3;
            this.toMenu.TabStop = false;
            this.toMenu.Click += new System.EventHandler(this.toMenu_Click);
            // 
            // saveExit
            // 
            this.saveExit.Image = ((System.Drawing.Image)(resources.GetObject("saveExit.Image")));
            this.saveExit.Location = new System.Drawing.Point(62, 352);
            this.saveExit.Name = "saveExit";
            this.saveExit.Size = new System.Drawing.Size(233, 66);
            this.saveExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.saveExit.TabIndex = 4;
            this.saveExit.TabStop = false;
            this.saveExit.Click += new System.EventHandler(this.saveExit_Click);
            // 
            // pauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(356, 451);
            this.Controls.Add(this.saveExit);
            this.Controls.Add(this.toMenu);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pauseIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pauseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Whizzy\'s Potion Shop";
            ((System.ComponentModel.ISupportInitialize)(this.resume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resume;
        private System.Windows.Forms.PictureBox pauseIcon;
        private System.Windows.Forms.PictureBox settingsBtn;
        private System.Windows.Forms.PictureBox toMenu;
        private System.Windows.Forms.PictureBox saveExit;
    }
}