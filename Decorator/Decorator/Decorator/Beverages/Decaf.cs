namespace Decorator.Beverages

{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "This is decaf coffee";
        }

        public override double Cost()
        {
            return 1.35;
        }
    }
}