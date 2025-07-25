namespace DesignPatterns.Observer
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void UnregisterObserver(Observer o);
        void NotifyObservers();
    }
}
