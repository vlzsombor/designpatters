namespace AbstractFactory.Factory.PizzaStyle.Abstraction;

public interface Style
{

    public List<string> Toppings { get; set; }
    public string Dough { get; set; }
}