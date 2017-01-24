namespace Iterator
{
    public class BreakfastMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _currentItem;

        public BreakfastMenuIterator(MenuItem[] items)
        {
            _items = items;
            _currentItem = 0;
        }

        public MenuItem GetNext()
        {
            return _items[_currentItem++];
        }

        public bool HasNext()
        {
            return _currentItem < _items.Length - 1;
        }
    }
}