using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokerGameLogic;

namespace PokerGameUI
{
    public partial class FormPokerGame : Form
    {
        public GameRunner m_GameRunner { get; set; }

        private Button[] m_ButtonArray { get; set; }

        private Label[] m_MoneyLabel { get; set; }

        private List<Image> m_ImagesList;
        public FormPokerGame(List<Player> i_PlayersList)
        {
            m_GameRunner = new GameRunner(i_PlayersList);
            m_ButtonArray = new Button[i_PlayersList.Count];
            m_MoneyLabel = new Label[i_PlayersList.Count];
            initImageList();

            InitializeComponent();
            initButtons();
        }


        private void initImageList()
        {
            var enviroment = System.Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName + "\\cards_png";
            string[] ImagesStringsArray = Directory.GetFiles(projectDirectory);

            List<string> imagesPathsList = ImagesStringsArray.ToList();
            //imagesPathsList.Sort();

            m_ImagesList = new List<Image>();

            foreach(string currImagePath in imagesPathsList)
            {
                m_ImagesList.Add(Image.FromFile(currImagePath));
            }
        }

        private void initButtons()
        {
            int index = 0;
            int left = 20;
            int top = 20;

            foreach (Player currentPlayer in m_GameRunner.m_GameBoard.m_PlayersList)
            {
                m_ButtonArray[index] = new Button();
                m_ButtonArray[index].Text = currentPlayer.m_Name;
                m_ButtonArray[index].Left = left;
                m_ButtonArray[index].Top = top;
                m_ButtonArray[index].Height = 50;
                m_ButtonArray[index].Click += new EventHandler(playerButton_Click);
                m_ButtonArray[index].Tag = index;
                this.Controls.Add(m_ButtonArray[index]);

                m_MoneyLabel[index] = new Label();
                m_MoneyLabel[index].Text = currentPlayer.m_Money.ToString();
                m_MoneyLabel[index].Name = "labelPlayerMoney" + index; 
                m_MoneyLabel[index].Left = left;
                m_MoneyLabel[index].Top = top + 50;
                this.Controls.Add(m_MoneyLabel[index]);

                left += 100;
                index++;
            }

            updateLabels();
        }

        private void updateLabels()
        {
            labelCurrentPlayer.Text = currentPlayer().m_Name;
            labelAmountToEqual.Text = m_GameRunner.m_RaisedAmount.ToString();
            labelMoneyOnBoard.Text = m_GameRunner.m_GameBoard.m_MoneyOnBoard.ToString();
            m_MoneyLabel[m_GameRunner.m_CurrentPlayerIndex].Text = currentPlayer().m_Money.ToString();

            labelCurrentPlayer.Update();
            //labelAmountToEqual.Update();
            labelMoneyOnBoard.Update();
            m_MoneyLabel[m_GameRunner.m_CurrentPlayerIndex].Update();

        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            int playerIndex = Convert.ToInt32((sender as Button).Tag);
            
            eCardValue firstCardValue = m_GameRunner.m_GameBoard.m_PlayersList[playerIndex].m_HandList[0].m_CardValue;
            eCardType firstCardType = m_GameRunner.m_GameBoard.m_PlayersList[playerIndex].m_HandList[0].m_MardType;

            eCardValue secondCardValue = m_GameRunner.m_GameBoard.m_PlayersList[playerIndex].m_HandList[1].m_CardValue;
            eCardType secondCardType = m_GameRunner.m_GameBoard.m_PlayersList[playerIndex].m_HandList[1].m_MardType;

            this.buttonPlayerCard1.BackgroundImage = m_ImagesList[4 * ((int)firstCardValue - 1) + (int)firstCardType];
            this.buttonPlayerCard1.BackgroundImageLayout = ImageLayout.Stretch;

            this.buttonPlayerCard2.BackgroundImage = m_ImagesList[4 * ((int)secondCardValue - 1) + (int)secondCardType];
            this.buttonPlayerCard2.BackgroundImageLayout = ImageLayout.Stretch;


            //MessageBox.Show(String.Format("type: {0}, value: {1} {2}type: {3}, value: {4}",
            //firstCardType,firstCardValue, Environment.NewLine, secondCardType, secondCardValue));
        }

        private Player currentPlayer()
        {
            return m_GameRunner.m_GameBoard.m_PlayersList[m_GameRunner.m_CurrentPlayerIndex];
        }

        private void buttonMakeEqual_Click(object sender, EventArgs e)
        {
            if(currentPlayer().m_Money >= m_GameRunner.m_RaisedAmount)
            {
                currentPlayer().m_Money -= m_GameRunner.m_RaisedAmount;
                m_GameRunner.m_GameBoard.m_MoneyOnBoard += m_GameRunner.m_RaisedAmount;
                updateLabels();
                m_GameRunner.MoveTurnToNextPlayer();
                updateLabels();
            }
            else
            {
                MessageBox.Show("Not enough money case");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
