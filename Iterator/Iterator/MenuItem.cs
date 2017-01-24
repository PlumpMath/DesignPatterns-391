using System;

namespace Iterator
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, price: {Price}";
        }
    }
}