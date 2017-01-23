using System;

namespace Adapter.Monkey
{
    public class Gorilla : IMonkey
    {
        public void Screech()
        {
            Console.WriteLine("Labas, as Akvile.");
        }
    }
}