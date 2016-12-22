using System;

namespace Observer.Observers.Displays
{
    public class HumidityDisplay : IObserver, IDisplay
    {
        public void Update(IParameters weatherParameters)
        {
            Display(weatherParameters);
        }

        public void Display(IParameters weatherParameters)
        {
            Console.WriteLine("Humidity is: {0}", ((WeatherParameters)weatherParameters).Humidity);
        }
    }
}