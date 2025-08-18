using System.Collections;

namespace DesignPatterns.Iterator.ConcreteIterators
{
    public class MechanicMenuIterator : Iterator
    {
        ArrayList MenuItems;
        int Position = 0;

        public MechanicMenuIterator(ArrayList menuItems)
        {
            MenuItems = menuItems;
        }
        public bool HasNext()
        {
            return Position < MenuItems.Count;
        }

        public object Next()
        {
            MenuItem menuItem = (MenuItem)MenuItems[Position]!;
            Position++;
            return menuItem;
        }
    }
}
