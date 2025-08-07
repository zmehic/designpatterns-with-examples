namespace DesignPatterns.Factory.SimpleFactory
{
    public class PizzaStore
    {
        public IPizza? OrderPizza(PizzaType pizzaType)
        {
            IPizza? pizza = SimplePizzaFactory.GetPizza(pizzaType);

            if(pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }

            return pizza;
        }
    }
}
