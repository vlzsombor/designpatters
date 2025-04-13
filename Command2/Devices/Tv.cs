namespace Command2.Devices;

public class TV
{
    public void TurnOn()
    {
        Console.WriteLine("TV Turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV Turn off");
    }
}

public class Lamp
{
    public void TurnOn()
    {
        Console.WriteLine("Lamp Turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Lamp Turn off");
    }
}
class Hifi
{
    private int Volume { get; set; }
    public void TurnOn(int volume = 12)
    {
        this.Volume = volume;
        Console.WriteLine("Hifi Turn on");
    }
    public void TurnOff()
    {
        Volume = 0;
        Console.WriteLine("Hifi Turn off");
    }
}