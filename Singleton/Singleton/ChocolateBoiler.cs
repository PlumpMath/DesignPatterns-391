using System;

namespace Singleton
{
    public class ChocolateBoiler
    {
        private static readonly ChocolateBoiler Boilder = new ChocolateBoiler();
        private bool _empty;
        private bool _boiled;
        private readonly object _emptyLock = new object();
        private readonly object _boiledLock = new object();
        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            return Boilder;
        }

        public void Fill()
        {
            if (_empty)
            {
                lock (_emptyLock)
                {
                    if (_empty)
                    {
                        Console.WriteLine("Filling boiler");
                        _empty = false;
                    }
                }
            }
        }

        public void Boil()
        {
            if (!_empty && !_boiled)
            {
                lock (_emptyLock)
                {
                    lock (_boiledLock)
                    {
                        if (!_empty && !_boiled)
                        {
                            Console.WriteLine("Boiling boiler");
                            _boiled = true;
                        }
                    }
                }
            }
        }

        public void Drain()
        {
            if (!_empty && _boiled)
            {
                lock (_emptyLock)
                {
                    lock (_boiledLock)
                    {
                        if (!_empty && _boiled)
                        {
                            Console.WriteLine("Draining boiler");
                            _empty = true;
                            _boiled = false;
                        }
                    }
                }
            }
        }
    }
}