using Command2.Command.Abstract;
using Command2.Devices;

namespace Command2.Command;

public class TvTurnOnCommand(TV tv) : ICommand
{
    public void Execute()
    {
        tv.TurnOn();
    }

    public void Undo()
    {
        tv.TurnOff();
    }
}