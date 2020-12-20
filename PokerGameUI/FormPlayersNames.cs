using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGameUI
{
    public partial class FormPlayersNames : Form
    {
        public string m_PlayerName { get; set; }
        public FormPlayersNames()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(450,250);
        }

        private void buttonSubmitPlayerName_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TextBoxPlayerName.Text))
            {
                m_PlayerName = TextBoxPlayerName.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Enter the player name");
            }
        }

        private void buttonCancelRegistry_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
