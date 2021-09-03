using System;
using Day8T.AdvanceDelegate;

//delegate void PhoneNoDelegate();
delegate bool StudyDelegate();

namespace Day8T
{
    class Program
    {
        static void Main()
        {
            Study sobj = new Study();
          
            Func<string,string> func = sobj.Name;
            string fobj= func("Divya");
            Console.WriteLine(fobj);
            Action obj = sobj.PhoneNo;
            obj();
            Predicate<string> Pobj= sobj.StudyStatus;
           bool pd = Pobj("Rashmi");
            Console.WriteLine(pd);
        }
    }
}
