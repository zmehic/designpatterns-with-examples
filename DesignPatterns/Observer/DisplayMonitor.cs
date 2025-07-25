namespace DesignPatterns.Observer
{
    public abstract class DisplayMonitor
    {
        public float _bpm, _sbp, _dbp;

        public abstract void Update(float bpm, float sbp, float dbp);
        public abstract void Display();
    }
}
