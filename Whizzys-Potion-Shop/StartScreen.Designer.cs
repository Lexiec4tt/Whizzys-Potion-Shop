namespace Whizzys_Potion_Shop
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.toUpgradeBtn = new System.Windows.Forms.PictureBox();
            this.toBrewBtn = new System.Windows.Forms.PictureBox();
            this.topHUD1 = new Whizzys_Potion_Shop.topHUD();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toUpgradeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBrewBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(12, 604);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(66, 65);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 1;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // toUpgradeBtn
            // 
            this.toUpgradeBtn.BackColor = System.Drawing.Color.Transparent;
            this.toUpgradeBtn.Image = ((System.Drawing.Image)(resources.GetObject("toUpgradeBtn.Image")));
            this.toUpgradeBtn.Location = new System.Drawing.Point(207, 604);
            this.toUpgradeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toUpgradeBtn.Name = "toUpgradeBtn";
            this.toUpgradeBtn.Size = new System.Drawing.Size(64, 65);
            this.toUpgradeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toUpgradeBtn.TabIndex = 3;
            this.toUpgradeBtn.TabStop = false;
            this.toUpgradeBtn.Click += new System.EventHandler(this.toUpgradeBtn_Click);
            // 
            // toBrewBtn
            // 
            this.toBrewBtn.BackColor = System.Drawing.Color.Transparent;
            this.toBrewBtn.Image = ((System.Drawing.Image)(resources.GetObject("toBrewBtn.Image")));
            this.toBrewBtn.Location = new System.Drawing.Point(112, 604);
            this.toBrewBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toBrewBtn.Name = "toBrewBtn";
            this.toBrewBtn.Size = new System.Drawing.Size(64, 65);
            this.toBrewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toBrewBtn.TabIndex = 4;
            this.toBrewBtn.TabStop = false;
            this.toBrewBtn.Click += new System.EventHandler(this.toBrewBtn_Click);
            // 
            // topHUD1
            // 
            this.topHUD1.BackColor = System.Drawing.Color.Transparent;
            this.topHUD1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHUD1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHUD1.Location = new System.Drawing.Point(0, 0);
            this.topHUD1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.topHUD1.Name = "topHUD1";
            this.topHUD1.Size = new System.Drawing.Size(1193, 700);
            this.topHUD1.TabIndex = 0;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1193, 679);
            this.Controls.Add(this.toBrewBtn);
            this.Controls.Add(this.toUpgradeBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.topHUD1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toUpgradeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBrewBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private topHUD topHUD1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.PictureBox toUpgradeBtn;
        private System.Windows.Forms.PictureBox toBrewBtn;
    }
}