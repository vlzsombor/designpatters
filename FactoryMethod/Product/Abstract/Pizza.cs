namespace FactoryMethod.Product.Abstract;

public abstract class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public List<string> Toppings { get; set; }

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