using System;

namespace Template
{
    public class Coffee : CoffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk to coffee");
        }
    }
}