namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        Duck duck = new RedHeadDuck(new QuackClassic(), new Flyable());
        
        Console.WriteLine("Hello, World!");
    }
}