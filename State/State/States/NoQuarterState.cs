using System;

namespace State.States
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public int Dispense()
        {
            Console.WriteLine("You need to insert quarter first!");
            return 0;
        }

        public bool TurnCrank()
        {
            Console.WriteLine("You need to insert quarter first!");
            return false;
        }

        public bool InsertQuarter()
        {
            Console.WriteLine("Received quarter!");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
            return true;
        }

        public bool EjectQuarter()
        {
            Console.WriteLine("You need to insert quarter first!");
            return false;
        }
    }
}