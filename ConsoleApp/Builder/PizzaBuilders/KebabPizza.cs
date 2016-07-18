namespace ConsoleApplication1.Builder.PizzaBuilders
{
    public class KebabPizza : BasePizzaBuilder
    {
        public override void BuildSauce()
        {
            pizza.Sauce = "Ostry pomidorowy";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "Kebab,papryka,cebula,ser";
        }
    }
}