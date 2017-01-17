using System;
using Factory.Factories;

namespace Factory.Pizzas.Chicago
{
    public class ChicagoVeggiePizza : Pizza
    {
        public ChicagoVeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Chicago Veggie pizza!");
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
            Console.WriteLine("Cutting in squares!");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing to special boxes!");
        }
    }
}