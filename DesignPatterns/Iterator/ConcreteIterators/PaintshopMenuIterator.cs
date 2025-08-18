namespace DesignPatterns.Iterator.ConcreteIterators
{
    public class PaintshopMenuIterator : Iterator
    {
        MenuItem[] MenuItems;
        int Position = 0;

        public PaintshopMenuIterator(MenuItem[] menuItems)
        {
            MenuItems = menuItems;
        }
        public bool HasNext()
        {
            return Position < MenuItems.Length;
        }

        public object Next()
        {
            MenuItem menuItem = MenuItems[Position];
            Position++;
            return menuItem;
        }
    }
}
