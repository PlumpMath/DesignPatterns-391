using System;

namespace Strategy.Behaviours.Quacking
{
    public class SimpleQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("SimpleQuack!");
        }
    }
}