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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.toUpgradeBtn = new System.Windows.Forms.PictureBox();
            this.toBrewBtn = new System.Windows.Forms.PictureBox();
            this.characterBox = new System.Windows.Forms.PictureBox();
            this.customerArriveTimer = new System.Windows.Forms.Timer(this.components);
            this.DialogueTimer = new System.Windows.Forms.Timer(this.components);
            this.acceptBtn = new System.Windows.Forms.PictureBox();
            this.declineBtn = new System.Windows.Forms.PictureBox();
            this.selectedPotionBox = new System.Windows.Forms.PictureBox();
            this.dialogueBox1 = new Whizzys_Potion_Shop.DialogueBox();
            this.topHUD1 = new Whizzys_Potion_Shop.topHUD();
            this.serveBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toUpgradeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBrewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declineBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPotionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serveBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(16, 743);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(88, 80);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 1;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // toUpgradeBtn
            // 
            this.toUpgradeBtn.BackColor = System.Drawing.Color.Transparent;
            this.toUpgradeBtn.Image = ((System.Drawing.Image)(resources.GetObject("toUpgradeBtn.Image")));
            this.toUpgradeBtn.Location = new System.Drawing.Point(276, 743);
            this.toUpgradeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toUpgradeBtn.Name = "toUpgradeBtn";
            this.toUpgradeBtn.Size = new System.Drawing.Size(85, 80);
            this.toUpgradeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toUpgradeBtn.TabIndex = 3;
            this.toUpgradeBtn.TabStop = false;
            this.toUpgradeBtn.Click += new System.EventHandler(this.toUpgradeBtn_Click);
            // 
            // toBrewBtn
            // 
            this.toBrewBtn.BackColor = System.Drawing.Color.Transparent;
            this.toBrewBtn.Image = ((System.Drawing.Image)(resources.GetObject("toBrewBtn.Image")));
            this.toBrewBtn.Location = new System.Drawing.Point(149, 743);
            this.toBrewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toBrewBtn.Name = "toBrewBtn";
            this.toBrewBtn.Size = new System.Drawing.Size(85, 80);
            this.toBrewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toBrewBtn.TabIndex = 4;
            this.toBrewBtn.TabStop = false;
            this.toBrewBtn.Click += new System.EventHandler(this.toBrewBtn_Click);
            // 
            // characterBox
            // 
            this.characterBox.BackColor = System.Drawing.Color.Transparent;
            this.characterBox.Location = new System.Drawing.Point(568, 107);
            this.characterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(560, 433);
            this.characterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.characterBox.TabIndex = 5;
            this.characterBox.TabStop = false;
            // 
            // customerArriveTimer
            // 
            this.customerArriveTimer.Interval = 5000;
            this.customerArriveTimer.Tick += new System.EventHandler(this.customerArriveTimer_Tick);
            // 
            // DialogueTimer
            // 
            this.DialogueTimer.Interval = 7000;
            this.DialogueTimer.Tick += new System.EventHandler(this.DialogueTimer_Tick);
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.Location = new System.Drawing.Point(88, 137);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(340, 98);
            this.acceptBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.acceptBtn.TabIndex = 7;
            this.acceptBtn.TabStop = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // declineBtn
            // 
            this.declineBtn.BackColor = System.Drawing.Color.Transparent;
            this.declineBtn.Image = ((System.Drawing.Image)(resources.GetObject("declineBtn.Image")));
            this.declineBtn.Location = new System.Drawing.Point(88, 286);
            this.declineBtn.Margin = new System.Windows.Forms.Padding(4);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(340, 98);
            this.declineBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.declineBtn.TabIndex = 8;
            this.declineBtn.TabStop = false;
            this.declineBtn.Click += new System.EventHandler(this.declineBtn_Click);
            // 
            // selectedPotionBox
            // 
            this.selectedPotionBox.BackColor = System.Drawing.Color.Transparent;
            this.selectedPotionBox.Location = new System.Drawing.Point(311, 512);
            this.selectedPotionBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectedPotionBox.Name = "selectedPotionBox";
            this.selectedPotionBox.Size = new System.Drawing.Size(184, 175);
            this.selectedPotionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedPotionBox.TabIndex = 9;
            this.selectedPotionBox.TabStop = false;
            this.selectedPotionBox.Visible = false;
            // 
            // dialogueBox1
            // 
            this.dialogueBox1.BackColor = System.Drawing.Color.Transparent;
            this.dialogueBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dialogueBox1.BackgroundImage")));
            this.dialogueBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dialogueBox1.Location = new System.Drawing.Point(943, 107);
            this.dialogueBox1.Margin = new System.Windows.Forms.Padding(5);
            this.dialogueBox1.Name = "dialogueBox1";
            this.dialogueBox1.Size = new System.Drawing.Size(637, 290);
            this.dialogueBox1.TabIndex = 6;
            // 
            // topHUD1
            // 
            this.topHUD1.BackColor = System.Drawing.Color.Transparent;
            this.topHUD1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHUD1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topHUD1.Location = new System.Drawing.Point(0, 0);
            this.topHUD1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.topHUD1.Name = "topHUD1";
            this.topHUD1.Size = new System.Drawing.Size(1619, 862);
            this.topHUD1.TabIndex = 0;
            this.topHUD1.Load += new System.EventHandler(this.topHUD1_Load);
            // 
            // serveBtn
            // 
            this.serveBtn.BackColor = System.Drawing.Color.Transparent;
            this.serveBtn.Image = ((System.Drawing.Image)(resources.GetObject("serveBtn.Image")));
            this.serveBtn.Location = new System.Drawing.Point(568, 588);
            this.serveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.serveBtn.Name = "serveBtn";
            this.serveBtn.Size = new System.Drawing.Size(340, 98);
            this.serveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serveBtn.TabIndex = 10;
            this.serveBtn.TabStop = false;
            this.serveBtn.Visible = false;
            this.serveBtn.Click += new System.EventHandler(this.serveBtn_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1619, 837);
            this.Controls.Add(this.serveBtn);
            this.Controls.Add(this.selectedPotionBox);
            this.Controls.Add(this.declineBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.dialogueBox1);
            this.Controls.Add(this.characterBox);
            this.Controls.Add(this.toBrewBtn);
            this.Controls.Add(this.toUpgradeBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.topHUD1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toUpgradeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toBrewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declineBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPotionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serveBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private topHUD topHUD1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.PictureBox toUpgradeBtn;
        private System.Windows.Forms.PictureBox toBrewBtn;
        private System.Windows.Forms.PictureBox characterBox;
        private System.Windows.Forms.Timer customerArriveTimer;
        private System.Windows.Forms.Timer DialogueTimer;
        private System.Windows.Forms.PictureBox acceptBtn;
        private System.Windows.Forms.PictureBox declineBtn;
        private DialogueBox dialogueBox1;
        private System.Windows.Forms.PictureBox selectedPotionBox;
        private System.Windows.Forms.PictureBox serveBtn;
    }
}