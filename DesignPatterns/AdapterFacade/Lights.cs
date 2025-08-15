namespace DesignPatterns.AdapterFacade
{
    public class Lights
    {
        public void On()
        {
            Console.WriteLine("Lights ON!");
        }

        public void Off()
        {
            Console.WriteLine("Lights OFF!");
        }

        public void Dim()
        {
            Console.WriteLine("Dimming Lights!");
        }
    }
}
