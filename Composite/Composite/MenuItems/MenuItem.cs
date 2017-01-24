using System;

namespace Composite.MenuItems
{
    public class MenuItem : MenuComponent
    {
        private readonly string _description;
        private readonly string _name;
        private readonly double _price;
        private readonly bool _vegetarian;

        public MenuItem(string description, string name, bool vegetarian, double price)
        {
            _description = description;
            _name = name;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _vegetarian;
        }

        public override void Print()
        {
            Console.WriteLine("{0}, {1}, {2} : {3}", GetName(), GetDescription(), IsVegetarian() ? "Vegetarian" : "Non-Vegetarian", GetPrice());
        }
        public override IIterator GetIterator()
        {
            return new NullIterator();
        }
    }
}