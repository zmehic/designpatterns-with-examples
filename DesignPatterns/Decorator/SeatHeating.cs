namespace DesignPatterns.Decorator
{
    public class SeatHeating : EquipmentDecorator
    {
        Vehicle vehicle;

        public SeatHeating(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }
        public override double Cost()
        {
            return vehicle.Cost() + 500;
        }

        public override string GetDescription()
        {
            return $"{vehicle.GetDescription()}, seat heating";
        }
    }
}
