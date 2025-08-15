namespace DesignPatterns.Template
{
    public class CoffeeTemplate : BeverageTemplate
    {
        public override void AddCondiments()
        {   
            Console.WriteLine("Adding Sugar and Milk!");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing coffee!");
        }

        public override bool CustomerWantsCondiments()
        {
            return false;
        }
    }
}
