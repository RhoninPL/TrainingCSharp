using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.AbstractFactory;
using ConsoleApplication1.Builder;
using ConsoleApplication1.Prototype;
using ConsoleApplication1.Singleton;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var ob = new InheritClass();
            //ob.SomeMethod();
            //UsePrototype.UseExample();
            //UseSingleton.UseExample();
            //UseFactory.UseExample();
            UseBuilder.UseExample();

            Console.ReadKey();
        }
    }
}
