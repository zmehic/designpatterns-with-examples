namespace DesignPatterns.Factory.FactoryMethod
{
    public class SarajevoMargherita : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {nameof(SarajevoMargherita)}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {nameof(SarajevoMargherita)}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {nameof(SarajevoMargherita)}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {nameof(SarajevoMargherita)}");
        }
    }
}
