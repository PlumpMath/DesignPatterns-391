using Factory.Ingredients;

namespace Factory.Factories
{
    public interface IPizzaIngredientFactory
    {
        IClam CreateClam();
        ICheese CreateCheese();
        ISauce CreateSauce();
        IDough CreateDough();
    }
}