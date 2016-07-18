using ConsoleApplication1.AbstractFactory.Interfaces;

namespace ConsoleApplication1.AbstractFactory.Cars
{
    public class VolkswagenCar : ICar
    {
        private string name = "Volkswagen";

        public string Name
        {
            get { return name; }
        }

        public string Assemble()
        {
            return "Volkswagen: wysłanie info do produkcji o złożeniu auta";
        }
    }
}