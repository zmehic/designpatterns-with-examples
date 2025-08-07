namespace DesignPatterns.Factory.FactoryMethod
{
    public class MostarPizzaStore : PizzaStore
    {
        protected override IPizza? CreatePizza(PizzaType pizzaType)
        {
            if (pizzaType == PizzaType.Capricciosa)
                return new MostarCapricciosa();
            else if (pizzaType == PizzaType.Margherita)
                return new MostarMargherita();

            return null;
        }
    }
}
