using System;
using Day7.Delegate;

delegate int customDelegate();

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Person();
            customDelegate cobj = new customDelegate(obj1.Phoneno);
            var temp1= cobj.Invoke();
            Console.WriteLine(temp1);
            cobj-=obj1.Walk;
            var temp2= cobj.Invoke();
            Console.WriteLine(temp2);
        }
    }
}
