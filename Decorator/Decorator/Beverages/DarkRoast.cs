namespace Decorator.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "This is dark roast coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}