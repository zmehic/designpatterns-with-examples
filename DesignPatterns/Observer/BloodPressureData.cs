namespace DesignPatterns.Observer
{
    public class BloodPressureData : Subject
    {
        private List<Observer> observers;

        private float _bpm;
        private float _sbp;
        private float _dbp;

        public BloodPressureData()
        {
            observers = [];
        }
        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(_bpm, _sbp, _dbp);
            }
        }

        public void UpdateDate(float bpm, float sbp, float dbp)
        {
            _dbp = dbp;
            _bpm = bpm;
            _sbp = sbp;
            NotifyObservers();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void UnregisterObserver(Observer o)
        {
            observers.Remove(o);
        }
    }
}
