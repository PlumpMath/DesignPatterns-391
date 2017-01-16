using Factory.Pizzas;
using Factory.Pizzas.Chicago;

namespace Factory.Factories
{
    public class ChicagoPizzaFactory : PizzaFactory
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoCheesePizza();
                case PizzaType.Clam:
                    return new ChicagoClamPizza();
                case PizzaType.Salami:
                    return new ChicagoSalamiPizza();
                case PizzaType.Veggie:
                    return new ChicagoVeggiePizza();
                default:
                    return null;
            }
        }
    }
}