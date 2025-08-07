namespace DesignPatterns.Command.SimpleRemoteControl.Light.Commands
{
    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.On();
        }
    }
}
