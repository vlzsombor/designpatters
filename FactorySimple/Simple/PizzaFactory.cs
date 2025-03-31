namespace FactorySimple.Simple;

public class PizzaFactory
{

    public Pizza CreatePizza(PizzaType pizzaType)
    {
        switch (pizzaType)
        {
            case PizzaType.Cheese:
                return new CheesePizza();
            case PizzaType.Hawaii:
                return new HawaiiPizza();
            default:
                throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, null);
        }
    }
    
}