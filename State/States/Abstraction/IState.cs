namespace State.States.Abstraction;

public interface IState
{
    void InsertQuater();
    void EjectQuater();
    void TurnCrank();
    void Dispense();
}