namespace DesignPatterns.Observer
{
    public class LifeSupportMonitor : DisplayMonitor,Observer
    {
        public Subject _data;

        public LifeSupportMonitor(Subject data)
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
            Console.WriteLine($"LS Monitor - BPM {_bpm}, SBP {_sbp}, DBP {_dbp}");
        }
    }
}
