using System.Runtime.CompilerServices;

namespace DesignPatterns.Decorator
{
    public class AudiA4 : Vehicle
    {
        public AudiA4()
        {
            Description = "Audi A4";
        }
        public override double Cost()
        {
            return 10000;
        }
    }
}
