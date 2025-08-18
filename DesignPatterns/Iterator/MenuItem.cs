namespace DesignPatterns.Iterator
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool OneDayJob { get; set; }
        public double Price { get; set; }

        public MenuItem(string name,
            string description,
            bool oneDayJob,
            double price)
        {
            Name = name;
            Description = description;
            OneDayJob = oneDayJob;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine("  " + Name);
            if (OneDayJob)
            {
                Console.WriteLine(1);
            }
            Console.WriteLine(", " + Price);
            Console.WriteLine("    --" + Description);
        }
    }
}
