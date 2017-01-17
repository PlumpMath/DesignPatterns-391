using Factory.Ingredients;

namespace Factory.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IClam CreateClam()
        {
            return new FreshClam();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }
    }
}