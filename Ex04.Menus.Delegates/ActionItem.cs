using System;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : Item
    {
        public event Action ItemChosen;
        
        public ActionItem(int i_Number, string i_Text) : base(i_Number, i_Text) {}
        
        public void onChoice()
        {
            ItemChosen?.Invoke();
        }
    }
}