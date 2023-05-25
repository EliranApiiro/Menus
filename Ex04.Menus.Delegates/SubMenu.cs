using System;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : Menu
    {
        public SubMenu(string i_Name) : base(i_Name) { }
        protected override void showBackOrExit()
        {
            Console.WriteLine("0 -> Back");
        }
    }
}