﻿using ConsoleApplication1.AbstractFactory.Cars;
using ConsoleApplication1.AbstractFactory.Interfaces;

namespace ConsoleApplication1.AbstractFactory.Factors
{
    public class MercedesFactory : IFactory
    {

        public ICar Create()
        {
            return new MercedesCar();
        }
    }
}