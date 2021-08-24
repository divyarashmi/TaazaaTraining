using System;
using PartialClass.PartiClass;

namespace PartialClass
{
    class Program
    {
        public static void Main()
        {
            Person person = new Person(105);
            int a = person.getid();
            Console.WriteLine(a);
        }
    }
}
