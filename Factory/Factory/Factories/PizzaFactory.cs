using Factory.Pizzas;

namespace Factory.Factories
{
    public abstract class PizzaFactory
    {
        private Pizza _pizza;

        public Pizza PreparePizza(PizzaType type)
        {
            _pizza = CreatePizza(type);
            _pizza.Prepare();
            _pizza.Bake();
            _pizza.Cut();
            _pizza.Box();

            return _pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}