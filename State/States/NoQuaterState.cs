using State.States.Abstraction;

namespace State.States;

public class NoQuaterState(Manager manager) : IState
{
    
    public void InsertQuater()
    {
        manager.State = manager.HAS_QUATER;
        Console.WriteLine("Quater is inserted...");
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