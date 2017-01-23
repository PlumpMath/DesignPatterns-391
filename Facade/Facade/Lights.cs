using System;

namespace Facade
{
    public class Lights
    {
        public void SetBrightness(int brightness = 100)
        {
            Console.WriteLine("Turning lights on {0} brightness", brightness);
        }
    }
}