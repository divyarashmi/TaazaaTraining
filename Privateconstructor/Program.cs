using System;

namespace Privateconstructor
{
    class Program
    {
        public static string name; 
        public static int num;
        private Program()
        {
            Console.WriteLine("Welcome to Priv Constructor");
           
        }
        public Program(string a, int b)
        {
            name = a; 
            num = b; 
        }
        public static void Main()
        {
            Program obj2 = new Program("Divya" , 102);
            Console.WriteLine(Program.name + " " + Program.num);
        } 
    }
}
