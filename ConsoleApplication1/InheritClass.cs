using System;

namespace ConsoleApplication1
{
    public class InheritClass : BaseClass
    {
        public new void SomeMethod()
        {
            Console.WriteLine("Klasa pochodna");
        }
    }
}