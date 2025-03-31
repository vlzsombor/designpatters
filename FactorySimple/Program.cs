using FactorySimple.Simple;

namespace FactorySimple;

class Program
{
    static void Main(string[] args)
    {
        PizzaFactory pizzaFactory = new();
        var pizzaStore = new PizzaStore(pizzaFactory);
        pizzaStore.OrderPizza(PizzaType.Cheese);
        
    }
}