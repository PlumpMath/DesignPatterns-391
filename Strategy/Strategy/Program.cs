using System;
using Strategy.Behaviours.Flying;
using Strategy.Behaviours.Quacking;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            Console.WriteLine("Here goues mallard:\n");
            mallard.Quack();
            mallard.Display();
            mallard.Fly();
            mallard.Swim();
            Console.WriteLine("\n\n\n");

            Duck rubber = new RubberDuck();
            Console.WriteLine("Here goues rubber:\n");
            rubber.Quack();
            rubber.Display();
            rubber.Fly();
            rubber.Swim();
            Console.WriteLine("\n\n\n");

            Duck decoy = new DecoyDuck();
            Console.WriteLine("Here goues decoy:\n");
            decoy.Quack();
            decoy.Display();
            decoy.Fly();
            decoy.Swim();
            Console.WriteLine("\n\n\n");

            decoy.SetFlyBehaviour(new FlyWithWings());
            decoy.SetQuackBehaviour(new Squeak());

            decoy.Quack();
            decoy.Fly();
        }
    }
}
