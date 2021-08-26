using System;

namespace ActionDele1
{
    class Program
    {
        public static void message(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static public void Main()
        {
            Action<int, int> val = message;
            val(30,10);
        } 
    }
}
