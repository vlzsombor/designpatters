namespace Command2.Command.Abstract;

public interface ICommand
{
    void Execute();
    void Undo();
}