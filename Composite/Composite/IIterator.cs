using Composite.MenuItems;

namespace Composite
{
    public interface IIterator
    {
        MenuComponent GetNext();
        bool HasNext();
    }
}