using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGameLogic
{
    public class Player
    {
        public string m_Name { get; }
        public List<Card> m_HandList { get; set; }
        public int m_Money { get; set; }

        public Player(string i_Name)
        {
            m_Name = i_Name;
            m_Money = 0;
            m_HandList = new List<Card>();
        }
        //public string Name
        //{
        //    get
        //    {
        //        return m_Name;
        //    }
        //}

        //public int Money
        //{
        //    get
        //    {
        //        return m_Money;
        //    }
        //    set
        //    {
        //        m_Money = value;
        //    }
        //}
        //public List<Card> HandList
        //{
        //    get
        //    {
        //        return m_HandList;
        //    }
        //    set
        //    {
        //        m_HandList = value;
        //    }
        //}
    }
}
