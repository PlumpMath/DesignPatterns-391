using System;

namespace Facade
{
    public class MusicPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on speakers");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off speakers");
        }
    }
}