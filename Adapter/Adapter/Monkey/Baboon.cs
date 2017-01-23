using System;

namespace Adapter.Monkey
{
    public class Baboon : IMonkey
    {
        public void Screech()
        {
            Console.WriteLine("Uba uba uba!");
        }
    }
}