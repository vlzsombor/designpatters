using State.States;
using State.States.Abstraction;

namespace State;

public class Manager
{
    internal readonly IState HAS_QUATER;
    internal readonly IState NO_QUATER;
    internal readonly IState SoldOut;
    internal readonly IState Sold;
    public IState State { get; set; }

    public Manager(int count)
    {
        HAS_QUATER = new HasQuaterState(this);
        NO_QUATER = new NoQuaterState(this);
        SoldOut = new SoldOutState(this);
        Sold = new SoldState(this);

        State = count > 0 ? NO_QUATER : SoldOut;
    }

    public void InsertQuater()
    {
        State.InsertQuater();
    }
    
    
    
}