using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGameLogic
{
    public class GameRunner
    {
        public GameBoard m_GameBoard { get; set; }

        public int m_SmallBlind { get; set; }
        public int m_BigBlind { get; set; }
        public int m_CurrentPlayerIndex { get; set; }
        public int m_SmallBlindIndex { get; set; }
        public int m_BigBlindIndex { get; set; }
        public int m_RaisedAmount { get; set; }


        public GameRunner(List<Player> i_PlayersList)
        {
            m_GameBoard = new GameBoard(i_PlayersList);
            m_SmallBlind = 5;
            m_BigBlind = 10;
            m_SmallBlindIndex = 0;
            m_BigBlindIndex = 1;
            startNewRound();
        }

        public void startNewRound()
        {
            int cardIndex;
            Random randomCardIndex = new Random();

            foreach(Player player in m_GameBoard.m_PlayersList)
            {
                for(int i = 0; i < 2; i++)
                {
                    cardIndex = randomCardIndex.Next(m_GameBoard.m_DeckList.Count);
                    player.m_HandList.Add(m_GameBoard.m_DeckList[cardIndex]);
                    m_GameBoard.m_DeckList.RemoveAt(cardIndex);
                }
            }

            m_GameBoard.m_PlayersList[m_SmallBlindIndex].m_Money -= m_SmallBlind;
            m_GameBoard.m_PlayersList[m_BigBlindIndex].m_Money -= m_BigBlind;
            m_GameBoard.m_MoneyOnBoard += (m_SmallBlind + m_BigBlind);
            m_CurrentPlayerIndex = m_BigBlindIndex;
            MoveTurnToNextPlayer();
            m_RaisedAmount = m_BigBlind;

        }

        public void MoveTurnToNextPlayer()
        {
            m_CurrentPlayerIndex = (m_CurrentPlayerIndex + 1) % m_GameBoard.m_PlayersList.Count;
        }
        
    }
}
