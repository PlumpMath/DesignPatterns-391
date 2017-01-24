using System;

namespace State.States
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public int Dispense()
        {
            Console.WriteLine("Dispensing gumball!");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            return 1;
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