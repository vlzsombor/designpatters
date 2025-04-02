using Command.Commands.Abstract;
using Command.Receiver;

namespace Command.Commands;

public class HifiOffCommand(Hifi hifi) : ICommand
{
    private int previousVolume;
    
    public void Execute()
    {
        previousVolume = hifi.Volume;
        hifi.TurnOffMusic();
    }

    public void Undo()
    {
        hifi.TurnOnMusic(previousVolume);
    }
}

public class HifiOnCommand(Hifi hifi) : ICommand
{
    private int previousVolume;
    
    public void Execute()
    {
        hifi.TurnOnMusic();
    }

    public void Undo()
    {
        hifi.TurnOffMusic();
    }
}