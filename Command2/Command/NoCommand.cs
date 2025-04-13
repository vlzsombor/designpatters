using Command2.Command.Abstract;

namespace Command2.Command;

public class NoCommand : ICommand
{
    public void Execute()
    {
    }

    public void Undo()
    {
        
    }
}