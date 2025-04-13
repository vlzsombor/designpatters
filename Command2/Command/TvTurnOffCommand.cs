using Command2.Command.Abstract;
using Command2.Devices;

namespace Command2.Command;

public class TvTurnOffCommand(TV tv) : ICommand
{
    public void Execute()
    {
        tv.TurnOff();
    }

    public void Undo()
    {
        tv.TurnOn();
    }
}