using Decorator.Decorators.Abstract;

namespace Decorator.Decorators;

public class DarkCoffee : Bevarage
{
    public override string Description => "I am a dark coffee :)))";

    public override int Cost()
    {
        return 10;
    }
}