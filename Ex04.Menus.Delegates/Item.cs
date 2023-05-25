using System;

namespace Ex04.Menus.Delegates
{
    public abstract class Item
    {
        private int m_Number;
        private string m_Text;

        public Item(int i_Number, string i_Text)
        {
            m_Number = i_Number;
            m_Text = i_Text;
        }

        public string Text
        {
            get
            {
                return m_Text;
            }
        }
        
        public int Number
        {
            get
            {
                return m_Number;
            }
        }
    }
}