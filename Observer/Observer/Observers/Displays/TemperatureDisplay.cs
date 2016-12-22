using System;

namespace Observer.Observers.Displays
{
    public class TemperatureDisplay : IObserver, IDisplay
    {
        public void Update(IParameters weatherParameters)
        {
            Display(weatherParameters);
        }

        public void Display(IParameters weatherParameters)
        {

            Console.WriteLine("Temperature is: {0}", ((WeatherParameters)weatherParameters).Temperature);
        }
    }
}