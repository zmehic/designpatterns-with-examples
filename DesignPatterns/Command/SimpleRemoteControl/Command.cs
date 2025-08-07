namespace DesignPatterns.Command.SimpleRemoteControl
{
    public interface Command
    {
        public void Execute();
        public void Undo();
    }
}
