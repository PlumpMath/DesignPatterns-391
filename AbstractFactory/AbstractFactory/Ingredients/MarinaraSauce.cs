using System;

namespace Factory.Ingredients
{
    public class MarinaraSauce : ISauce
    {
        public void Use()
        {
            Console.WriteLine("Using marinara sauce");
        }
    }
}