using DesignPatterns.Iterator.Menus;
using System.Collections;

namespace DesignPatterns.Iterator
{
    public class Webshop
    {
        MenuComponent AllMenus;

        public Webshop(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }

        public void PrintMenu()
        {
            AllMenus.Print();
        }

        //private void PrintMenu(Iterator iterator)
        //{
        //    while (iterator.HasNext())
        //    {
        //        MenuItem menuItem = (MenuItem)iterator.Next();
        //        Console.WriteLine(menuItem.Name);
        //        Console.WriteLine(menuItem.Description);
        //        Console.WriteLine(menuItem.OneDayJob == true ? "One day job!" : "Multi day job!");
        //        Console.WriteLine(menuItem.Price);
        //    }
        //}
    }
}
