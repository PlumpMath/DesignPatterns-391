using Factory.Factories;

namespace Factory.Pizzas
{
    public abstract class Pizza
    {
        protected IPizzaIngredientFactory IngredientFactory;

        public virtual void Prepare()
        {
            IngredientFactory.CreateDough().Use();
            IngredientFactory.CreateSauce().Use();
            IngredientFactory.CreateCheese().Use();
            IngredientFactory.CreateClam().Use();
        }
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}