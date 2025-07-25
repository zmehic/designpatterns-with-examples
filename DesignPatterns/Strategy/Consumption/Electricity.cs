namespace DesignPatterns.Strategy.Consumption
{
    public class Electricity : IConsumption
    {
        public void Consume()
        {
            Console.WriteLine("Consuming electricity ...");
        }
    }
}
