namespace ConsoleApplication1.Builder.PizzaBuilders
{
    public abstract class BasePizzaBuilder
    {
        protected Pizza pizza;

        public Pizza Pizza { get { return pizza; } }

        public void CreateNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void BuildSauce();

        public abstract void BuildTopping();
    }
}