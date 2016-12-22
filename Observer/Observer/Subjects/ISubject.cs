namespace Observer
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        bool RemoveObserver(IObserver observer);
        void NotifyObservers(IParameters parameters);
    }
}