using Command.Commands.Abstract;
using Command.Receiver;

namespace Command.Commands;

public class LightOnCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.TurnOnTheLights();
    }
    public void Undo()
    {
        light.TurnOffTheLights();
    }
}

public class LightOffCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.TurnOffTheLights();
    }

    public void Undo()
    {
        light.TurnOnTheLights();
    }
}