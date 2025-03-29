using Decorator.Decorators.Abstract;

namespace Decorator.Decorators;

public class MilkExtra : IDecoratorExtras
{
    public MilkExtra(Bevarage decorator) : base(decorator)
    {
    }

    public override string Description => _decorator.Description +  " Milk extra";
    
    public override int Cost()
    {
        return _decorator.Cost() + 2;
    }
}