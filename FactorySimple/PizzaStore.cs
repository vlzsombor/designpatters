using FactorySimple.Simple;

namespace FactorySimple;

public class PizzaStore
{
    private readonly PizzaFactory _pizzaFactory;

    public PizzaStore(PizzaFactory pizzaFactory)
    {
        _pizzaFactory = pizzaFactory;
    }


    public Pizza OrderPizza(PizzaType pizzaType)
    {
        Pizza pizza = _pizzaFactory.CreatePizza(pizzaType);

        pizza.Prepare();
        pizza.Bake();

        return pizza;
    }
}