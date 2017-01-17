using System;

namespace Factory.Ingredients
{
    public class PlumTomatoSauce : ISauce
    {
        public void Use()
        {
            Console.WriteLine("Using plum tomato sauce");
        }
    }
}