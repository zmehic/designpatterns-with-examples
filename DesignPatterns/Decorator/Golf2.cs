namespace DesignPatterns.Decorator
{
    public class Golf2 : Vehicle
    {
        public Golf2()
        {
            Description = "Golf 2";
        }
        public override double Cost()
        {
            return 1000;
        }
    }
}
