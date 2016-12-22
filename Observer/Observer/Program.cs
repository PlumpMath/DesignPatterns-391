using System;
using Observer.Observers.Displays;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject weatherStation = new WeatherStation();

            weatherStation.AddObserver(new TemperatureDisplay());
            weatherStation.AddObserver(new HumidityDisplay());
            weatherStation.AddObserver(new PressureDisplay());

            while (true)
            {
                string line = Console.ReadLine();
                string[] values = line?.Split(' ');

                if (values?.Length == 3)
                {
                    WeatherParameters weatherParameters = new WeatherParameters
                    {
                        Temperature = Double.Parse(values[0]),
                        Humidity = Double.Parse(values[1]),
                        Pressure = Double.Parse(values[2])
                    };

                    weatherStation.NotifyObservers(weatherParameters);
                }
                
            }
        }
    }
}
