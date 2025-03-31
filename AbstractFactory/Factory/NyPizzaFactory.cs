using AbstractFactory.Factory.Abstract;
using AbstractFactory.Factory.PizzaStyle;
using AbstractFactory.Factory.PizzaStyle.Abstraction;
using AbstractFactory.Product;
using AbstractFactory.Product.Abstract;

namespace AbstractFactory.Factory;

public class NyPizzaFactory : PizzaFactory
{

    private Style style = new NyStyle();
    public override Pizza CreatePizza(PizzaType pizzaType) => pizzaType switch
    {
        PizzaType.Cheese => new CheesePizza(style),
        PizzaType.Hawaii => new NyHawaiiPizza(style),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, null)
    };



}