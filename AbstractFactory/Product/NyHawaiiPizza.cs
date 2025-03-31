using AbstractFactory.Factory.PizzaStyle.Abstraction;
using AbstractFactory.Product.Abstract;

namespace AbstractFactory.Product;

public class NyHawaiiPizza : Pizza
{
    public NyHawaiiPizza(Style style) : base(style)
    {
        style.Toppings.Add("pinapple");
    }

    public override void Bake()
    {
        Console.WriteLine("NyHawaiiPizza specific things");
        base.Bake();
    }
}