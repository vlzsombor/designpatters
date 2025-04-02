using System.Diagnostics;
using Command.Commands;
using Command.Commands.Abstract;

namespace Command.Invoker;

public class RemoteControl
{
    private ICommand[] onCommands = new ICommand[8];
    private ICommand[] offCommands = new ICommand[8];
    private Stack<ICommand> undoCommand;
    
    public RemoteControl()
    {
        for (int i = 0; i < 8; i++)
        {
            onCommands[i] = new NoCommand();
            offCommands[i] = new NoCommand();
        }

        undoCommand = new Stack<ICommand>();
        undoCommand.Push(new NoCommand());
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        if (slot > 8 || slot < 0)
        {
            return;
        }

        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void Undo() => undoCommand.Pop().Undo();

    public void ExecuteOn(int slot)
    {
        if (slot > 8 || slot < 0)
        {
            return;
        }
        onCommands[slot].Execute();
        undoCommand.Push(onCommands[slot]);
    }
    public void ExecuteOff(int slot)
    {
        if (slot > 8 || slot < 0)
        {
            return;
        }
        offCommands[slot].Execute();
        undoCommand.Push(offCommands[slot]);
    }
}