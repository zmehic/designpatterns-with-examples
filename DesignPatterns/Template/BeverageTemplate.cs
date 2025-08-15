
using System.Runtime.InteropServices.Marshalling;
using System.Xml;

namespace DesignPatterns.Template
{
    public abstract class BeverageTemplate
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
                AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Water is boiling!");
        }

        public abstract void Brew();

        private void PourInCup()
        {
            Console.WriteLine("Pouring in the cup!");
        }

        public abstract void AddCondiments();

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
