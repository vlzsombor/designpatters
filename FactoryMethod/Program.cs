using FactoryMethod.Factory.Abstract;
using FactoryMethod.Product;
using FactoryMethod.Product.Abstract;

namespace FactoryMethod;

class Program
{
    public static void Main(string[] args)
    {
        NyPizzaFactory nyPizzaFactory = new NyPizzaFactory();

        nyPizzaFactory.OrderPizza(PizzaType.Cheese);
        nyPizzaFactory.OrderPizza(PizzaType.Hawaii);


    }
}