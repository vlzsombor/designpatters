using Template.Abstract;

namespace Template;

public class Tea(bool addSugar) : CoffeBeverage
{

    protected override void PrepareBeverage()
    {
        Console.WriteLine("tea prepare beverage");
    }

    protected override void BoilWater()
    {
        Console.WriteLine("tea hot water");
    }

    protected override void AddSugar()
    {
        Console.WriteLine("tea some sugar");
    }

    protected override bool AddExtraHook() => addSugar;
}