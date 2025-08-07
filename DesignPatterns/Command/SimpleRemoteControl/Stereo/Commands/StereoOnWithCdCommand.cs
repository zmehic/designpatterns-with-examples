namespace DesignPatterns.Command.SimpleRemoteControl.Stereo.Commands
{
    public class StereoOnWithCdCommand : Command
    {
        Stereo stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.CdSet();
            stereo.SetVolume(22);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
