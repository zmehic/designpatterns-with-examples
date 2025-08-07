namespace DesignPatterns.Command.SimpleRemoteControl.Stereo
{
    public class Stereo
    {
        private int volume;
        public void On()
        {
            Console.WriteLine("Stereo on!");
        }

        public void Off()
        {
            Console.WriteLine("Stereo off!");
        }

        public void CdSet()
        {
            Console.WriteLine("Setting CD!");
        }

        public void DvdSet()
        {
            Console.WriteLine("Setting DVD!");
        }

        public void RadioSet()
        {
            Console.WriteLine("Setting Radio!");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Setting Volume");
            this.volume = volume; 
        }
    }
}
