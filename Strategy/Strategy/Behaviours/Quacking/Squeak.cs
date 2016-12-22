using System;

namespace Strategy.Behaviours.Quacking
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}