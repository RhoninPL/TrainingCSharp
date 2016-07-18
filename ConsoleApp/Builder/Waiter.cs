using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Builder.PizzaBuilders;

namespace ConsoleApplication1.Builder
{
    class Waiter
    {
        private BasePizzaBuilder pizzaBuilder;

        public BasePizzaBuilder PizzaBuilder
        {
            get { return pizzaBuilder; }
            set { pizzaBuilder = value; }
        }

        public Pizza Pizza { get { return pizzaBuilder.Pizza; } }

        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
