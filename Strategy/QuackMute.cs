namespace Strategy;

class QuackMute : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("----------------");
    }
}