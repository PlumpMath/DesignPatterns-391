using System;

namespace Facade
{
    public class DVDPlayer
    {
        public void Play(string movie)
        {
            Console.WriteLine("Playing {0} on DVD player", movie);
        }

        public void Pause()
        {
            Console.WriteLine("Pausing DVD player");
        }

        public void Continue()
        {
            Console.WriteLine("Continuing movie");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping movie.");
        }
    }
}