using AbstractFactory.Factory.PizzaStyle.Abstraction;
using AbstractFactory.Product.Abstract;

namespace AbstractFactory.Product;

public class CheesePizza : Pizza
{
    public CheesePizza(Style style) : base(style)
    {
    }

    public override void Bake()
    {
        Console.WriteLine("cheese pizza specific");
        base.Bake();
    }
}