namespace Test1
{
    partial class orderSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderSlip));
            this.orderQty = new System.Windows.Forms.Label();
            this.ptnName = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderQty
            // 
            this.orderQty.AutoSize = true;
            this.orderQty.BackColor = System.Drawing.Color.Transparent;
            this.orderQty.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderQty.ForeColor = System.Drawing.Color.Black;
            this.orderQty.Location = new System.Drawing.Point(32, 17);
            this.orderQty.Name = "orderQty";
            this.orderQty.Size = new System.Drawing.Size(40, 26);
            this.orderQty.TabIndex = 0;
            this.orderQty.Text = "Qty";
            // 
            // ptnName
            // 
            this.ptnName.AutoSize = true;
            this.ptnName.BackColor = System.Drawing.Color.Transparent;
            this.ptnName.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnName.ForeColor = System.Drawing.Color.Black;
            this.ptnName.Location = new System.Drawing.Point(111, 18);
            this.ptnName.Name = "ptnName";
            this.ptnName.Size = new System.Drawing.Size(58, 26);
            this.ptnName.TabIndex = 1;
            this.ptnName.Text = "Order";
            // 
            // orderList
            // 
            this.orderList.BackColor = System.Drawing.Color.Transparent;
            this.orderList.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderList.Location = new System.Drawing.Point(27, 55);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(166, 163);
            this.orderList.TabIndex = 2;
            this.orderList.Text = "x1        Stamina Potion\r\n";
            // 
            // orderSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.ptnName);
            this.Controls.Add(this.orderQty);
            this.Name = "orderSlip";
            this.Size = new System.Drawing.Size(208, 238);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderQty;
        private System.Windows.Forms.Label ptnName;
        private System.Windows.Forms.Label orderList;
    }
}
