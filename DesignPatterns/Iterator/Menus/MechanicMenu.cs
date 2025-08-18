using DesignPatterns.Iterator.ConcreteIterators;
using System.Collections;

namespace DesignPatterns.Iterator.Menus
{
    public class MechanicMenu : Menu
    {
        ArrayList menuItems;

        public MechanicMenu()
        {
            menuItems = new ArrayList();

            AddItem("Clutch Replacement",
                "Replace clutch with all of the cylinders",
                false,
                670.4);

            AddItem("Engine Replacement",
                "Replace engine and do a service",
                false,
                2670.4);

            AddItem("Small Maintnance Service",
                "Replace oil and filters",
                true,
                70.4);
        }

        private void AddItem(string name,
            string description,
            bool oneDayJob,
            double price)
        {
            MenuItem menuItem = new MenuItem(name, description, oneDayJob, price);
            menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new MechanicMenuIterator(menuItems);
        }
    }
}
