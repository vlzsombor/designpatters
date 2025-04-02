using Command.Commands;
using Command.Invoker;
using Command.Receiver;

namespace Command;

class Program
{
    public static void Main(string[] args)
    {
        var remoteControl = new RemoteControl();
        var light = new Light();
        var hifi = new Hifi();
        var lightOnCommand = new LightOnCommand(light);
        var lightOffCommand = new LightOffCommand(light);
        var hOffCommand = new HifiOffCommand(hifi);
        var hOnCommand = new HifiOnCommand(hifi);
        remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
        remoteControl.SetCommand(1, hOnCommand, hOffCommand);
        
        remoteControl.ExecuteOn(0);
        remoteControl.ExecuteOn(0);
        remoteControl.ExecuteOff(0);
        remoteControl.ExecuteOn(0);
        remoteControl.ExecuteOn(1);
        remoteControl.ExecuteOff(1);
        
        
        remoteControl.Undo();
        remoteControl.Undo();
        remoteControl.Undo();
        
        
        Console.WriteLine("Hello, World!");
    }
}