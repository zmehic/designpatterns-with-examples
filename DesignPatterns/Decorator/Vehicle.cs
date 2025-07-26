namespace DesignPatterns.Decorator
{
    public abstract class Vehicle
    {
        public string Description { private get; set; } = "Unknown Vehicle";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
