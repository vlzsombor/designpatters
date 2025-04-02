namespace Command.Receiver;

public class Hifi
{
    public int Volume { get; private set; }
    public void TurnOnMusic(int volume = 12)
    {
        Volume = volume;
        Console.WriteLine($"music volume {Volume}");
    }
    
    public void TurnOffMusic()
    {
        Volume = 0;
        Console.WriteLine($"music volume {Volume}");
    }
    
}