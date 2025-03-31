namespace FactorySimple.Simple;


public class CheesePizza : Pizza
{
    public override string Bake()
    {
        var str = "bake the cheese pizza";
        Console.WriteLine(str);
        return str;
    }

    public override string Prepare()
    {
        var str = "prepare the cheese pizza";
        Console.WriteLine(str);
        return str;
        
    }
}


public class HawaiiPizza : Pizza
{
    public override string Bake()
    {
        var str = "bake the Hawaii pizza";
        Console.WriteLine(str);
        return str;
    }

    public override string Prepare()
    {
        var str = "prepare the Hawaii pizza";
        Console.WriteLine(str);
        return str;
        
    }
}