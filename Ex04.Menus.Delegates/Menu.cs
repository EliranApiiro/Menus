using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public abstract class Menu
    {
        protected List<Item> m_Items = new List<Item>();
        protected int i_AmountOfItems = 0;
        protected string m_Name;

        public Menu(string i_Name)
        {
            m_Name = i_Name;
        }

        public virtual void Show()
        {
            bool isStop = false;
            while (!isStop)
            {
                Console.Clear();
                printMenuName();
                printSepartor();
                showItems();
                showBackOrExit();
                printSepartor();
                int input = getValidInput();
                handleInput(input, out isStop);
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
                Console.WriteLine("{0} --> {1}.", item.Number, item.Text);
            }
        }

        protected abstract void showBackOrExit();

        private int getValidInput()
        {
            int input;
            return input;
        }
    }
}