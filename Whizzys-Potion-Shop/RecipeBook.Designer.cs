namespace Whizzys_Potion_Shop
{
    partial class RecipeBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeBook));
            this.turnLeft = new System.Windows.Forms.PictureBox();
            this.turnRight = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.turnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // turnLeft
            // 
            this.turnLeft.BackColor = System.Drawing.Color.Transparent;
            this.turnLeft.Image = ((System.Drawing.Image)(resources.GetObject("turnLeft.Image")));
            this.turnLeft.Location = new System.Drawing.Point(1, 405);
            this.turnLeft.Name = "turnLeft";
            this.turnLeft.Size = new System.Drawing.Size(50, 53);
            this.turnLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.turnLeft.TabIndex = 2;
            this.turnLeft.TabStop = false;
            this.turnLeft.Click += new System.EventHandler(this.turnLeft_Click);
            // 
            // turnRight
            // 
            this.turnRight.BackColor = System.Drawing.Color.Transparent;
            this.turnRight.Image = ((System.Drawing.Image)(resources.GetObject("turnRight.Image")));
            this.turnRight.Location = new System.Drawing.Point(328, 404);
            this.turnRight.Name = "turnRight";
            this.turnRight.Size = new System.Drawing.Size(50, 53);
            this.turnRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.turnRight.TabIndex = 1;
            this.turnRight.TabStop = false;
            this.turnRight.Click += new System.EventHandler(this.turnRight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RecipeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 457);
            this.Controls.Add(this.turnLeft);
            this.Controls.Add(this.turnRight);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeBook";
            this.Text = "RecipeBook";
            ((System.ComponentModel.ISupportInitialize)(this.turnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox turnRight;
        private System.Windows.Forms.PictureBox turnLeft;
    }
}