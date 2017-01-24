using System;
using System.Collections.Generic;

namespace Composite.MenuItems
{
    public class MenuComponentIterator : IIterator
    {
        private readonly List<MenuComponent> _components;
        private int _number = 0;

        public MenuComponentIterator(List<MenuComponent> components)
        {
            if (components == null)
                throw new ArgumentNullException(nameof(components));
            _components = components;
        }

        public MenuComponent GetNext()
        {
            return _components[_number++];
        }

        public bool HasNext()
        {
            return _components.Count > _number;
        }
    }
}