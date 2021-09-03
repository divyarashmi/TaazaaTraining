using System;
using PartialClassimpl;

namespace PartialClassimpl
{
    class Program
    {
        public static void Main()
        {
            Person person = new Person(105);
            int b =person.getId();
            Console.WriteLine(b);
        }
   
    }
}
