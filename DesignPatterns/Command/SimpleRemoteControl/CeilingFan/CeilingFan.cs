namespace DesignPatterns.Command.SimpleRemoteControl.CeilingFan
{
    public enum Speed
    {
        OFF,
        LOW,
        MEDIUM,
        HIGH
    }
    public class CeilingFan
    {
        private Speed speed;
        public void Off()
        {
            Console.WriteLine("Ceiling Fan Off!");
            speed = Speed.OFF;
        }

        public void Low()
        {
            Console.WriteLine("Ceiling Fan Low!");
            speed = Speed.LOW;
        }

        public void Medium()
        {
            Console.WriteLine("Ceiling Fan Medium!");
            speed = Speed.MEDIUM;
        }

        public void High()
        {
            Console.WriteLine("Ceiling Fan High!");
            speed = Speed.HIGH;
        }

        public Speed GetSpeed()
        {
            return speed;
        }
    }
}
