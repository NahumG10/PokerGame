using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokerGameLogic;
using MessageBox = System.Windows.Forms.MessageBox;

namespace PokerGameUI
{
    public partial class FormGameSettings : Form
    {
        public List<Player> m_PlayersList { get; set; }

        public FormGameSettings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 200);
        }

        private bool getPlayersName(int i_NumOfPlayers)
        {
            List<Player> tempList = new List<Player>();

            for(int i = 0; i < i_NumOfPlayers; i++)
            {
                FormPlayersNames currentPlayerName = new FormPlayersNames();
                currentPlayerName.m_LabelFirstPlayerName.Text = string.Format("Enter player number {0}'s Name:", i + 1);
                currentPlayerName.buttonSubmitPlayerName.Text = string.Format("Add player number {0}", i + 1);
                currentPlayerName.ShowDialog();

                if (currentPlayerName.DialogResult == DialogResult.OK)
                {
                    tempList.Add(new Player(currentPlayerName.m_PlayerName));
                }
                else if(currentPlayerName.DialogResult == DialogResult.Cancel)
                {
                    return false;
                }
            }

            m_PlayersList = tempList;

            return true;
        }

        private void buttonRegisterPlayers_Click(object sender, EventArgs e)
        {
            int numOfPlayers;
            if(int.TryParse(comboBoxNumOfPlayers.Text, out numOfPlayers))
            {
                if(getPlayersName(numOfPlayers))
                {
                    listViewPlayersNames.Clear();
                    listViewPlayersNames.Height = numOfPlayers * 25;
                    displayPlayersNames();
                }
            }
            else
            {
                MessageBox.Show("Please choose the number of players");
            }
        }

        private void displayPlayersNames()
        {
            int i = 1;
            
            listViewPlayersNames.View = View.List;

            foreach(Player currentPlayer in m_PlayersList)
            {
                
                listViewPlayersNames.Items.Add(string.Format("Player {0}:,{1}",i, currentPlayer.m_Name));
                i++;
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if(listViewPlayersNames.Items.Count == 0)
            {
                MessageBox.Show("Please register the playes");
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
