using System;
using System.Collections.Generic;

namespace Composite.MenuItems
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _components = new List<MenuComponent>();
        private readonly string _description;
        private readonly string _name;

        public Menu(string description, string name)
        {
            _description = description;
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.WriteLine("\n\nThis is {0} menu. {1}\n---------------------------", GetName(), GetDescription());
            foreach (var menuComponent in _components)
            {
                menuComponent.Print();
                IIterator iterator = menuComponent.GetIterator();
                while (iterator.HasNext())
                {
                    iterator.GetNext().Print();
                }
            }
        }

        public override void Add(MenuComponent component)
        {
            _components.Add(component);
        }

        public override bool Remove(MenuComponent component)
        {
            return _components.Remove(component);
        }

        public override MenuComponent GetChild(int i)
        {
            return _components[i];
        }

        public override IIterator GetIterator()
        {
            return new MenuComponentIterator(_components);
        }
    }
}