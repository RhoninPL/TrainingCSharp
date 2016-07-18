using System;
using ConsoleApplication1.Builder.PizzaBuilders;

namespace ConsoleApplication1.Builder
{
    public class UseBuilder
    {
        public static void UseExample()
        {
            Waiter waiter = new Waiter();
            
            waiter.PizzaBuilder = new KebabPizza();
            waiter.ConstructPizza();
            Console.WriteLine(waiter.Pizza);
        }
    }
}