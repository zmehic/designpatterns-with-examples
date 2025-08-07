namespace DesignPatterns.Command.SimpleRemoteControl
{
    public class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl() { }

        public void SetCommand(Command command) { slot = command; }
        public void ButtonPress()
        {
            slot.Execute();
        }
    }
}
