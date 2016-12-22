using System;

namespace Strategy.Behaviours.Flying
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Look, I'm flying!");
        }
    }
}