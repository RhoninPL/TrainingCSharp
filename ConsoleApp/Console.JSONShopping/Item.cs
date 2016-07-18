using System;

namespace Console.JSONShopping
{
    public class Item : IEquatable<Item>
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Item(string name, int price = 0)
        {
            Name = name;
            Price = price;
        }

        public bool Equals(Item other)
        {
            if (this.Name != null && other != null)
            {
                return this.Name.Equals(other.Name);
            }

            return false;
        }
    }
}