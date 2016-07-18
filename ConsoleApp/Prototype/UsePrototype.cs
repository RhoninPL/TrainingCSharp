using System;

namespace ConsoleApplication1.Prototype
{
    public class UsePrototype
    {
        public static void UseExample()
        {
            BasePrototype obj = new BasePrototype();
            BasePrototype obj2 = (BasePrototype) obj.Clone();
            Console.WriteLine(obj.color);
            Console.WriteLine(obj2.color);
        }
    }
}