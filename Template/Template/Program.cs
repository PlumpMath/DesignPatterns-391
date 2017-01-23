namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeineBeverage beverage1 = new Coffee();
            CoffeineBeverage beverage2 = new Tea();

            beverage1.Prepare();
            beverage2.Prepare();
        }
    }
}
