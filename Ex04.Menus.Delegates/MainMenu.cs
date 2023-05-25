using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_Name) : base(i_Name) { }
        protected override void showBackOrExit()
        {
            Console.WriteLine("0 -> Exit");
        }
    }
}