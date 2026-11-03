namespace Whizzys_Potion_Shop
{
    partial class DialogueBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueBox));
            this.dialogueText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialogueText
            // 
            this.dialogueText.BackColor = System.Drawing.Color.Transparent;
            this.dialogueText.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogueText.Location = new System.Drawing.Point(55, 48);
            this.dialogueText.Name = "dialogueText";
            this.dialogueText.Size = new System.Drawing.Size(328, 159);
            this.dialogueText.TabIndex = 0;
            this.dialogueText.Text = "Test DIalogue";
            this.dialogueText.UseCompatibleTextRendering = true;
            // 
            // DialogueBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.dialogueText);
            this.DoubleBuffered = true;
            this.Name = "DialogueBox";
            this.Size = new System.Drawing.Size(633, 323);
            this.Load += new System.EventHandler(this.DialogueBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dialogueText;
    }
}
