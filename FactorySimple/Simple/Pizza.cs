namespace FactorySimple.Simple;


public abstract class Pizza
{
    public abstract string Bake();
    public abstract string Prepare();

    public void CreatePizza()
    {
        Bake();
        Prepare();
    }
    
}