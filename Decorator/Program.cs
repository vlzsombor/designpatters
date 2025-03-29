using Decorator.Decorators;
using Decorator.Decorators.Abstract;

namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Bevarage cappuccino = new Cappuccino();
        Bevarage darkCoffee = new DarkCoffee();

        Console.WriteLine(cappuccino.Cost() + cappuccino.Description);
        cappuccino = new MilkExtra(cappuccino);
        Console.WriteLine(cappuccino.Cost() + cappuccino.Description);
        
        Console.WriteLine(darkCoffee.Cost() + darkCoffee.Description);

        darkCoffee = new MilkExtra(darkCoffee);
        Console.WriteLine(darkCoffee.Cost() + darkCoffee.Description);

    }
}