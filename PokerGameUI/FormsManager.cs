using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokerGameLogic;

namespace PokerGameUI
{
    public class FormsManager
    {
        public static void Run()
        {
            FormGameSettings gameSettings = new FormGameSettings();
            if(gameSettings.ShowDialog() == DialogResult.OK)
            {
                FormPokerGame pokerGame = new FormPokerGame(gameSettings.m_PlayersList);
                pokerGame.ShowDialog();
            }
        }
    }
}
