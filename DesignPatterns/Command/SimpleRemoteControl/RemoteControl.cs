namespace DesignPatterns.Command.SimpleRemoteControl
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;
        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();

            for(int i = 0; i < 7; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
            undoCommand = new NoCommand();
        }

        public void SetCommand(int slot, Command onCommand, Command ofCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = ofCommand;
        }

        public void OnButtonPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButoonPushed()
        {
            undoCommand.Undo();
        }
    }
}
