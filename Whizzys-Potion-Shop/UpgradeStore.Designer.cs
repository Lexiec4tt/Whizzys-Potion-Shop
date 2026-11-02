namespace Whizzy_Potion_Shop
{
    partial class UpgradeStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpgradeStore));
            this.incense = new System.Windows.Forms.PictureBox();
            this.cauldronUpgrade = new System.Windows.Forms.PictureBox();
            this.stirringUpd = new System.Windows.Forms.PictureBox();
            this.wilkUpgrade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.incense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauldronUpgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stirringUpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilkUpgrade)).BeginInit();
            this.SuspendLayout();
            // 
            // incense
            // 
            this.incense.Image = ((System.Drawing.Image)(resources.GetObject("incense.Image")));
            this.incense.Location = new System.Drawing.Point(595, 22);
            this.incense.Name = "incense";
            this.incense.Size = new System.Drawing.Size(202, 173);
            this.incense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.incense.TabIndex = 0;
            this.incense.TabStop = false;
            // 
            // cauldronUpgrade
            // 
            this.cauldronUpgrade.Image = ((System.Drawing.Image)(resources.GetObject("cauldronUpgrade.Image")));
            this.cauldronUpgrade.Location = new System.Drawing.Point(578, 214);
            this.cauldronUpgrade.Name = "cauldronUpgrade";
            this.cauldronUpgrade.Size = new System.Drawing.Size(207, 202);
            this.cauldronUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cauldronUpgrade.TabIndex = 1;
            this.cauldronUpgrade.TabStop = false;
            // 
            // stirringUpd
            // 
            this.stirringUpd.Image = ((System.Drawing.Image)(resources.GetObject("stirringUpd.Image")));
            this.stirringUpd.Location = new System.Drawing.Point(889, 12);
            this.stirringUpd.Name = "stirringUpd";
            this.stirringUpd.Size = new System.Drawing.Size(195, 194);
            this.stirringUpd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stirringUpd.TabIndex = 2;
            this.stirringUpd.TabStop = false;
            // 
            // wilkUpgrade
            // 
            this.wilkUpgrade.Image = ((System.Drawing.Image)(resources.GetObject("wilkUpgrade.Image")));
            this.wilkUpgrade.Location = new System.Drawing.Point(915, 238);
            this.wilkUpgrade.Name = "wilkUpgrade";
            this.wilkUpgrade.Size = new System.Drawing.Size(193, 169);
            this.wilkUpgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wilkUpgrade.TabIndex = 3;
            this.wilkUpgrade.TabStop = false;
            // 
            // UpgradeStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1204, 681);
            this.Controls.Add(this.wilkUpgrade);
            this.Controls.Add(this.stirringUpd);
            this.Controls.Add(this.cauldronUpgrade);
            this.Controls.Add(this.incense);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpgradeStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.UpgradeStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauldronUpgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stirringUpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wilkUpgrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox incense;
        private System.Windows.Forms.PictureBox cauldronUpgrade;
        private System.Windows.Forms.PictureBox stirringUpd;
        private System.Windows.Forms.PictureBox wilkUpgrade;
    }
}