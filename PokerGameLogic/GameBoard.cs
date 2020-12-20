using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGameLogic
{
    public class GameBoard
    {
        public List<Card> m_DeckList { get; set; }
        public List<Card> m_OpenCardsList { get; set; }
        public List<Player> m_PlayersList { get; set; }
        public int m_MoneyOnBoard { get; set; }
        

        public GameBoard(List<Player> i_PlayersList)
        {
            m_DeckList = new List<Card>();
            m_PlayersList = i_PlayersList;
            initializeDeck();
            initializePlayersMoney();
            m_MoneyOnBoard = 0;
            

            //for(int i = 0; i < m_DeckList.Count; i++)
            //{
            //    Console.WriteLine(m_DeckList[i].CardType + " " + m_DeckList[i].CardValue);
            //}
        }

        private void initializeDeck()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 14; j++)
                {
                    m_DeckList.Add(new Card((eCardType)i,(eCardValue)j));
                }
            }
        }

        private void initializePlayersMoney()
        {
            foreach(Player player in m_PlayersList)
            {
                player.m_Money = 400;
            }
        }
    }

    
}
