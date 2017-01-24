using System.Collections;

namespace Iterator
{
    public class DinerMenu : Menu
    {
        private readonly ArrayList _items;

        public DinerMenu()
        {
            _items = new ArrayList
            {
                new MenuItem {Name = "AA", Price = 15},
                new MenuItem {Name = "BB", Price = 20},
                new MenuItem {Name = "CC", Price = 25},
                new MenuItem {Name = "DD", Price = 21},
                new MenuItem {Name = "EE", Price = 17}
            };
        }

        public override IIterator CreateIterator()
        {
            return new DinerMenuIterator(_items);
        }
    }
}