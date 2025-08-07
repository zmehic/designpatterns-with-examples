namespace DesignPatterns.Factory.FactoryMethod
{
    public class MostarMargherita : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {nameof(MostarMargherita)}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {nameof(MostarMargherita)}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {nameof(MostarMargherita)}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {nameof(MostarMargherita)}");
        }
    }
}
