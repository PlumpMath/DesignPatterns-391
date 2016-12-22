using System;
using Strategy.Behaviours;
using Strategy.Behaviours.Flying;
using Strategy.Behaviours.Quacking;

namespace Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehaviour = new NoFly();
            _quackBehaviour = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm rubber duck");
        }
    }
}