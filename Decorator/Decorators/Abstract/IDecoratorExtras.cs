namespace Decorator.Decorators.Abstract;

public abstract class IDecoratorExtras : Bevarage
{
    protected readonly Bevarage _decorator;
    public abstract override string Description { get; }

    public IDecoratorExtras(Bevarage decorator)
    {
        _decorator = decorator;
    }
}