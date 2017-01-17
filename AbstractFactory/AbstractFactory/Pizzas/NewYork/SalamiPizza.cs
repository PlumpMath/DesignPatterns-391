using System;
using Factory.Factories;

namespace Factory.Pizzas.NewYork
{
    public class NYSalamiPizza : Pizza
    {
        public NYSalamiPizza(IPizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing New York Salami pizza!");
            Console.WriteLine("Tossing dough!");
            Console.WriteLine("Adding sauce!");
            base.Prepare();

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