namespace DesignPatterns.Strategy.Sounding
{
    public class Horn : ISounding
    {
        public void Sound()
        {
            Console.WriteLine("Beep Beep");
        }
    }
}
