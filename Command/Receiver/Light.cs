namespace Command.Receiver;

public class Light
{
    public void TurnOnTheLights()
    {
        Console.WriteLine("Lights on");
    }
    
    public void TurnOffTheLights()
    {
        Console.WriteLine("Lights off");
    }

    public void SetLightDim(int dim)
    {
        Console.WriteLine($"Light set to {dim}");
    }
}