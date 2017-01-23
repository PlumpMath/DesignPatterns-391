using System;

namespace Adapter.Human
{
    public class Man : IHuman
    {
        public void Speak()
        {
            Console.WriteLine("Hello, I'm a human. A man, to be more precise.");
        }
    }
}