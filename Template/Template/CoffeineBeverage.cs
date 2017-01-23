using System;

namespace Template
{
    public abstract class CoffeineBeverage
    {
        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourToCup()
        {
            Console.WriteLine("Pouring drink to cup");
        }

        public void Prepare()
        {
            BoilWater();
            Brew();
            AddCondiments();
            PourToCup();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
}