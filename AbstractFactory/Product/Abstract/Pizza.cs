using AbstractFactory.Factory.PizzaStyle.Abstraction;

namespace AbstractFactory.Product.Abstract;

public abstract class Pizza
{
    private readonly Style _style;
    public string Name { get; set; }
    public string Dough { get; set; }
    public List<string> Toppings { get; set; }


    public Pizza(Style style)
    {
        _style = style;
        Toppings = style.Toppings;
        Dough = style.Dough;
    }

    
    public virtual void Bake()
    {
        Console.WriteLine("Bake a pizza");
    }
    
    public virtual void Prepare()
    {
        Console.WriteLine("Toppings:");
        Toppings.ForEach(Console.WriteLine);
        Console.WriteLine(nameof(Dough) + " " + Dough);
        Console.WriteLine("Prepare a pizza");
    }
    
}