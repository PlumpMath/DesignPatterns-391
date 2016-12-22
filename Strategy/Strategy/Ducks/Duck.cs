using System;
using Strategy.Behaviours;
using Strategy.Behaviours.Flying;
using Strategy.Behaviours.Quacking;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }

        public abstract void Display();
    }
}