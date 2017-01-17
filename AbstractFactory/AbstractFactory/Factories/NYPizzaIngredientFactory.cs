using Factory.Ingredients;

namespace Factory.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IClam CreateClam()
        {
            return new FrozenClam();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }
    }
}