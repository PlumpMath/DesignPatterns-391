namespace Decorator.Beverages
{
    public abstract class Beverage
    {
        protected string Description = "Unknown beverage";
        public abstract double Cost();

        public virtual string GetDescription()
        {
            return Description;
        }
    }
}