namespace Whizzys_Potion_Shop
{
    public partial class Ingredients_Window
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
            this.cauldron = new System.Windows.Forms.PictureBox();
            this.DragonsBlood = new System.Windows.Forms.PictureBox();
            this.brewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cauldron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragonsBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // cauldron
            // 
            this.cauldron.BackColor = System.Drawing.Color.Transparent;
            this.cauldron.Image = global::Whizzys_Potion_Shop.Properties.Resources.pot_cropped;
            this.cauldron.Location = new System.Drawing.Point(369, 446);
            this.cauldron.Name = "cauldron";
            this.cauldron.Size = new System.Drawing.Size(522, 620);
            this.cauldron.TabIndex = 0;
            this.cauldron.TabStop = false;
            this.cauldron.Click += new System.EventHandler(this.cauldron_Click);
            this.cauldron.DragDrop += new System.Windows.Forms.DragEventHandler(this.cauldron_DragDrop);
            this.cauldron.DragEnter += new System.Windows.Forms.DragEventHandler(this.cauldron_DragEnter);
            // 
            // DragonsBlood
            // 
            this.DragonsBlood.BackColor = System.Drawing.Color.Transparent;
            this.DragonsBlood.BackgroundImage = global::Whizzys_Potion_Shop.Properties.Resources.Dragon_s_Blood;
            this.DragonsBlood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DragonsBlood.Image = global::Whizzys_Potion_Shop.Properties.Resources.Dragon_s_Blood;
            this.DragonsBlood.Location = new System.Drawing.Point(897, 446);
            this.DragonsBlood.Name = "DragonsBlood";
            this.DragonsBlood.Size = new System.Drawing.Size(100, 100);
            this.DragonsBlood.TabIndex = 1;
            this.DragonsBlood.TabStop = false;
            this.DragonsBlood.Tag = "5";
            this.DragonsBlood.Click += new System.EventHandler(this.DragonsBlood_Click);
            this.DragonsBlood.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragonsBlood_MouseDown);
            // 
            // brewButton
            // 
            this.brewButton.BackColor = System.Drawing.Color.Transparent;
            this.brewButton.BackgroundImage = global::Whizzys_Potion_Shop.Properties.Resources.brew_button;
            this.brewButton.Enabled = false;
            this.brewButton.FlatAppearance.BorderSize = 0;
            this.brewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brewButton.Location = new System.Drawing.Point(518, 374);
            this.brewButton.Name = "brewButton";
            this.brewButton.Size = new System.Drawing.Size(233, 66);
            this.brewButton.TabIndex = 2;
            this.brewButton.UseVisualStyleBackColor = false;
            this.brewButton.Visible = false;
            this.brewButton.Click += new System.EventHandler(this.brew_click);
            // 
            // Ingredients_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Whizzys_Potion_Shop.Properties.Resources.mr;
            this.ClientSize = new System.Drawing.Size(1210, 673);
            this.Controls.Add(this.brewButton);
            this.Controls.Add(this.DragonsBlood);
            this.Controls.Add(this.cauldron);
            this.Name = "Ingredients_Window";
            this.Text = "Ingredients_Window";
            this.Load += new System.EventHandler(this.Ingredients_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cauldron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragonsBlood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cauldron;
        private System.Windows.Forms.PictureBox DragonsBlood;
        private System.Windows.Forms.Button brewButton;
    }
}