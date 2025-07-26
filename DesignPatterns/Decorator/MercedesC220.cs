namespace DesignPatterns.Decorator
{
    public class MercedesC220 : Vehicle
    {
        public MercedesC220()
        {
            Description = "Mercedes C220";
        }
        public override double Cost()
        {
            return 15000;
        }
    }
}
