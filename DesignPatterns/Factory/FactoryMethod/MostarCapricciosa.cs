namespace DesignPatterns.Factory.FactoryMethod
{
    public class MostarCapricciosa : IPizza
    {
        public void Bake()
        {
            Console.WriteLine($"Baking {nameof(MostarCapricciosa)}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {nameof(MostarCapricciosa)}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {nameof(MostarCapricciosa)}");
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {nameof(MostarCapricciosa)}");
        }
    }
}
