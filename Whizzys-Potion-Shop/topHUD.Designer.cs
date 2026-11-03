namespace Whizzys_Potion_Shop
{
    partial class topHUD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.time = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Lavender;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.time.Location = new System.Drawing.Point(125, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(136, 35);
            this.time.TabIndex = 0;
            this.time.Text = "12 : 00 AM";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.BackColor = System.Drawing.Color.Lavender;
            this.day.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.day.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.day.Location = new System.Drawing.Point(10, 9);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(94, 35);
            this.day.TabIndex = 1;
            this.day.Text = "Monday";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.BackColor = System.Drawing.Color.Lavender;
            this.coins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coins.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.coins.Location = new System.Drawing.Point(1074, 9);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(83, 35);
            this.coins.TabIndex = 2;
            this.coins.Text = "0 Gold";
            // 
            // topHUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.coins);
            this.Controls.Add(this.day);
            this.Controls.Add(this.time);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "topHUD";
            this.Size = new System.Drawing.Size(1200, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label coins;
    }
}
