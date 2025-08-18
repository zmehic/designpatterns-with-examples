using System.Collections;

namespace DesignPatterns.Iterator.ConcreteIterators
{
    public class MenuIterator
    {
        ArrayList Menus;
        int Position = 0;

        public MenuIterator(ArrayList menus)
        {
            Menus = menus;
        }
        public bool HasNext()
        {
            return Position < Menus.Count;
        }

        public object Next()
        {
            MenuItem menuItem = (MenuItem)Menus[Position]!;
            Position++;
            return menuItem;
        }
    }
}
