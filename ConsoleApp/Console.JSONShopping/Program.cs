using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Console.JSONShopping;
using Newtonsoft.Json;
using Console = System.Console;

namespace JSONShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = null;
            string command = String.Empty;

            try
            {
                string jsonFile = File.ReadAllText("lista_zakupow.JSON");
                list = JsonConvert.DeserializeObject<List<Item>>(jsonFile);
            }
            catch (FileNotFoundException e)
            {
                System.Console.WriteLine("Brak pliku");
            }

            if (list == null)
            {
                list = new List<Item>();
            }

            while (command.ToUpper() != "Q")
            {
                System.Console.WriteLine("W - wypisz elementy");
                System.Console.WriteLine("A - dodaj element");
                System.Console.WriteLine("D - usuń element");
                System.Console.WriteLine("Q - wyjście");
                command = System.Console.ReadLine();
                switch (command.ToUpper())
                {
                    case "W":
                        foreach (var item in list)
                        {
                            System.Console.WriteLine("Produkt: {0}, Cena: {1}", item.Name, item.Price);
                        }
                        break;
                    case "A":
                        System.Console.WriteLine("Wpisz nazwę: ");
                        string name = System.Console.ReadLine();
                        System.Console.WriteLine("Wpisz cenę: ");
                        int price = Convert.ToInt32(System.Console.ReadLine());
                        list.Add(new Item(name, price));
                        System.Console.WriteLine("Dodano!");
                        break;
                    case "D":
                        System.Console.WriteLine("Wpisz nazwę: ");
                        string delete = System.Console.ReadLine();
                        if (list.Remove(new Item(delete)))
                        {
                            System.Console.WriteLine("Element usunięto.");
                        }

                        System.Console.WriteLine("Element nie usunięto.");

                        break;
                }
            }

            string output = JsonConvert.SerializeObject(list);
            File.WriteAllText("lista_zakupow.JSON", output);
            System.Console.WriteLine("Zapisano!");
            System.Console.ReadKey();
        }
    }
}
