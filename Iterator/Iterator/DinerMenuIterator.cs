using System.Collections;

namespace Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private readonly ArrayList _items;
        private int _currentItem;

        public DinerMenuIterator(ArrayList items)
        {
            _items = items;
            _currentItem = 0;
        }

        public MenuItem GetNext()
        {
            return (MenuItem)_items[_currentItem++];
        }

        public bool HasNext()
        {
            return _currentItem < _items.Count - 1;
        }
    }
}