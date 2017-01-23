using System;

namespace Adapter.Monkey
{
    public class Chimpanzee : IMonkey
    {
        public void Screech()
        {
            Console.WriteLine("AAAAHHHHHH!");
        }
    }
}