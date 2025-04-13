namespace State;

class Program
{
    static void Main(string[] args)
    {

        var manager = new Manager(10);
        
        manager.InsertQuater();
        
        Console.WriteLine("Hello, World!");
    }
}