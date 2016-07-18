using ConsoleApplication1.AbstractFactory.Interfaces;

namespace ConsoleApplication1.AbstractFactory.Cars
{
    public class MercedesCar : ICar
    {
        private string name = "Mercedes";

        public string Name
        {
            get { return name; }
        }

        public string Assemble()
        {
            return "Mercedes: wysłanie info do produkcji o złożeniu auta";
        }
    }
}