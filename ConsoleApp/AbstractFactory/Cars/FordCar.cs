using ConsoleApplication1.AbstractFactory.Interfaces;

namespace ConsoleApplication1.AbstractFactory.Cars
{
    public class FordCar : ICar
    {
        private string name = "Ford";

        public string Name
        {
            get { return name; }
        }

        public string Assemble()
        {
            return "Ford: wysłanie info do produkcji o złożeniu auta";
        }
    }
}