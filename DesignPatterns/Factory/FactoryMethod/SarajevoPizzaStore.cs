namespace DesignPatterns.Factory.FactoryMethod
{
    public class SarajevoPizzaStore : PizzaStore
    {
        protected override IPizza? CreatePizza(PizzaType pizzaType)
        {
            if (pizzaType == PizzaType.Capricciosa)
                return new SarajevoCapricciosa();
            else if (pizzaType == PizzaType.Margherita)
                return new SarajevoMargherita();

            return null;
        }
    }
}
