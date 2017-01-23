using System;

namespace Adapter.Human
{
    public class Woman : IHuman
    {
        public void Speak()
        {
            Console.WriteLine("Hello, I'm a human. A woman, to be more precise. And it's my time to be talking finall.......blah blah blah blah blah\nblah blah blah blah....<..>");
        }
    }
}