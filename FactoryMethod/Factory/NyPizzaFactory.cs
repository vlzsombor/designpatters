using FactoryMethod.Factory.Abstract.Abstract;
using FactoryMethod.Product;
using FactoryMethod.Product.Abstract;

namespace FactoryMethod.Factory.Abstract;

public class NyPizzaFactory : PizzaFactory
{
    
    public override Pizza CreatePizza(PizzaType pizzaType) => pizzaType switch
    {
        PizzaType.Cheese => new NyCheesePizza(),
        PizzaType.Hawaii => new NyHawaiiPizza(),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, null)
    };



}