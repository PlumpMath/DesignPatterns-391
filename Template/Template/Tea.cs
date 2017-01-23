using System;

namespace Template
{
    public class Tea : CoffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon to tea");
        }
    }
}