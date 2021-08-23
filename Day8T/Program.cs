using System;
using Day8T.AdvanceDelegate;
//delegate string NameDelegate(string N);
delegate void PhoneNoDelegate();
delegate bool StudyDelegate();

namespace Day8T
{
    class Program
    {
        static void Main()
        {
            Study sobj = new Study();
           // NameDelegate nameDelegate = new NameDelegate(sobj.Name);

            //var n = nameDelegate.Invoke("Divya");
            //Console.WriteLine(n);
            Func<string,string> func = sobj.Name;
            string fobj= func("Divya");
            Console.WriteLine(fobj);
        }
    }
}
