using DesignPatterns.AdapterFacade.Interfaces;

namespace DesignPatterns.AdapterFacade
{
    public class GoldenRetreiver : Dog
    {
        public void Bark()
        {
            Console.WriteLine("Woof woof");
        }

        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
