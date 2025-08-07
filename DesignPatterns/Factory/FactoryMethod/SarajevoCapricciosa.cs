namespace DesignPatterns.Factory.FactoryMethod
{
    public class SarajevoCapricciosa : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {nameof(SarajevoCapricciosa)}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {nameof(SarajevoCapricciosa)}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {nameof(SarajevoCapricciosa)}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {nameof(SarajevoCapricciosa)}");
        }
    }
}
