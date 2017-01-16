using System;

namespace Factory.Pizzas.Chicago
{
    public class ChicagoClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Veggie pizza!");
            Console.WriteLine("Tossing dough!");
            Console.WriteLine("Adding sauce!");

        }

        public override void Bake()
        {
            Console.WriteLine("Adding for baking!");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting in squares!");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing to special boxes!");
        }
    }
}