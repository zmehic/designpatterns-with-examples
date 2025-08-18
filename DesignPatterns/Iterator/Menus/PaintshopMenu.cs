using DesignPatterns.Iterator.ConcreteIterators;

namespace DesignPatterns.Iterator.Menus
{
    public class PaintshopMenu : Menu
    {
        const int MAX_ITEMS = 3;
        int NumberOfItems = 0;
        MenuItem[] menuItems;

        public PaintshopMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Bumber Painting",
                "Paint only front and back bumpers",
                true,
                250.4);

            AddItem("Full Car Paintjob",
                "Painting the whole car",
                false,
                5000);

            AddItem("Small Scratch Paint",
                "Fixing a small scratch up to 5 cm in size",
                true,
                50);
        }

        private void AddItem(string name,
            string description,
            bool oneDayJob,
            double price)
        {
            MenuItem menuItem = new MenuItem(name, description, oneDayJob, price);
            if(NumberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Unable to add new item, the menu is full!");
            } 
            else
            {
                menuItems[NumberOfItems] = menuItem;
                NumberOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new PaintshopMenuIterator(menuItems);
        }
    }
}
