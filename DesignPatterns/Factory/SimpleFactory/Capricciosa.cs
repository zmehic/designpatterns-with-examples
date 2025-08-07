namespace DesignPatterns.Factory.SimpleFactory
{
    public class Capricciosa : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {nameof(Capricciosa)}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {nameof(Capricciosa)}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {nameof(Capricciosa)}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {nameof(Capricciosa)}");
        }
    }
}
