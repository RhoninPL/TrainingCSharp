using System;

namespace Training
{
    public class Program
    {
        public void Main()
        {
            int r;
            this.Add(5,5,out r);
            Console.WriteLine(r);
            Console.ReadKey();
        }


        public void Add(int a, int b, out int result)
        {
            result = a + b;
        }
    }
}