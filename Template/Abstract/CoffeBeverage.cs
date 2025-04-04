namespace Template.Abstract;

public abstract class CoffeBeverage
{



    public void CreateBeverage()
    {
        PrepareBeverage();
        BoilWater();
        if(AddExtraHook())
            AddSugar();
    }

    protected abstract void PrepareBeverage();
    protected abstract void BoilWater();
    protected abstract void AddSugar();

    protected abstract bool AddExtraHook();
}