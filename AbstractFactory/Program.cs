using AbstractFactory.Factory;
using AbstractFactory.Product.Abstract;

namespace AbstractFactory;
class Program
{
    public static void Main(string[] args)
    {

        NyPizzaFactory nyPizzaFactory = new NyPizzaFactory();

        nyPizzaFactory.OrderPizza(PizzaType.Cheese);
        nyPizzaFactory.OrderPizza(PizzaType.Hawaii);


    }
}