using System;
using Strategy.Behaviours;
using Strategy.Behaviours.Flying;
using Strategy.Behaviours.Quacking;

namespace Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehaviour = new FlyWithWings();
            _quackBehaviour = new SimpleQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm mallard duck");
        }
    }
}