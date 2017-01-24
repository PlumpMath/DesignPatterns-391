using Composite.MenuItems;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent dinerMenu = new Menu("It's menu for diner", "Diner");
            dinerMenu.Add(new MenuItem("AA", "A", true, 5));
            dinerMenu.Add(new MenuItem("BB", "B", false, 51));
            dinerMenu.Add(new MenuItem("CC", "C", true, 25));
            dinerMenu.Add(new MenuItem("DD", "D", true, 7));

            MenuComponent breakfastMenu = new Menu("It's menu for breakfast. Served until 13.00", "Breakfast");
            breakfastMenu.Add(new MenuItem("GG", "g", false, 2));
            breakfastMenu.Add(new MenuItem("HH", "h", true, 4));
            breakfastMenu.Add(new MenuItem("II", "i", false, 31));
            breakfastMenu.Add(new MenuItem("JJ", "j", false, 2));

            MenuComponent dessertMenu = new Menu("It's menu for desserts. Served only during breakfast.", "Dessert");
            dessertMenu.Add(new MenuItem("III", "sdf", true, 5.48));
            dessertMenu.Add(new MenuItem("HF", "sdf", false, 1.25));
            dessertMenu.Add(new MenuItem("CC", "dfg", true, 2.20));
            dinerMenu.Add(dessertMenu);

            MenuComponent allMenus = new Menu("All menus", "List of all menus");
            allMenus.Add(dinerMenu);
            allMenus.Add(breakfastMenu);

            Waitress waitress = new Waitress(allMenus);
            waitress.ListVegetarianMenu();

        }
    }
}
