using System;

namespace Factory.Pizzas.NewYork
{
    public class NYCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Cheese pizza!");
            Console.WriteLine("Tossing dough!");
            Console.WriteLine("Adding sauce!");

        }

        public override void Bake()
        {
            Console.WriteLine("Adding for baking!");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting in triangles!");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing to special boxes!");
        }
    }
}