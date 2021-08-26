using System;

namespace PredicateDele1
{
    class Program
    {
        public static bool message(string mystring)
        {
            if (mystring.Length > 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public void Main()
        {
            Predicate<string> val = message;
            Console.WriteLine(val("RashmiDivya"));
        }
    }
}
