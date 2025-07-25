namespace DesignPatterns.Strategy.Consumption
{
    public class Fuel : IConsumption
    {
        public void Consume()
        {
            Console.WriteLine("Consuming fuel ...");
        }
    }
}
