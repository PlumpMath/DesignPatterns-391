using System;

namespace Factory.Ingredients
{
    public class ThickCrustDough : IDough
    {
        public void Use()
        {
            Console.WriteLine("Using thick crust dough");
        }
    }
}