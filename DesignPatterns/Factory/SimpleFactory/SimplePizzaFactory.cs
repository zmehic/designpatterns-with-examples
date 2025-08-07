namespace DesignPatterns.Factory.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public static IPizza? GetPizza(PizzaType pizzaType)
        {
            if (pizzaType == PizzaType.Capricciosa)
                return new Capricciosa();
            else if (pizzaType == PizzaType.Margherita)
                return new Margherita();

            return null;
        }
    }
}
