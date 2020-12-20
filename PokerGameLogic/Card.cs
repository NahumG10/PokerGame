using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGameLogic
{
    public class Card
    {
        public eCardType m_MardType { get; set; }
        public eCardValue m_CardValue { get; set; }

        public Card(eCardType i_CardType, eCardValue i_CardValue)
        {
            m_MardType = i_CardType;
            m_CardValue = i_CardValue;
        }

        //public eCardType CardType
        //{
        //    get
        //    {
        //        return m_MardType;
        //    }
        //}
        //public eCardValue CardValue
        //{
        //    get
        //    {
        //        return m_CardValue;
        //    }
        //}
    }

    public enum eCardType
    {
        Clover,
        Diamond,
        Heart,
        Leaf
    }

    public enum eCardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
