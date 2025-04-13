using State.States.Abstraction;

namespace State.States;

public class SoldOutState : IState
{

    public SoldOutState(Manager manager)
    {
        
    }
    public void InsertQuater()
    {
        throw new NotImplementedException();
    }

    public void EjectQuater()
    {
        throw new NotImplementedException();
    }

    public void TurnCrank()
    {
        throw new NotImplementedException();
    }

    public void Dispense()
    {
        throw new NotImplementedException();
    }
}