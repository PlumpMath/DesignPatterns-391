using System;

namespace Factory.Ingredients
{
    public class FreshClam : IClam
    {
        public void Use()
        {
            Console.WriteLine("Using fresh clams");
        }
    }
}