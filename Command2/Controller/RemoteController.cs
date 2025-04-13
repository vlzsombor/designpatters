using Command2.Command;
using Command2.Command.Abstract;
using Command2.Devices;

namespace Command2.Controller;

public class RemoteController
{
    //singleton
    private ICommand[] TurnOnCommands = new ICommand[8];
    private ICommand[] TurnOffCommands = new ICommand[8];
    
    private Stack<ICommand> undoCommands = new Stack<ICommand>();
    
    public void SetCommandToSlot(int index, ICommand turnOn, ICommand turnOff)
    {
        
        if (index < 0 || index >= TurnOnCommands.Length)
        {
            return;
        }
        TurnOnCommands[index] = turnOn;
        TurnOffCommands[index] = turnOff;
    }
    public void ExecuteCommanOnSlot(int index)
    {
        TurnOnCommands[index].Execute();
        undoCommands.Push(TurnOnCommands[index]);
    }
    public void ExecuteCommanOffSlot(int index)
    {
        TurnOffCommands[index].Execute();
        undoCommands.Push(TurnOnCommands[index]);
    }
    public void Undo()
    {
        undoCommands.Pop().Undo();
    }
    
}