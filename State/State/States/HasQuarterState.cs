using System;

namespace State.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public int Dispense()
        {
            Console.WriteLine("You need to turn the crank first!");
            return 0;
        }

        public bool TurnCrank()
        {
            Console.WriteLine("Successfully turned crank!");
            bool winner = new Random().Next(0, 9) == 0;
            _gumballMachine.SetState(winner ? _gumballMachine.WinnerState : _gumballMachine.SoldState);
            return true;
        }

        public bool InsertQuarter()
        {
            Console.WriteLine("You allready inserted quarter!");
            return false;
        }

        public bool EjectQuarter()
        {
            Console.WriteLine("Ejecting quarter!");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            return true;
        }
    }
}