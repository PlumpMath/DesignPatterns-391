using System;
using State.States;

namespace State
{
    public class GumballMachine
    {
        public IState HasQuarterState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState SoldOutState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        private IState _currentState;
        private int _count;

        public GumballMachine(int gumballs)
        {
            WinnerState = new WinnerState(this);
            SoldState = new SoldState(this);
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            _count = gumballs;
            _currentState = _count > 0 ? NoQuarterState : SoldOutState;
        }

        public bool InsertQuarter()
        {
            return _currentState.InsertQuarter();
        }

        public bool EjectQuarter()
        {
            return _currentState.EjectQuarter();
        }

        public bool TurnCrank()
        {
            _currentState.TurnCrank();
            int count = _currentState.Dispense();
            if (count == 0)
            {
                return false;
            }
            bool result = ReleaseBall(count);

            return result;
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        private bool ReleaseBall(int count)
        {
            Console.WriteLine("A gumball comes rolling your way.");
            if (_count >= count)
            {
                _count -= count;
                return true;
            }
            if (_count == count)
            {
                SetState(SoldOutState);
                return true;
            }
            if (_count < count && _count > 0)
            {
                SetState(SoldOutState);
                Console.WriteLine("Couldn't provide all gumballs.");
                EjectQuarter();
                return false;
            }
            Console.WriteLine("Gumball machine is empty.");
            EjectQuarter();
            return false;
        }
    }
}