using System;

namespace Factory.Ingredients
{
    public class MozzarellaCheese : ICheese
    {
        public void Use()
        {
            Console.WriteLine("Using mozzarella cheese");
        }
    }
}