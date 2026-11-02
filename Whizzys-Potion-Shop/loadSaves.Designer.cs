namespace Test1
{
    partial class savefiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(savefiles));
            this.backBtn = new System.Windows.Forms.Button();
            this.saveList = new System.Windows.Forms.ListView();
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(894, 581);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(280, 77);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveList
            // 
            this.saveList.BackColor = System.Drawing.Color.LavenderBlush;
            this.saveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerName,
            this.playerDay,
            this.playerMoney});
            this.saveList.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveList.HideSelection = false;
            this.saveList.Location = new System.Drawing.Point(148, 54);
            this.saveList.Name = "saveList";
            this.saveList.Size = new System.Drawing.Size(933, 508);
            this.saveList.TabIndex = 1;
            this.saveList.TileSize = new System.Drawing.Size(168, 30);
            this.saveList.UseCompatibleStateImageBehavior = false;
            this.saveList.View = System.Windows.Forms.View.Details;
            // 
            // playerName
            // 
            this.playerName.Text = "Save File";
            this.playerName.Width = 589;
            // 
            // playerDay
            // 
            this.playerDay.Text = "Day";
            this.playerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerDay.Width = 143;
            // 
            // playerMoney
            // 
            this.playerMoney.Text = "Money";
            this.playerMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerMoney.Width = 197;
            // 
            // savefiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1209, 681);
            this.Controls.Add(this.saveList);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "savefiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListView saveList;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader playerDay;
        private System.Windows.Forms.ColumnHeader playerMoney;
    }
}