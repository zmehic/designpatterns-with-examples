namespace DesignPatterns.Strategy.Consumption
{
    public class NoConsumation : IConsumption
    {
        public void Consume()
        {
            Console.WriteLine("Not consuming any resource");
        }
    }
}
