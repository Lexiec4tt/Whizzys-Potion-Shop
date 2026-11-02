using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whizzys_Potion_Shop
{
    public partial class DialogueBox : UserControl
    {
        public DialogueBox()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            dialogueText.BackColor = Color.Transparent;
        }

        private void DialogueBox_Load(object sender, EventArgs e)
        {

        }

        public void ShowMessage(string message)
        {
            dialogueText.Text = message;
            this.Visible = true;
            this.BringToFront();
        }

        public void HideMessage()
        {
            this.Visible = false;
        }

    }
}
