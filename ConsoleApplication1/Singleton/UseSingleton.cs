using System;

namespace ConsoleApplication1.Singleton
{
    public class UseSingleton
    {
        public static void UseExample()
        {
            // BaseSingleton obj = new BaseSingleton(); Tego nie można!
            BaseSingleton obj = BaseSingleton.Instance;
            BaseSingleton obj2 = BaseSingleton.Instance;

            obj.Text = "Test 1";
            obj2.Text = "Test 2";
            Console.WriteLine(obj.Text);
            Console.WriteLine(obj2.Text);
        }
    }
}