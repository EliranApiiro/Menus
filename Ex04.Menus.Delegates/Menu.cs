using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public abstract class Menu
    {
        private List<Item> m_Items = new List<Item>();
        private string m_Name;

        public Menu(string i_Name)
        {
            m_Name = i_Name;
        }
        
        public List<Item> Items
        {
            get
            {
                return m_Items;
            }
        }

        public virtual void Show()
        {
            bool isBackOrExit = false;
            while (!isBackOrExit)
            {
                Console.Clear();
                printMenuName();
                printSepartor();
                showItems();
                showBackOrExit();
                printSepartor();
                int input = getValidInput();
                handleInput(input, out isBackOrExit);
            }
        }

        private void printMenuName()
        {
            Console.WriteLine("**{0}**", m_Name);
        }

        private void printSepartor()
        {
            Console.WriteLine("---------------");
        }

        private void showItems()
        {
            foreach (var item in m_Items)
            {
                Console.WriteLine("{0} -> {1}", item.Number, item.Text);
            }
        }
        
        protected abstract void showBackOrExit();

        private int getValidInput()
        {
            bool isValidInput = false;
            int result = 0;

            Console.WriteLine("Please enter your selection: ");
            while (!isValidInput)
            {
                string input = Console.ReadLine();
                try
                {
                    int inputAsInt = int.Parse(input);
                    if (inputAsInt >= 0 && inputAsInt <= m_Items.Count)
                    {
                        isValidInput = true;
                        result = inputAsInt;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }

            return result;
        }

        private void handleInput(int i_SelectionInput, out bool o_IsBackOrExit)
        {
            o_IsBackOrExit = false;
            if (i_SelectionInput == 0)
            {
                o_IsBackOrExit = true;
            }
            else
            {
                if (m_Items[i_SelectionInput - 1] is MenuItem menuItem)
                {
                    menuItem.SubMenu.Show();
                }
                else
                {
                    (m_Items[i_SelectionInput - 1] as ActionItem)?.onSelection();
                    pressAnyKeyToContinue();
                }
            }
        }
        
        private static void pressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}