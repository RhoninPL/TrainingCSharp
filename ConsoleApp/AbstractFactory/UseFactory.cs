using System;
using ConsoleApplication1.AbstractFactory.Factors;
using ConsoleApplication1.AbstractFactory.Interfaces;

namespace ConsoleApplication1.AbstractFactory
{
    public class UseFactory
    {
        public static void UseExample()
        {
            string chooseYourDestiny = "Volkswagen";
            IFactory factory;

            switch (chooseYourDestiny)
            {
                case "Volkswagen":
                    factory = new VolkswagenFactory();
                    break;
                case "Mercedes":
                    factory = new MercedesFactory();
                    break;
                case "Ford":
                    factory = new FordFactory();
                    break;
                default:
                    factory = new FordFactory();
                    break;
            }

            var car = factory.Create();
            Console.WriteLine(car.Assemble());
        }
    }
}