namespace State.States
{
    public interface IState
    {
        int Dispense();
        bool TurnCrank();
        bool InsertQuarter();
        bool EjectQuarter();
    }
}