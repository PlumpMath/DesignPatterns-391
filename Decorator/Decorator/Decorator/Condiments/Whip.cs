using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.40;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " with whip";
        }
    }
}