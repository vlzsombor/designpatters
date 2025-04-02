namespace Command.Commands.Abstract;

public interface ICommand
{
    void Execute();
    void Undo();
}