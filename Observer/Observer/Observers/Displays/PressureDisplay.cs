using System;

namespace Observer.Observers.Displays
{
    public class PressureDisplay : IObserver, IDisplay
    {
        public void Update(IParameters weatherParameters)
        {
            Display(weatherParameters);
        }

        public void Display(IParameters weatherParameters)
        {
            Console.WriteLine("Pressure is: {0}", ((WeatherParameters)weatherParameters).Pressure);
        }
    }
}