using Command2.Command;
using Command2.Command.Abstract;
using Command2.Controller;
using Command2.Devices;

namespace Command2;

class Program
{
    static void Main(string[] args)
    {
        
        var rc = new RemoteController();
        // //rc.SetButton1(Hifi);
        // rc.Button1();
        // //rc.SetButton1(Tv);
        // rc.Button1();

        var tv = new TV();
        Lamp lamp = new Lamp();
        var lampOn = new LampTurnOn(lamp);
        var lampOff = new LampTurnOff(lamp);
        
        
        
        TvTurnOnCommand tvTurnOnCommand = new(tv);
        TvTurnOffCommand tvTurnOffCommand = new(tv);
        LampTurnOn lampTurn = new(lamp);
        
        rc.SetCommandToSlot(0, tvTurnOnCommand, tvTurnOffCommand);
        rc.SetCommandToSlot(1, lampOn, lampOff);

        rc.ExecuteCommanOffSlot(0);
        rc.ExecuteCommanOffSlot(0);
        rc.ExecuteCommanOnSlot(0);
        rc.ExecuteCommanOnSlot(1);
        rc.ExecuteCommanOnSlot(0);
        rc.ExecuteCommanOnSlot(0);
        rc.ExecuteCommanOnSlot(1);
        rc.Undo();
        rc.Undo();
        rc.Undo();
        rc.Undo();
        
        
        Console.WriteLine("Hello, World!");
    }
}

