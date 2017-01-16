using Factory.Factories;
using Factory.Pizzas;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new NYPizzaFactory();
            factory.PreparePizza(PizzaType.Clam);

            factory = new ChicagoPizzaFactory();
            factory.PreparePizza(PizzaType.Salami);
        }
    }
}
