using System.Collections;

namespace DesignPatterns.Iterator
{
    public class ShopMenu : MenuComponent
    {
        ArrayList MenuComponents = new ArrayList();
        public string Name { get; }
        public string Description { get; }

        public ShopMenu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            MenuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            MenuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)MenuComponents[i]!;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override void Print()
        {
            Console.WriteLine(GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            foreach (MenuComponent menuComponent in MenuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}
