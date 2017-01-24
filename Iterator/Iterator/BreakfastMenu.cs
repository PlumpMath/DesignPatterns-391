namespace Iterator
{
    public class BreakfastMenu : Menu
    {
        private readonly MenuItem[] _items;

        public BreakfastMenu()
        {
            _items = new MenuItem[]
            {
                new MenuItem {Name = "A", Price = 15},
                new MenuItem {Name = "B", Price = 20},
                new MenuItem {Name = "C", Price = 25},
                new MenuItem {Name = "D", Price = 21},
                new MenuItem {Name = "E", Price = 17}
            };
        }

        public override IIterator CreateIterator()
        {
            return new BreakfastMenuIterator(_items);
        }
    }
}