using System;

namespace State.States
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public int Dispense()
        {
            Console.WriteLine("Dispensing two gumballs!");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            return 2;
        }

        public bool TurnCrank()
        {
            Console.WriteLine("Wait for your gumball!");
            return false;
        }

        public bool InsertQuarter()
        {
            Console.WriteLine("Wait for your gumball!");
            return false;
        }

        public bool EjectQuarter()
        {
            Console.WriteLine("Wait for your gumball!");
            return false;
        }
    }
}