using System.Collections.Generic;

namespace Observer
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private IParameters _weatherParameters = new WeatherParameters();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public bool RemoveObserver(IObserver observer)
        {
            bool result = false;
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
                result = true;;
            }

            return result;
        }

        public void NotifyObservers(IParameters parameters)
        {
            foreach (var observer in _observers)
            {
                observer.Update(parameters);
            }
        }

        public void MeasurementsChanged(IParameters weatherParameters)
        {
            _weatherParameters = weatherParameters;
            NotifyObservers(weatherParameters);
        }
    }
}