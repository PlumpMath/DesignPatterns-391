using System;

namespace Factory.Ingredients
{
    public class FrozenClam : IClam
    {
        public void Use()
        {
            Console.WriteLine("Using frozen clams");
        }
    }
}