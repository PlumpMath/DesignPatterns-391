using System;

namespace State.States
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public int Dispense()
        {
            Console.WriteLine("Gumball machine is empty!");
            return 0;
        }

        public bool TurnCrank()
        {
            Console.WriteLine("Gumball machine is empty!");
            return false;
        }

        public bool InsertQuarter()
        {
            Console.WriteLine("Gumball machine is empty!");
            return false;
        }

        public bool EjectQuarter()
        {
            Console.WriteLine("Gumball machine is empty!");
            return false;
        }
    }
}