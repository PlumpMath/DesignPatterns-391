using System;

namespace Factory.Ingredients
{
    public class ReggianoCheese : ICheese
    {
        public void Use()
        {
            Console.WriteLine("Using reggiano cheese");
        }
    }
}