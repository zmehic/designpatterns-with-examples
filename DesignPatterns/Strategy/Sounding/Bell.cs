namespace DesignPatterns.Strategy.Sounding
{
    public class Bell : ISounding
    {
        public void Sound()
        {
            Console.WriteLine("Ding ding");
        }
    }
}
