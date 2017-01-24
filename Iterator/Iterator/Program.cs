namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress();
            waitress.AddMenu(new BreakfastMenu());
            waitress.AddMenu(new DinerMenu());

            waitress.ListMenus();
        }
    }
}
