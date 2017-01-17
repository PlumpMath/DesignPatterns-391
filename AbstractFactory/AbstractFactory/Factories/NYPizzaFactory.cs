using Factory.Pizzas;
using Factory.Pizzas.NewYork;

namespace Factory.Factories
{
    public class NYPizzaFactory : PizzaFactory
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYCheesePizza(ingredientFactory);
                case PizzaType.Clam:
                    return new NYClamPizza(ingredientFactory);
                case PizzaType.Salami:
                    return new NYSalamiPizza(ingredientFactory);
                case PizzaType.Veggie:
                    return new NYVeggiePizza(ingredientFactory);
                default:
                    return null;
            }
        }
    }
}