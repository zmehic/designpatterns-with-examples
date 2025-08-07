namespace DesignPatterns.Factory.SimpleFactory
{
    public class Margherita : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {nameof(Margherita)}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {nameof(Margherita)}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {nameof(Margherita)}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {nameof(Margherita)}");
        }
    }
}
