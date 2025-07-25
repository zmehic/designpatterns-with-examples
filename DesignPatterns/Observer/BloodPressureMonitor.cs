namespace DesignPatterns.Observer
{
    public class BloodPressureMonitor : DisplayMonitor, Observer
    {
        public Subject _data;

        public BloodPressureMonitor(Subject data)
        {
            _data = data;
            _data.RegisterObserver(this);
        }
        public override void Update(float bpm, float sbp, float dbp)
        {
            _bpm = bpm;
            _sbp = sbp;
            _dbp = dbp;

            Display();
        }
        public override void Display()
        {
            Console.WriteLine($"BP Monitor - BPM {_bpm}, SBP {_sbp}, DBP {_dbp}");
        }
    }
}
