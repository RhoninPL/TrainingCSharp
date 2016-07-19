using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsAs.Products;

namespace IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseProduct product = new BaseProduct()
            {
                Name = "AUDI"
            };
            //Car other = (Car)product;
            //Car other2 = (Car)product;
            //if (other2 == null)
            //{
            //    Console.WriteLine("Jest nullem");
            //}
            Car other3 = product as Car;
            if (other3 == null)
            {
                Console.WriteLine("Jest nullem");
            }
            if (product is BaseProduct)
            {
                Console.WriteLine("Jest BaseProduct");
            }
            else
            {
                Console.WriteLine("Nie jest BaseProduct");
            }

            if (product is Car)
            {
                Console.WriteLine("Jest Car");
            }
            else
            {
                Console.WriteLine("Nie jest Car");
            }

            if (product is Home)
            {
                Console.WriteLine("Jest Home");
            }
            else
            {
                Console.WriteLine("Nie jest Home");
            }

            Console.ReadKey();
        }
    }
}
