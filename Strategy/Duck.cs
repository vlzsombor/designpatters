namespace Strategy;

abstract class Duck
{
    public IQuackable Quackable { get; set; }
    public IFlyable Flyable { get; set; }
    public abstract int Weight();

    public Duck(IQuackable quackable, IFlyable flyable)
    {
        Quackable = quackable;
        Flyable = flyable;
    }
    
    public void PerformQuack()
    {
        Quackable.Quack();
    }

    public void PerformFly()
    {
        Flyable.Fly();
    }
    
}