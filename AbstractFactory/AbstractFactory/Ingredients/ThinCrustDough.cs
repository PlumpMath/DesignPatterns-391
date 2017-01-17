using System;

namespace Factory.Ingredients
{
    public class ThinCrustDough : IDough
    {
        public void Use()
        {
            Console.WriteLine("Using thin crust dough");
        }
    }
}