using FactoryMethod.Product.Abstract;

namespace FactoryMethod.Product;

public class NyHawaiiPizza : Pizza
{
    
    public NyHawaiiPizza()
    {
        Toppings = new List<string>
        {
            "pinapple",
            "hawaiii"
        };
        Dough = "ny pizza";

    }
    
    public override void Bake()
    {
        Console.WriteLine("NyHawaiiPizza specific things");
        base.Bake();
    }
}