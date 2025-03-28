namespace Strategy;

class RedHeadDuck : Duck
{
    public RedHeadDuck(IQuackable quackable, IFlyable flyable) : base(quackable, flyable)
    {
    }

    public override int Weight() => 43;
}