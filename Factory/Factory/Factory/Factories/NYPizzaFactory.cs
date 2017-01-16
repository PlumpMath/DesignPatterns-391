using Factory.Pizzas;
using Factory.Pizzas.NewYork;

namespace Factory.Factories
{
    public class NYPizzaFactory : PizzaFactory
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYCheesePizza();
                case PizzaType.Clam:
                    return new NYClamPizza();
                case PizzaType.Salami:
                    return new NYSalamiPizza();
                case PizzaType.Veggie:
                    return new NYVeggiePizza();
                default:
                    return null;
            }
        }
    }
}