using System;
using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new DarkRoast();
            Console.WriteLine("Drink name: {0}, cost: {1}eu", beverage.GetDescription(), beverage.Cost());

            Beverage beverage2 = new Expresso();
            beverage2 = new Milk(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine("Drink name: {0}, cost: {1}eu", beverage2.GetDescription(), beverage2.Cost());
        }
    }
}
