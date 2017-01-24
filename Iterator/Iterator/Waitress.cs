using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Waitress
    {
        private readonly List<Menu> _menus = new List<Menu>();

        public void AddMenu(Menu menu)
        {
            _menus.Add(menu);
        }

        public void ListMenus()
        {
            foreach (var menu in _menus)
            {
                IterateMenu(menu.CreateIterator());
            }
        }

        private void IterateMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext().ToString());
            }
        }
    }
}