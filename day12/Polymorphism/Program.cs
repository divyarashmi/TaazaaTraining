using System;

namespace Polymorphism
{
    class Person
    {
        //example of method overloading
        public int walk(int a)//int type
        {
            return a;

        }
        public string walk(string a)//string type
        {
            return a;
        }
        class Program
        {
            public static void Main()
            {
                Person person = new Person();
                int a=person.walk(12);//Association of an object with method is said to be Early Binding
                //association of an object with the overloaded method is called static polymorphism.
                string b=person.walk("Cyber Park");
                Console.WriteLine("in "+b+" "+a+" km");
            }
        }
    }
}
 