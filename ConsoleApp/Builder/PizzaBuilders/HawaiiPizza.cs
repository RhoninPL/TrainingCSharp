namespace ConsoleApplication1.Builder.PizzaBuilders
{
    public class HawaiiPizza : BasePizzaBuilder
    {
        public override void BuildSauce()
        {
            pizza.Sauce = "Łagodny";
        }

        public override void BuildTopping()
        {
            pizza.Topping = "Ananas,szynka,ser";
        }
    }
}