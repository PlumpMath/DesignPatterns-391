namespace Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "This is house blend coffee";
        }

        public override double Cost()
        {
            return 1.52;
        }
    }
}