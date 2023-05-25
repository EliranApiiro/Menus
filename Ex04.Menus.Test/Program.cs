using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            startTest();
        }

        private static void startTest()
        {
            Delegates.MainMenu mainMenu = new MainMenu("Delegates Main Menu");
            fillDelegatesMenu(mainMenu);
            mainMenu.Show();
        }

        private static void fillDelegatesMenu(Delegates.MainMenu i_MainMenu)
        {
            Delegates.MenuItem menuItemOne = new MenuItem(1,"Show Date/Time");
            Delegates.MenuItem menuItemTwo = new MenuItem(2,"Version and Spaces");
            Delegates.ActionItem subMenuOneOptionOne = new ActionItem(1, "Show Date");
            subMenuOneOptionOne.ItemSelected += showDate;
            Delegates.ActionItem subMenuOneOptionTwo = new ActionItem(2, "Show Time");
            subMenuOneOptionTwo.ItemSelected += showTime;
            Delegates.ActionItem subMenuTwoOptionOne = new ActionItem(1, "Show Version");
            subMenuTwoOptionOne.ItemSelected += showVersion;
            Delegates.ActionItem subMenuTwoOptionTwo = new ActionItem(2, "Count Spaces");
            subMenuTwoOptionTwo.ItemSelected += countSpaces;
            menuItemOne.SubMenu.Items.Add(subMenuOneOptionOne);
            menuItemOne.SubMenu.Items.Add(subMenuOneOptionTwo);
            menuItemTwo.SubMenu.Items.Add(subMenuTwoOptionOne);
            menuItemTwo.SubMenu.Items.Add(subMenuTwoOptionTwo);
            i_MainMenu.Items.Add(menuItemOne);
            i_MainMenu.Items.Add(menuItemTwo);
        }
        
        private static void showDate()
        {
            Console.WriteLine("The current date is: {0}.{1}.{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }
        
        private static void showTime()
        {
            Console.WriteLine("The current time is: {0}:{1}:{2}", DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds);
        }
        
        private static void showVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }
        
        private static void countSpaces()
        {
            Console.WriteLine("Enter a sentence and find out how much spaces it contains:");
            string input = Console.ReadLine();
            Console.WriteLine("The number of spaces in your sentence is: {0}", amountOfSpaces(input));
        }

        private static int amountOfSpaces(string i_Input)
        {
            return i_Input.Count(Char.IsWhiteSpace);
        }
    }
}