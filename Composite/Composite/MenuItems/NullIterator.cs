namespace Composite.MenuItems
{
    public class NullIterator : IIterator
    {
        public MenuComponent GetNext()
        {
            return null;
        }

        public bool HasNext()
        {
            return false;;
        }
    }
}