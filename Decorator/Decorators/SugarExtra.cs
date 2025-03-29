using Decorator.Decorators.Abstract;

namespace Decorator.Decorators;

public class SugarExtra : IDecoratorExtras
{
    public SugarExtra(Bevarage decorator) : base(decorator)
    {
    }

    public override string Description=> _decorator.Description + " Sugar extra";

    public override int Cost()
    {
        return _decorator.Cost() + 20;
    }
}