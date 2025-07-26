namespace DesignPatterns.Decorator
{
    public class SunRoof : EquipmentDecorator
    {
        Vehicle vehicle;

        public SunRoof(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public override double Cost()
        {
            return vehicle.Cost() + 200;
        }

        public override string GetDescription()
        {
            return $"{vehicle.GetDescription()}, sunroof";
        }
    }
}
