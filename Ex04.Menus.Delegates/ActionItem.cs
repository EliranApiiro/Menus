using System;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : Item
    {
        public event Action ItemSelected;
        
        public ActionItem(int i_Number, string i_Text) : base(i_Number, i_Text) {}
        
        public void onSelection()
        {
            ItemSelected?.Invoke();
        }
    }
}