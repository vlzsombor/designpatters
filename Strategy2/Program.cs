using System.Diagnostics;

namespace Strategy2;

class Program
{
    static void Main(string[] args)
    {

        Duck kurcaKacsa = new KurcaKacsa(new QuackNormal(), new KicsiFly());
        Duck faKacsa = new Fakacsa(new NoQuack(), new NoFly());
        kurcaKacsa.PerformFly();
        faKacsa.PerformFly();
        faKacsa.PerformFly();
        kurcaKacsa.PerformQuack();
        faKacsa.PerformQuack();
        Console.WriteLine("New quack");
        faKacsa.PerformQuack(); /// 
        Console.WriteLine("Hello, World!");
    }
}



interface IQuackable
{
    void Quack();
}
interface IFlyable
{
    void Fly();
}

class NormalFly : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("normalis fly, felemelked 5 metert 10 percig");
    }
}

class KicsiFly : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("kicsi fly, felemelked 5 metert 1 percig");
    }
}

class NoFly : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("===== nem tudok repulni xd");
    }
}


class QuackNormal : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Quack quack knocking on heaven door");
    }
}
class NoQuack : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("====== <silent>");
    }
}
abstract class Duck
{
    public IQuackable Quack { get; set; }
    public IFlyable Fly { get; set; }
    
    public Duck(IQuackable quack, IFlyable fly)
    {
        Quack = quack;
        Fly = fly;
    }

    public void PerformQuack()
    {
        Quack.Quack();
    }
    
    public void PerformFly()
    {
        Fly.Fly();
    }
}

class RedheadDuck : Duck
{
    public RedheadDuck(IQuackable quack, IFlyable fly) : base(quack, fly)
    {
    }
}

class HaziKacsa :Duck
{
    public HaziKacsa(IQuackable quack, IFlyable fly) : base(quack, fly)
    {
    }
}

class KurcaKacsa :Duck
{
    public KurcaKacsa(IQuackable quack, IFlyable fly) : base(quack, fly)
    {
    }
}
class Fakacsa : Duck
{
    public Fakacsa(IQuackable quack, IFlyable fly) : base(quack, fly)
    {
    }
}