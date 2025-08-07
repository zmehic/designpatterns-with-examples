namespace DesignPatterns.Command.SimpleRemoteControl.CeilingFan.Commands
{
    public class CeilingFanHighCommand : Command
    {
        CeilingFan fan;
        Speed prevSpeed;

        public CeilingFanHighCommand(CeilingFan fan)
        {
            this.fan = fan;
        }
        public void Execute()
        {
            prevSpeed = fan.GetSpeed();
            fan.High();
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
