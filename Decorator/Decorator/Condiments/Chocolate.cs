using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Chocolate : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Chocolate(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.75;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "with chocolate";
        }
    }
}