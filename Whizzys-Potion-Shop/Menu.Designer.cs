namespace Test1
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.saves = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saves
            // 
            this.saves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saves.Image = ((System.Drawing.Image)(resources.GetObject("saves.Image")));
            this.saves.Location = new System.Drawing.Point(810, 250);
            this.saves.Name = "saves";
            this.saves.Size = new System.Drawing.Size(343, 98);
            this.saves.TabIndex = 2;
            this.saves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saves.UseVisualStyleBackColor = true;
            this.saves.Click += new System.EventHandler(this.saves_Click);
            // 
            // settings
            // 
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(810, 366);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(343, 98);
            this.settings.TabIndex = 3;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.Location = new System.Drawing.Point(810, 483);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(343, 98);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // start
            // 
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(810, 131);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(343, 98);
            this.start.TabIndex = 8;
            this.start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1209, 681);
            this.Controls.Add(this.start);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.saves);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saves;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button start;
    }
}

