using AbstractFactory.Factory.PizzaStyle.Abstraction;

namespace AbstractFactory.Factory.PizzaStyle;

public class NyStyle : Style
{

    public List<string> Toppings { get; set; } =
    [
        "Nystyle topping1",
        "Ny style topping2"
    ];

    public string Dough { get; set; } = "thin dough";
}