using System;
using Strategy.Behaviours;
using Strategy.Behaviours.Flying;
using Strategy.Behaviours.Quacking;

namespace Strategy.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _quackBehaviour = new MuteQuack();
            _flyBehaviour = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("I'm decoy duck");
        }
    }
}