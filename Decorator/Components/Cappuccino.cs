using Decorator.Decorators.Abstract;

namespace Decorator.Decorators;

public class Cappuccino : Bevarage
{
    public override string Description => "I am cappuccino :'c";
    public override int Cost()
    {
        return 2000;
    }
}