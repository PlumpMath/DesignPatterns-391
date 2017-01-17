using Factory.Pizzas;
using Factory.Pizzas.Chicago;

namespace Factory.Factories
{
    public class ChicagoPizzaFactory : PizzaFactory
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoCheesePizza(ingredientFactory);
                case PizzaType.Clam:
                    return new ChicagoClamPizza(ingredientFactory);
                case PizzaType.Salami:
                    return new ChicagoSalamiPizza(ingredientFactory);
                case PizzaType.Veggie:
                    return new ChicagoVeggiePizza(ingredientFactory);
                default:
                    return null;
            }
        }
    }
}