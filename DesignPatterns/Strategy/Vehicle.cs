using DesignPatterns.Strategy.Consumption;
using DesignPatterns.Strategy.Sounding;

namespace DesignPatterns.Strategy
{
    public abstract class Vehicle
    {
        public IConsumption consumption { get; set; }
        public ISounding sounding { get; set; }

        public Vehicle() { }

        public abstract void Color();

        public void CheckConsumption()
        {
            consumption.Consume();
        }

        public void CheckSounding()
        {
            sounding.Sound();
        }

        public static void Move()
        {
            Console.WriteLine("Move...");
        }
    }
}
