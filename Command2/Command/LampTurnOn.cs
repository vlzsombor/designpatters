using Command2.Command.Abstract;
using Command2.Devices;

namespace Command2.Command;

public class LampTurnOn : ICommand
{
    private Lamp lamp;
    
    public LampTurnOn(Lamp lamp)
    {
        this.lamp = lamp;
    }
    
    public void Execute()
    {
        lamp.TurnOn();
    }

    public void Undo()
    {
        lamp.TurnOff();
    }
}
public class LampTurnOff : ICommand
{
    private Lamp lamp;
    
    public LampTurnOff(Lamp lamp)
    {
        this.lamp = lamp;
    }
    
    public void Execute()
    {
        lamp.TurnOff();
    }

    public void Undo()
    {
        lamp.TurnOn();
    }
}