namespace Decorator.Beverages

{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "This is expresso coffee";
        }

        public override double Cost()
        {
            return 1.2;
        }
    }
}