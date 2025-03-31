using FactoryMethod.Product.Abstract;

namespace FactoryMethod.Product;

public class NyCheesePizza : Pizza
{
    public NyCheesePizza()
    {
        Toppings = new List<string>
        {
            "cheese",
            "salad"
        };
        Dough = "ny pizza";

    }
}