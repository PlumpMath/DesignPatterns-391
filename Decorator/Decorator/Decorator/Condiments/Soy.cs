﻿using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.70;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "with soy";
        }
    }
}