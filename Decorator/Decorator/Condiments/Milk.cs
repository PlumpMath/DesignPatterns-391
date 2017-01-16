using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.50;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " with milk";
        }
    }
}