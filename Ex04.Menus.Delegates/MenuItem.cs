using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : Item
    {
        private SubMenu m_SubMenu;
        
        public MenuItem(int i_Number, string i_Text) : base(i_Number, i_Text) {}
        
        public SubMenu SubMenu
        {
            get
            {
                return m_SubMenu;
            }
            set
            {
                m_SubMenu = value;
            }
        }
    }
}