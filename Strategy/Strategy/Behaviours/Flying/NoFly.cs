using System;

namespace Strategy.Behaviours.Flying
{
    public class NoFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I ain't flyin' nowhere!");
        }
    }
}