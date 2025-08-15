namespace DesignPatterns.Template
{
    public class TeaTemplate : BeverageTemplate
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon!");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing tea!");
        }
    }
}
