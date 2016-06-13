using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Statement
    {
        public static void Write(string option)
        {
            switch (option)
            {
                case "Pierwsza":
                    Console.WriteLine("Pierwsza linia");
                    goto case "Druga";
                case "Druga":
                    Console.WriteLine("Pierwsza linia");
                    break;

                default:
                    Console.WriteLine("Default opcja");
                    break;
            }
        }
    }
}
