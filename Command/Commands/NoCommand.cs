using Command.Commands.Abstract;

namespace Command.Commands;

public class NoCommand : ICommand
{
    public void Execute()
    {
    }

    public void Undo()
    {
    }
}