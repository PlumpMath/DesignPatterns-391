using System;

namespace Strategy.Behaviours.Quacking
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("***");
        }
    }
}