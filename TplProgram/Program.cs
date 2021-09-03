using System;
using System.Threading;

namespace TplProgram
{
    class Myapp
    {
        public static void longtask()
        {
            Thread.Sleep(6000);
            System.Console.WriteLine("Going to karolbagh for major work hopefully it will take time");
        } 
        public static void Main()
        {
            Thread obj= new Thread(new ThreadStart(longtask));
            obj.
            Console.WriteLine("I am inside the main function");
        }
    }
}
