namespace DesignPatterns.Command.SimpleRemoteControl.CeilingFan.Commands
{
    public class CeilingFanOffCommand : Command
    {
        CeilingFan fan;
        Speed prevSpeed;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            this.fan = fan;
        }
        public void Execute()
        {
            prevSpeed = fan.GetSpeed();
            fan.Off();
        }

        public void Undo()
        {
            if(prevSpeed == Speed.OFF)
            {
                fan.Off();
            } 
            else if(prevSpeed == Speed.LOW)
            {
                fan.Low();
            }
            else if(prevSpeed == Speed.MEDIUM)
            {
                fan.Medium();
            }
            else if(prevSpeed == Speed.HIGH)
            {
                fan.High();
            }
        }
    }
}
