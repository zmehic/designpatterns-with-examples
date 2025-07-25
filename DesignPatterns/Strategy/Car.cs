using DesignPatterns.Strategy.Consumption;
using DesignPatterns.Strategy.Sounding;

namespace DesignPatterns.Strategy
{
    public class Car : Vehicle
    {
        public Car()
        {
            sounding = new Horn();
            consumption = new Fuel();
        }
        public override void Color()
        {
            Console.WriteLine("Blues");
        }
    }
}
