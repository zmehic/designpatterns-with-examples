namespace DesignPatterns.Factory.FactoryMethod
{
    public abstract class PizzaStore
    {
        public IPizza? OrderPizza(PizzaType pizzaType)
        {
            IPizza? pizza = CreatePizza(pizzaType);

            if(pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }

            return pizza;
        }

        protected abstract IPizza? CreatePizza(PizzaType pizzaType);
    }
}
