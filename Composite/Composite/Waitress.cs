using System.Collections.Generic;
using Composite.MenuItems;

namespace Composite
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void ListMenus()
        {
            IIterator iterator = _allMenus.GetIterator();
            while (iterator.HasNext())
            {
                iterator.GetNext().Print();
            }
        }

        public void AddMenu(MenuComponent component)
        {
            _allMenus.Add(component);
        }
    }
}