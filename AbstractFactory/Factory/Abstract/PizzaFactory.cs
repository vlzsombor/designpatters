using AbstractFactory.Product.Abstract;

namespace AbstractFactory.Factory.Abstract;

public abstract class PizzaFactory
{
    public abstract Pizza CreatePizza(PizzaType pizzaType);
    public Pizza OrderPizza(PizzaType pizzaType)
    {
        Pizza pizza = CreatePizza(pizzaType);
        
        pizza.Prepare();
        pizza.Bake();
        return pizza;
    }
}