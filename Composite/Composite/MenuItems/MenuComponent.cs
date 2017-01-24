using System;

namespace Composite.MenuItems
{
    public abstract class MenuComponent
    {
        public virtual string GetName()
        {
            throw new NotSupportedException();
        }
        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }
        
        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual void Add(MenuComponent component)
        {
            throw new NotSupportedException();
        }

        public virtual bool Remove(MenuComponent component)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual IIterator GetIterator()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsLeaf()
        {
            return true;
        }
    }
}